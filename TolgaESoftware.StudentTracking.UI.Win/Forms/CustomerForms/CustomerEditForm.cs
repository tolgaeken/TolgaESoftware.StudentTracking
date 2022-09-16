using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.CustomerForms
{
    public partial class CustomerEditForm : BaseEditForm
    {
        public CustomerEditForm()
        {
            InitializeComponent();
       
            DataLayoutControl = myDataLayoutControl;
            Bll = new CustomerBll(myDataLayoutControl);
            BaseCardType = CardType.Customer;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new CustomerSingle() : ((CustomerBll) Bll).Single(FilterFunctions.Filter<Customer>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((CustomerBll) Bll).GetNewCode();
            txtCustomerName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (CustomerSingle) OldEntity;

            txtCode.Text = entity.Code;
            txtCustomerName.Text = entity.CustomerName;
            txtTrIdentityNumber.Text = entity.TrIdentityNumber;
            txtPhone1.Text = entity.Phone1;
            txtPhone2.Text = entity.Phone2;
            txtPhone3.Text = entity.Phone3;
            txtPhone4.Text = entity.Phone4;
            txtFax.Text = entity.Fax;
            txtWeb.Text = entity.Web;
            txtEMail.Text = entity.EMail;
            txtTaxAdministration.Text = entity.TaxAdministration;
            txtTaxNumber.Text = entity.TaxNumber;
            txtAddress.Text = entity.Address;
            txtSpecialCode1.Id = entity.SpecialCode1Id;
            txtSpecialCode1.Text = entity.SpecialCode1Name;
            txtSpecialCode2.Id = entity.SpecialCode2Id;
            txtSpecialCode2.Text = entity.SpecialCode2Name;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Customer
            {
                Id = Id,
                Code = txtCode.Text,
                CustomerName = txtCustomerName.Text,
                TrIdentityNumber = txtTrIdentityNumber.Text,
                Phone1 = txtPhone1.Text,
                Phone2 = txtPhone2.Text,
                Phone3 = txtPhone3.Text,
                Phone4 = txtPhone4.Text,
                Fax = txtFax.Text,
                Web = txtWeb.Text,
                EMail = txtEMail.Text,
                TaxAdministration = txtTaxAdministration.Text,
                TaxNumber = txtTaxNumber.Text,
                Address = txtAddress.Text,
                SpecialCode1Id = txtSpecialCode1.Id,
                SpecialCode2Id = txtSpecialCode2.Id,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtSpecialCode1) select.Select(txtSpecialCode1,CardType.Customer);
                else if (sender == txtSpecialCode2) select.Select(txtSpecialCode2,CardType.Customer);
        }
    }
}