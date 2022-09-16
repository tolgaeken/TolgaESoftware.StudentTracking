using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class InstitutionInformationsEditForm : BaseEditForm
    {
        #region Variables
        private readonly string _code;
        private readonly string _institutionName;
        #endregion

        public InstitutionInformationsEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new InstitutionInformationsBll(myDataLayoutControl);
            BaseCardType = CardType.InstitutionInformations;
            HideItems = new BarItem[] { btnNew, btnDelete };
            EventsLoad();

            _code = prm[0].ToString();
            _institutionName = prm[1].ToString();
        }

        public override void Loads()
        {
            OldEntity = ((InstitutionInformationsBll)Bll).Single(null) ?? new InstitutionInformationsSingle();
            BaseProcessType = OldEntity.Id == 0 ? ProcessType.EntityInsert : ProcessType.EntityUpdate;
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = _code;
            txtInstitutionName.Text = _institutionName;
            txtInstitutionName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (InstitutionInformationsSingle)OldEntity;

            Id = entity.Id;
            txtCode.Text = entity.Code;
            txtInstitutionName.Text = entity.InstitutionName;
            txtTaxAdministration.Text = entity.TaxAdministration;
            txtTaxNumber.Text = entity.TaxNumber;
            txtProvince.Id = entity.ProvinceId;
            txtProvince.Text = entity.ProvinceName;
            txtDistrict.Id = entity.DistrictId;
            txtDistrict.Text = entity.DistrictName;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new InstitutionInformations()
            {
                Id = Id,
                Code = txtCode.Text,
                InstitutionName = txtInstitutionName.Text,
                TaxAdministration = txtTaxAdministration.Text,
                TaxNumber = txtTaxNumber.Text,
                ProvinceId = Convert.ToInt64(txtProvince.Id),
                DistrictId = Convert.ToInt64(txtDistrict.Id)
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