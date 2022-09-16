using System;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Utils.Extensions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ServiceForms
{
    public partial class ServiceListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<Service, bool>> _filter;
        #endregion

        public ServiceListForm()
        {
            InitializeComponent();
            Bll = new ServiceBll();
            _filter=p => p.Status == ShowActiveCards
                        && p.BranchId == MainForm.BranchId
                        && p.TermId == MainForm.TermId;
        }

        public ServiceListForm(params object[] prm) : this()
        {
            if (prm != null)
            {
                var showPanel = (bool) prm[0];
                topPanel.Visible = DateTime.Now.Date > MainForm.TermParameters.EducationStartDate && showPanel;
            }

            _filter = p => !UnlistedData.Contains(p.Id) 
                           && p.BranchId == MainForm.BranchId
                           && p.TermId == MainForm.TermId
                           && p.Status == ShowActiveCards;
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Service;
            FormShow = new ShowEditForms<ServiceEditForm>();
            Navigator = longNavigator.navigator;
            SetDate();
        }

        protected override void List()
        {
            var list = ((ServiceBll) Bll).List(_filter);
            Table.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if(list.Any()) HasAddableEntity = true;
            else Messages.CardNotFoundMessage("Kart");
        }

        private void SetDate()
        {
            if (MainForm.TermParameters.ServiceStartDateCanEnteredBeforeDayDate)
                txtServiceStartDate.Properties.MinValue = MainForm.TermParameters.EducationStartDate;
            else if (DateTime.Now.Date < MainForm.TermParameters.EducationStartDate)
                txtServiceStartDate.Properties.MinValue = MainForm.TermParameters.EducationStartDate;
            else
                txtServiceStartDate.Properties.MinValue = DateTime.Now.Date;

            if (MainForm.TermParameters.ServiceStartDateCanEnteredAfterDayDate)
                txtServiceStartDate.Properties.MaxValue = MainForm.TermParameters.TermEndDate;
            else if (DateTime.Now.Date < MainForm.TermParameters.EducationStartDate)
                txtServiceStartDate.Properties.MaxValue = MainForm.TermParameters.EducationStartDate;
            else if (DateTime.Now.Date > MainForm.TermParameters.TermEndDate)
                txtServiceStartDate.Properties.MaxValue = MainForm.TermParameters.TermEndDate;
            else
                txtServiceStartDate.Properties.MaxValue = DateTime.Now.Date;

            if (DateTime.Now <= MainForm.TermParameters.EducationStartDate)
                txtServiceStartDate.DateTime = MainForm.TermParameters.EducationStartDate;
            else if (DateTime.Now.Date > MainForm.TermParameters.EducationStartDate &&
                     DateTime.Now.Date <= MainForm.TermParameters.TermEndDate)
                txtServiceStartDate.DateTime = DateTime.Now.Date;
            else if (DateTime.Now.Date > MainForm.TermParameters.TermEndDate)
                txtServiceStartDate.DateTime = MainForm.TermParameters.TermEndDate;
            else
                txtServiceStartDate.DateTime = DateTime.Now.Date;
        }

        protected override void SelectEntity()
        {
            base.SelectEntity();

            if (MultiSelect)
                SelectedEntities.ForEach(p=> ((ServiceList)p).StartDate=txtServiceStartDate.DateTime.Date);
        }
    }
}