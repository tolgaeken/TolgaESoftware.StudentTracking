using System;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.OverdueStatementsForms
{
    public partial class OverdueStatementsEditForm : BaseEditForm
    {
        #region Variables
        private readonly int _paymentInformationsId;
        #endregion

        public OverdueStatementsEditForm(params object[] prm)
        {
            InitializeComponent();
            _paymentInformationsId = (int)prm[0];

            DataLayoutControl = myDataLayoutControl;
            Bll = new OverdueStatementsBll(myDataLayoutControl);
            BaseCardType = CardType.Statement;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new OverdueStatementsSingle() : ((OverdueStatementsBll)Bll).Single(FilterFunctions.Filter<OverdueStatements>(Id));
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((OverdueStatementsBll)Bll).GetNewCode(p => p.PaymentInformationsId == _paymentInformationsId);
            txtStatement.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (OverdueStatementsSingle)OldEntity;

            txtCode.Text = entity.Code;
            txtUserName.Text = BaseProcessType == ProcessType.EntityInsert ? MainForm.UserName: entity.UserName;
            txtDateTime.DateTime = BaseProcessType == ProcessType.EntityInsert ? DateTime.Now : entity.DateTime; 
            txtStatement.Text = entity.Statement;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new OverdueStatements
            {
                Id = Id,
                Code = txtCode.Text,
                PaymentInformationsId = _paymentInformationsId,
                UserId = BaseProcessType==ProcessType.EntityInsert ? MainForm.UserId : 0,
                DateTime = txtDateTime.DateTime,
                Statement = txtStatement.Text,
                
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            return ((OverdueStatementsBll)Bll).Insert(CurrentEntity, p => p.Code == CurrentEntity.Code && p.PaymentInformationsId == _paymentInformationsId);
        }

        protected override bool EntityUpdate()
        {
            return ((OverdueStatementsBll)Bll).Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code && p.PaymentInformationsId == _paymentInformationsId);
        }
    }
}