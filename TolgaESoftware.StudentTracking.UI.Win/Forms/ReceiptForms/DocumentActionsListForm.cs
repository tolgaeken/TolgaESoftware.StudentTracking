using System.Linq;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ReceiptForms
{
    public partial class DocumentActionsListForm : BaseListForm
    {
        private readonly int _paymentInformationsId;

        public DocumentActionsListForm(params object[] prm)
        {
            InitializeComponent();

            HideItems = new BarItem[] 
                {btnNew,btnDelete,btnSelect,barInsert,barInsertStatement,barDelete,barDeleteStatement,barEnter,barEnterStatement};

            _paymentInformationsId = (int) prm[0];
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.DocumentActions;
            Navigator = longNavigator.navigator;
            Navigator.TextStringFormat = "Belge Hareketleri ( {0} / {1} )";
        }

        protected override void List()
        {
            using (var bll = new DocumentActionsBll())
            {
                var list = bll.List(p => p.PaymentInformationsId == _paymentInformationsId).Cast<DocumentActionsList>().ToList();
                if (!list.Any())
                {
                    Messages.WarningMessage("Seçilen Ödeme Belgesine Ait Hareket Bulunmamaktadır");
                    Close();
                    return;
                }

                var entity = list[0];

                txtNumber.Text = entity.StudentNumber;
                txtName.Text = entity.Name;
                txtLastname.Text = entity.Lastname;
                txtClassName.Text = entity.ClassName;
                txtBranchName.Text = entity.StudentBranchName;
                txtBankName.Text = entity.StudentBranchName;
                txtBankBranchName.Text = entity.BankBranchName;
                txtWalletNumber.EditValue = entity.PaymentInformationsId;
                txtPaymentMethod.Text = entity.PaymentMethodName;
                txtEntryDate.DateTime = entity.EntryDate;
                txtPaymentTerm.DateTime = entity.PaymentTerm;
                txtAccountTransferDate.DateTime = entity.AccountTransferDate;
                txtPrice.Value = entity.Price;
                txtPrincipalDebtor.Text = entity.PrincipalDebtor;
                txtEndorser.Text = entity.Endorser;
                txtAccountNumber.Text = entity.AccountNumber;
                txtDocumentNumber.Text = entity.DocumentNumber;

                grid.DataSource = list;
                //table.GridControl.DataSource = list;
            }
        }

        protected override void ShowEditForm(long id)
        {
            var entity = table.GetRow<DocumentActionsList>();

            if(entity==null) return;

            if (entity.BranchId != MainForm.BranchId) 
                ShowEditForms<ReceiptEditForm>.ShowDialogEditForm(CardType.Receipt,id,entity.ReceiptType,entity.AccountType,true);
            else
            {
                var result = ShowEditForms<ReceiptEditForm>.ShowDialogEditForm(CardType.Receipt,id,entity.ReceiptType,entity.AccountType);
                ShowEditFormDefault(result);
            }
        }
    }
}