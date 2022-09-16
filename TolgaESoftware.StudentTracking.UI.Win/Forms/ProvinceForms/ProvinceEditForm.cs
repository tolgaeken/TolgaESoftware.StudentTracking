using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ProvinceForms
{
    public partial class ProvinceEditForm : BaseEditForm
    {
        public ProvinceEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new ProvinceBll(myDataLayoutControl);
            BaseCardType = CardType.Province;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Province() : ((ProvinceBll) Bll).Single(FilterFunctions.Filter<Province>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((ProvinceBll) Bll).GetNewCode();
            txtProvinceName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Province) OldEntity;

            txtCode.Text = entity.Code;
            txtProvinceName.Text = entity.ProvinceName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Province
            {
                Id = Id,
                Code = txtCode.Text,
                ProvinceName = txtProvinceName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}