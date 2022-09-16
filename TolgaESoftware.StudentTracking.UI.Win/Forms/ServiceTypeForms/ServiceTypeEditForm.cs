using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ServiceTypeForms
{
    public partial class ServiceTypeEditForm : BaseEditForm
    {
        public ServiceTypeEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ServiceTypeBll(myDataLayoutControl);
            txtServiceType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<ServiceTypeEnum>());
            BaseCardType = CardType.ServiceType;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new ServiceType() : ((ServiceTypeBll) Bll).Single(FilterFunctions.Filter<ServiceType>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((ServiceTypeBll) Bll).GetNewCode();
            txtServiceTypeName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (ServiceType) OldEntity;

            txtCode.Text = entity.Code;
            txtServiceTypeName.Text = entity.ServiceTypeName;
            txtServiceType.SelectedItem = entity.ServiceTypeEnum.ToName();
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new ServiceType
            {
                Id = Id,
                Code = txtCode.Text,
                ServiceTypeName = txtServiceTypeName.Text,
                ServiceTypeEnum = txtServiceType.Text.GetEnum<ServiceTypeEnum>(),
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}