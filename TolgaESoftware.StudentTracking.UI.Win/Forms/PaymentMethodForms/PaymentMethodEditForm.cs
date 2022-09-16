using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.PaymentMethodForms
{
    public partial class PaymentMethodEditForm : BaseEditForm
    {
        public PaymentMethodEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PaymentMethodBll(myDataLayoutControl);
            txtPaymentType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<PaymentType>());
            BaseCardType = CardType.PaymentMethod;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new PaymentMethod() : ((PaymentMethodBll) Bll).Single(FilterFunctions.Filter<PaymentMethod>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((PaymentMethodBll) Bll).GetNewCode();
            txtPaymentMethodName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (PaymentMethod) OldEntity;

            txtCode.Text = entity.Code;
            txtPaymentMethodName.Text = entity.PaymentMethodName;
            txtPaymentType.SelectedItem = entity.PaymentType.ToName();
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new PaymentMethod
            {
                Id = Id,
                Code = txtCode.Text,
                PaymentMethodName = txtPaymentMethodName.Text,
                PaymentType = txtPaymentType.Text.GetEnum<PaymentType>(),
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}