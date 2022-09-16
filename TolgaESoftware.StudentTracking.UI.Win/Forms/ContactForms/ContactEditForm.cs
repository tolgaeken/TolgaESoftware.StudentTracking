using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ContactForms
{
    public partial class ContactEditForm : BaseEditForm
    {
        public ContactEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ContactBll(myDataLayoutControl);
            txtBloodGroup.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BloodGroups>());
            BaseCardType = CardType.Contact;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new ContactSingle() : ((ContactBll) Bll).Single(FilterFunctions.Filter<Contact>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((ContactBll) Bll).GetNewCode();
            txtTrIdentityNumber.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (ContactSingle) OldEntity;

            txtCode.Text = entity.Code;
            txtTrIdentityNumber.Text = entity.TrIdentityNumber;
            txtName.Text = entity.Name;
            txtLastname.Text = entity.Lastname;
            txtHomePhone.Text = entity.HomePhone;
            txtWorkplacePhone1.Text = entity.WorkplacePhone1;
            txtWorkplacePhone2.Text = entity.WorkplacePhone2;
            txtInternalPhone1.Text = entity.InternalPhone1;
            txtInternalPhone2.Text = entity.InternalPhone2;
            txtMobilePhone1.Text = entity.MobilePhone1;
            txtMobilePhone2.Text = entity.MobilePhone2;
            txtWeb.Text = entity.Web;
            txtEMail.Text = entity.EMail;
            txtIbanNumber.Text = entity.IbanNumber;
            txtCardNumber.Text = entity.CardNumber;
            txtHomeAddress.Text = entity.HomeAddress;
            txtHomeAddressProvince.Id = entity.HomeAddressProvinceId;
            txtHomeAddressProvince.Text = entity.HomeAddressProvinceName;
            txtHomeAddressDistrict.Id = entity.HomeAddressDistrictId;
            txtHomeAddressDistrict.Text = entity.HomeAddressDistrictName;
            txtWorkplaceAddress2.Text = entity.WorkplaceAddress;
            txtWorkplaceAddressProvince.Id = entity.WorkplaceAddressProvinceId;
            txtWorkplaceAddressProvince.Text = entity.WorkplaceAddressProvinceName;
            txtWorkplaceAddressDistrict.Id = entity.WorkplaceAddressDistrictId;
            txtWorkplaceAddressDistrict.Text = entity.WorkplaceAddressDistrictName;
            txtVocation.Id = entity.VocationId;
            txtVocation.Text = entity.VocationName;
            txtWorkplace.Id = entity.WorkplaceId;
            txtWorkplace.Text = entity.WorkplaceName;
            txtJob.Id = entity.JobId;
            txtJob.Text = entity.JobName;
            txtFatherName.Text = entity.FatherName;
            txtMotherName.Text = entity.MotherName;
            txtBirthPlace.Text = entity.BirthPlace;
            txtBirthDate.EditValue = entity.BirthDate;
            txtBloodGroup.SelectedItem = entity.BloodGroups.ToName();
            txtIdentitySerialNumber.Text = entity.IdentitySerialNumber;
            txtIdentityRowNumber.Text = entity.IdentityRowNumber;
            txtIdentityProvince.Id = entity.IdentityProvinceId;
            txtIdentityProvince.Text = entity.IdentityProvinceName;
            txtIdentityDistrict.Id = entity.IdentityDistrictId;
            txtIdentityDistrict.Text = entity.IdentityDistrictName;
            txtIdentityNeighborhood.Text = entity.IdentityNeighborhood;
            txtIndentityBindingNumber.Text = entity.IdentityBindingNumber;
            txtIdentityFamilyRowNumber.Text = entity.IdentityFamilyRowNumber;
            txtIdentityPersonRowNumber.Text = entity.IdentityPersonRowNumber;
            txtIdentityGivenPlace.Text = entity.IdentityGivenPlace;
            txtIdentityGivenReason.Text = entity.IdentityGivenReason;
            txtIdentityRegisterNumber.Text = entity.IdentityRegisterNumber;
            txtIdentityGivenDate.EditValue = entity.IdentityGivenDate;
            txtSpecialCode1.Id = entity.SpecialCode1Id;
            txtSpecialCode1.Text = entity.SpecialCode1Name;
            txtSpecialCode2.Id = entity.SpecialCode2Id;
            txtSpecialCode2.Text = entity.SpecialCode2Name;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Contact
            {
                Id = Id,
                Code = txtCode.Text,
                TrIdentityNumber = txtTrIdentityNumber.Text,
                Name = txtName.Text,
                Lastname = txtLastname.Text,
                HomePhone = txtHomePhone.Text,
                WorkplacePhone1 = txtWorkplacePhone1.Text,
                WorkplacePhone2 = txtWorkplacePhone2.Text,
                InternalPhone1 = txtInternalPhone1.Text,
                InternalPhone2 = txtInternalPhone2.Text,
                MobilePhone1 = txtMobilePhone1.Text,
                MobilePhone2 = txtMobilePhone2.Text,
                Web = txtWeb.Text,
                EMail = txtEMail.Text,
                IbanNumber = txtIbanNumber.Text,
                CardNumber = txtCardNumber.Text,
                HomeAddress = txtHomeAddress.Text,
                HomeAddressProvinceId = txtHomeAddressProvince.Id,
                HomeAddressDistrictId = txtHomeAddressDistrict.Id,
                WorkplaceAddress = txtWorkplaceAddress2.Text,
                WorkplaceAddressProvinceId = txtWorkplaceAddressProvince.Id,
                WorkplaceAddressDistrictId = txtWorkplaceAddressDistrict.Id,
                VocationId = txtVocation.Id,
                WorkplaceId = txtWorkplace.Id,
                JobId = txtJob.Id,
                FatherName = txtFatherName.Text,
                MotherName = txtMotherName.Text,
                BirthPlace = txtBirthPlace.Text,
                BirthDate = (DateTime?) txtBirthDate.EditValue,
                BloodGroups = txtBloodGroup.Text.GetEnum<BloodGroups>(),
                IdentitySerialNumber = txtIdentitySerialNumber.Text,
                IdentityRowNumber = txtIdentityRowNumber.Text,
                IdentityProvinceId = txtIdentityProvince.Id,
                IdentityDistrictId = txtIdentityDistrict.Id,
                IdentityNeighborhood = txtIdentityNeighborhood.Text,
                IdentityBindingNumber = txtIndentityBindingNumber.Text,
                IdentityFamilyRowNumber = txtIdentityFamilyRowNumber.Text,
                IdentityPersonRowNumber = txtIdentityPersonRowNumber.Text,
                IdentityGivenPlace = txtIdentityGivenPlace.Text,
                IdentityGivenReason = txtIdentityGivenReason.Text,
                IdentityRegisterNumber = txtIdentityRegisterNumber.Text,
                IdentityGivenDate = (DateTime?) txtIdentityGivenDate.EditValue,
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
                if(sender == txtHomeAddressProvince) select.Select(txtHomeAddressProvince);
                else if(sender == txtHomeAddressDistrict) select.Select(txtHomeAddressDistrict,txtHomeAddressProvince);
                else if(sender == txtWorkplaceAddressProvince) select.Select(txtWorkplaceAddressProvince);
                else if(sender == txtWorkplaceAddressDistrict) select.Select(txtWorkplaceAddressDistrict,txtWorkplaceAddressProvince);
                else if(sender == txtVocation) select.Select(txtVocation);
                else if(sender == txtWorkplace) select.Select(txtWorkplace);
                else if(sender == txtJob) select.Select(txtJob);
                else if(sender == txtIdentityProvince) select.Select(txtIdentityProvince);
                else if(sender == txtIdentityDistrict) select.Select(txtIdentityDistrict,txtIdentityProvince);
                else if(sender == txtSpecialCode1) select.Select(txtSpecialCode1,CardType.Contact);
                else if(sender == txtSpecialCode2) select.Select(txtSpecialCode2,CardType.Contact);
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if(sender != txtHomeAddressProvince && sender!=txtWorkplaceAddressProvince && sender != txtIdentityProvince) return;

            if (sender==txtHomeAddressProvince) txtHomeAddressProvince.ControlEnabledChanged(txtHomeAddressDistrict);
            else if(sender==txtWorkplaceAddressProvince) txtWorkplaceAddressProvince.ControlEnabledChanged(txtWorkplaceAddressDistrict);
            else if(sender==txtIdentityProvince) txtIdentityProvince.ControlEnabledChanged(txtIdentityDistrict);
        }
    }
}