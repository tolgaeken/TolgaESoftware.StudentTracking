using System;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.DocumentForms
{
    public partial class DocumentListForm : BaseListForm
    {
        #region Variables
        private readonly Expression<Func<Document, bool>> _filter;
        #endregion

        public DocumentListForm()
        {
            InitializeComponent();

            Bll = new DocumentBll();
            _filter = p => p.Status == ShowActiveCards && p.BranchId == MainForm.BranchId
                                                              && p.TermId == MainForm.TermId;
        }

        public DocumentListForm(params object[] prm) : this()
        {
            _filter = p => !UnlistedData.Contains(p.Id) && p.Status == ShowActiveCards
                                                        && p.BranchId == MainForm.BranchId
                                                        && p.TermId == MainForm.TermId;
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Document;
            FormShow = new ShowEditForms<DocumentEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            var list = ((DocumentBll)Bll).List(_filter);
            Table.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any()) HasAddableEntity = true;
            else Messages.CardNotFoundMessage("Kart");
        }
    }
}