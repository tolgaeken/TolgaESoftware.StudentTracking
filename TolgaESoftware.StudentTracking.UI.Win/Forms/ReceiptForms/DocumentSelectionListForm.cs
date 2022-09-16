using System;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms
{
    public partial class DocumentSelectionListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<PaymentInformations, bool>> _filter;
        private readonly ReceiptType _receiptType;
        private readonly ReceiptAccountType _accountType;
        private readonly long _accountId;

        #endregion

        public DocumentSelectionListForm(params object[] prm)
        {
            InitializeComponent();

            _receiptType = (ReceiptType)prm[0];
            _accountType = (ReceiptAccountType)prm[1];
            _accountId = prm[2] != null ? (long)prm[2] : 0;

            _filter = p => !UnlistedData.Contains(p.Id) && p.Accrue.TermId == MainForm.TermId;

            HideItems = new BarItem[]{btnNew,btnDelete,btnEdit,barInsert,barInsertStatement,barDelete,barDeleteStatement,barEdit,barEditStatement};
            ShowItems = new BarItem[]{btnDocumentActions};
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Service;
            Navigator = longNavigator.navigator;
            Text = $"{Text} - {_receiptType.ToName()} - ( {_accountType.ToName()} )";
        }

        protected override void List()
        {
            using (var bll = new DocumentSelectionBll())
            {
                var list = bll
                    .List(_filter, _receiptType, _accountType, _accountType.ToName().GetEnum<PaymentType>(), _accountId, MainForm.BranchId);

                Table.GridControl.DataSource = list;

                if (!MultiSelect) return;
                if (list.Any()) HasAddableEntity = true;

                else Messages.CardNotFoundMessage("Belge");
            }
        }

        protected override void ShowHideColumns()
        {
            if (table.DataRowCount == 0) return;
            var entity = table.GetRow<DocumentSelectionList>(false);
            if (entity == null) return;

            bndDocumentDetailInformations.Visible =
                entity.PaymentType == PaymentType.Cheque || entity.PaymentType == PaymentType.Indenture;

            colTrackNumber.Visible = entity.PaymentType == PaymentType.Pos;
            colBankName.Visible = entity.PaymentType == PaymentType.Epos || entity.PaymentType == PaymentType.Pos ||
                                  entity.PaymentType == PaymentType.Sps;

            colBankName.Visible = entity.PaymentType == PaymentType.Cheque;
            colBankBranchName.Visible = entity.PaymentType == PaymentType.Cheque;
            colAccountNumber.Visible = entity.PaymentType == PaymentType.Cheque;
            colDocumentNumber.Visible = entity.PaymentType == PaymentType.Cheque;
            colPrincipalDebtor.Visible = entity.PaymentType == PaymentType.Cheque || entity.PaymentType == PaymentType.Indenture;
            colEndorser.Visible = entity.PaymentType == PaymentType.Cheque || entity.PaymentType == PaymentType.Indenture;
        }
        protected override void DocumentActions()
        {
            var entity = table.GetRow<DocumentSelectionList>();
            if (entity == null) return;
            ShowListForms<DocumentActionsListForm>
                .ShowDialogListForm(CardType.DocumentActions, null, entity.PaymentInformationsId);
        }
    }
}