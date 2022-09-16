using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BranchForms
{
    public partial class BranchEditForm : BaseEditForm
    {
        public BranchEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BranchBll(myDataLayoutControl);
            BaseCardType = CardType.Branch;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new BranchSingle() : ((BranchBll) Bll).Single(FilterFunctions.Filter<Branch>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((BranchBll) Bll).GetNewCode();
            txtBranchName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (BranchSingle) OldEntity;

            txtCode.Text = entity.Code;
            txtBranchName.Text = entity.BranchName;
            txtGroupName.Text = entity.GroupName;
            txtRowNumber.EditValue = entity.RowNumber;
            txtIbanNumber.Text = entity.IbanNumber;
            txtPhone.Text = entity.Phone;
            txtFax.Text = entity.Fax;
            txtAddress.Text = entity.Address;
            txtAddressProvince.Id = entity.AddressProvinceId;
            txtAddressProvince.Text = entity.AddressProvinceName;
            txtAddressDistrict.Id = entity.AddressDistrictId;
            txtAddressDistrict.Text = entity.AddressDistrictName;
            pictLogo.EditValue = entity.Logo;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Branch
            {
                Id = Id,
                Code = txtCode.Text,
                BranchName = txtBranchName.Text,
                GroupName = txtGroupName.Text,
                RowNumber = (int) txtRowNumber.Value,
                IbanNumber = txtIbanNumber.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text,
                Address = txtAddress.Text,
                AddressProvinceId = Convert.ToInt64(txtAddressProvince.Id),
                AddressDistrictId = Convert.ToInt64(txtAddressDistrict.Id),
                Logo = (byte[]) pictLogo.EditValue,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if(!(sender is ButtonEdit))return;

            using (var select=new SelectFunctions())
            {
                if(sender == txtAddressProvince) select.Select(txtAddressProvince);
                else if(sender==txtAddressDistrict) select.Select(txtAddressDistrict,txtAddressProvince);

            }
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if(sender!=txtAddressProvince) return;
            txtAddressProvince.ControlEnabledChanged(txtAddressDistrict);
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit image)) return;
            image.Select(imageMenu);
        }
    }
}