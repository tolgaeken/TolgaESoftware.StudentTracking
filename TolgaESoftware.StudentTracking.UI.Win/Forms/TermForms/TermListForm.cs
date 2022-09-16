using System;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.TermForms
{
    public partial class TermListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<Term, bool>> _filter;

        #endregion

        public TermListForm()
        {
            InitializeComponent();
            Bll = new TermBll();
            _filter = p => p.Status == ShowActiveCards;

            ShowItems = new BarItem[] { btnParameters, barParameters, barParametersSatement };
        }

        public TermListForm(params object[] prm) : this()
        {
            _filter = p => !UnlistedData.Contains(p.Id) && p.Status == ShowActiveCards;
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Term;
            FormShow = new ShowEditForms<TermEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            var list = ((TermBll)Bll).List(_filter);
            Table.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any()) HasAddableEntity = true;
            else Messages.CardNotFoundMessage("Kart");
        }

        protected override void OpenLinkedCard()
        {
            var entity = table.GetRow<Term>();
            if (entity == null) return;
            ShowEditForms<TermParameterEditForm>.ShowDialogEditForm(null, entity.Id);
        }
    }
}