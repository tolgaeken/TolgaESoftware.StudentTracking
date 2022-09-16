using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.StudentForms
{
    public partial class StudentEditForm : BaseEditForm
    {
        public StudentEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new StudentBll(myDataLayoutControl);
            txtGender.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Gender>());
            txtBloodGroup.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BloodGroups>());
            BaseCardType = CardType.Student;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new StudentSingle() : ((StudentBll)Bll).Single(FilterFunctions.Filter<Student>(Id));
            LinkObjectToControls();
            LoadTable();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((StudentBll)Bll).GetNewCode();
            txtTrIdentityNumber.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (StudentSingle) OldEntity;

            txtCode.Text = entity.Code;
            txtTrIdentityNumber.Text = entity.TrIdentityNumber;
            txtName.Text = entity.Name;
            txtLastname.Text = entity.Lastname;
            txtPhone.Text = entity.Phone;
            txtFatherName.Text = entity.FatherName;
            txtMotherName.Text = entity.MotherName;
            txtGender.SelectedItem = entity.Gender.ToName();
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
            imgImage.EditValue = entity.Image;
            txtSpecialCode1.Id = entity.SpecialCode1Id;
            txtSpecialCode1.Text = entity.SpecialCode1Name;
            txtSpecialCode2.Id = entity.SpecialCode2Id;
            txtSpecialCode2.Text = entity.SpecialCode2Name;
            txtSpecialCode3.Id = entity.SpecialCode3Id;
            txtSpecialCode3.Text = entity.SpecialCode3Name;
            txtSpecialCode4.Id = entity.SpecialCode4Id;
            txtSpecialCode4.Text = entity.SpecialCode4Name;
            txtSpecialCode5.Id = entity.SpecialCode5Id;
            txtSpecialCode5.Text = entity.SpecialCode5Name;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Student
            {
                Id = Id,
                Code = txtCode.Text,
                TrIdentityNumber = txtTrIdentityNumber.Text,
                Name = txtName.Text,
                Lastname = txtLastname.Text,
                Gender = txtGender.Text.GetEnum<Gender>(),
                Phone = txtPhone.Text,
                FatherName = txtFatherName.Text,
                MotherName = txtMotherName.Text,
                BirthPlace = txtBirthPlace.Text,
                BirthDate = (DateTime?)txtBirthDate.EditValue,
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
                IdentityGivenDate = (DateTime?)txtIdentityGivenDate.EditValue,
                Image = (byte[])imgImage.EditValue,
                SpecialCode1Id = txtSpecialCode1.Id,
                SpecialCode2Id = txtSpecialCode2.Id,
                SpecialCode3Id = txtSpecialCode3.Id,
                SpecialCode4Id = txtSpecialCode4.Id,
                SpecialCode5Id = txtSpecialCode5.Id,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn,
            };

            ButtonEnabledStatus();
        }

        protected override void LoadTable()
        {
            accrueInformationsTable.OwnerForm = this;
            accrueInformationsTable.Loads();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtIdentityProvince) select.Select(txtIdentityProvince);
                else if (sender == txtIdentityDistrict) select.Select(txtIdentityDistrict, txtIdentityProvince);
                else if (sender == txtSpecialCode1) select.Select(txtSpecialCode1, CardType.Student);
                else if (sender == txtSpecialCode2) select.Select(txtSpecialCode2, CardType.Student);
                else if (sender == txtSpecialCode3) select.Select(txtSpecialCode3, CardType.Student);
                else if (sender == txtSpecialCode4) select.Select(txtSpecialCode4, CardType.Student);
                else if (sender == txtSpecialCode5) select.Select(txtSpecialCode5, CardType.Student);
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if (sender != txtIdentityProvince) return;
            txtIdentityProvince.ControlEnabledChanged(txtIdentityDistrict);
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit image)) return;
            image.Select(imageMenu);
        }
    }
}