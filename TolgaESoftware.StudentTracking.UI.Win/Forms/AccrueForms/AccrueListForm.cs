using System;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms
{
    public partial class AccrueListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<Accrue, bool>> _filter;

        #endregion
        public AccrueListForm()
        {
            InitializeComponent();

            Bll = new AccrueBll();

            HideItems = new BarItem[] {btnNew};

            _filter=p => p.Status == ShowActiveCards
                         && p.BranchId == MainForm.BranchId
                         && p.TermId == MainForm.TermId;
        }

        public AccrueListForm(params object[] prm) : this()
        {
            _filter = p => !UnlistedData.Contains(p.Id) 
                           && p.BranchId == MainForm.BranchId
                           && p.TermId == MainForm.TermId
                           && p.Status == ShowActiveCards;
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Accrue;
            FormShow = new ShowEditForms<AccrueEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            var list = ((AccrueBll) Bll).List(_filter);
            Table.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if(list.Any()) HasAddableEntity = true;
            else Messages.CardNotFoundMessage("Kart");
        }
    }
}