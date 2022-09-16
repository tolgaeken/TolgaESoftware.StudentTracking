using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.DistrictForms
{
    public partial class DistrictEditForm : BaseEditForm
    {
        #region Variables
        private readonly long _provinceId;
        private readonly string _provinceName; 
        #endregion

        public DistrictEditForm(params object[] prm)
        {
            InitializeComponent();

            _provinceId = (long) prm[0];
            _provinceName = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new DistrictBll(myDataLayoutControl);
            BaseCardType = CardType.District;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new District() : ((DistrictBll) Bll).Single(FilterFunctions.Filter<District>(Id));
            LinkObjectToControls();
            Text = Text + $" - ( {_provinceName} )"; 

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((DistrictBll) Bll).GetNewCode(p=>p.ProvinceId==_provinceId);
            txtDistrictName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (District) OldEntity;

            txtCode.Text = entity.Code;
            txtDistrictName.Text = entity.DistrictName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new District
            {
                Id = Id,
                Code = txtCode.Text,
                DistrictName = txtDistrictName.Text,
                ProvinceId = _provinceId,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            return ((DistrictBll) Bll).Insert(CurrentEntity, p => p.Code == CurrentEntity.Code && p.ProvinceId == _provinceId);
        }

        protected override bool EntityUpdate()
        {
            return ((DistrictBll) Bll).Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code && p.ProvinceId == _provinceId);
        }
    }
}