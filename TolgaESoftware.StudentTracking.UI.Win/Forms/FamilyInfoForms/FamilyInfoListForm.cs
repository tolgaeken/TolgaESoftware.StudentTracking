using System;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.FamilyInfoForms
{
    public partial class FamilyInfoListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<FamilyInfo, bool>> _filter;
        #endregion

        public FamilyInfoListForm()
        {
            InitializeComponent();
            Bll = new FamilyInfoBll();
            _filter = p => p.Status == ShowActiveCards;
        }

        public FamilyInfoListForm(params object[] prm) : this()
        {
            _filter = p => !UnlistedData.Contains(p.Id) && p.Status == ShowActiveCards;
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.FamilyInfo;
            FormShow = new ShowEditForms<FamilyInfoEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            var list = ((FamilyInfoBll)Bll).List(_filter);
            Table.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any()) HasAddableEntity = true;
            else Messages.CardNotFoundMessage("Kart");
        }
    }
}