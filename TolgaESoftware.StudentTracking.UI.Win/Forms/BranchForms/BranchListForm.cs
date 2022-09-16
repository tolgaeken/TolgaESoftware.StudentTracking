using System;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BranchForms
{
    public partial class BranchListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<Branch, bool>> _filter;
        #endregion

        public BranchListForm()
        {
            InitializeComponent();
            Bll = new BranchBll();

            _filter = p => p.Status == ShowActiveCards;

        }

        public BranchListForm(params object[] prm) : this()
        {
            if ((bool) prm[0])
                _filter = p => p.Status == ShowActiveCards && p.Id != MainForm.BranchId;
            
            else if(!(bool) prm[0])
                _filter = p => !UnlistedData.Contains(p.Id) && p.Status == ShowActiveCards;
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Branch;
            FormShow = new ShowEditForms<BranchEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((BranchBll)Bll).List(FilterFunctions.Filter<Branch>(ShowActiveCards));

            var list = ((BranchBll) Bll).List(_filter);
            Table.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if(list.Any()) HasAddableEntity = true;
            else Messages.CardNotFoundMessage("Kart");
        }
    }
}