using System;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BankAccountForms
{
    public partial class BankAccountListForm : BaseListForm
    {

        #region Variables
        private readonly Expression<Func<BankAccount, bool>> _filter;
        private readonly BankAccountType _bankAccountType = BankAccountType.DemandDepositAccount;
        #endregion

        public BankAccountListForm()
        {
            InitializeComponent();
            Bll = new BankAccountBll();
            _filter = p => p.Status == ShowActiveCards
                           && p.BranchId == MainForm.BranchId;

        }

        public BankAccountListForm(params object[] prm) : this()
        {
            if (prm[0].GetType() == typeof(BankAccountType)) _bankAccountType = (BankAccountType)prm[0];

            else if (prm[0].GetType() == typeof(PaymentType))
            {
                var paymentType = (PaymentType)prm[0];
                switch (paymentType)
                {
                    case PaymentType.Epos:
                        _bankAccountType = BankAccountType.BlockedEposAccount;
                        break;
                    case PaymentType.Sps:
                        _bankAccountType = BankAccountType.BlockedSpsAccount;
                        break;
                    case PaymentType.Pos:
                        _bankAccountType = BankAccountType.BlockedPosAccount;
                        break;
                }
            }

            _filter = p => p.Status == ShowActiveCards && p.BankAccountType == _bankAccountType && p.BranchId == MainForm.BranchId;
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.BankAccount;
            FormShow = new ShowEditForms<BankAccountEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((BankAccountBll)Bll).List(_filter);
        }
    }
}