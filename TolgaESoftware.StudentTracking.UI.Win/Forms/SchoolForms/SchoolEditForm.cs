using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using BaseEditForm = TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms.BaseEditForm;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolForms
{
    public partial class SchoolEditForm : BaseEditForm
    {
        public SchoolEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SchoolBll(myDataLayoutControl);
            BaseCardType = CardType.School;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new SchoolSingle() : ((SchoolBll) Bll).Single(FilterFunctions.Filter<School>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((SchoolBll) Bll).GetNewCode();
            txtSchoolName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (SchoolSingle) OldEntity;

            txtCode.Text = entity.Code;
            txtSchoolName.Text = entity.SchoolName;
            txtProvince.Id = entity.ProvinceId;
            txtProvince.Text = entity.ProvinceName;
            txtDistrict.Id = entity.DistrictId;
            txtDistrict.Text = entity.DistrictName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new School
            {
                Id = Id,
                Code = txtCode.Text,
                SchoolName = txtSchoolName.Text,
                ProvinceId = Convert.ToInt64(txtProvince.Id),//"(long) txtIl.Id," şeklinde cast işlemi yaılırsa veri silme işleminde hata verir
                DistrictId = Convert.ToInt64(txtDistrict.Id),
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if(!(sender is ButtonEdit))return;

            using (var select=new SelectFunctions())
            {
                if(sender == txtProvince) select.Select(txtProvince);
                else if(sender==txtDistrict) select.Select(txtDistrict,txtProvince);

            }
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if(sender!=txtProvince) return;
            txtProvince.ControlEnabledChanged(txtDistrict);
        }
    }
}