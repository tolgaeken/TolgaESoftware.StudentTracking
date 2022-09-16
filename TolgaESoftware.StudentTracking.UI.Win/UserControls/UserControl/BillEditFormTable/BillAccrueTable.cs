using System;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BillForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.BillEditFormTable
{
    public partial class BillAccrueTable : BaseTable
    {
        public BillAccrueTable()
        {
            InitializeComponent();

            Bll = new BillBll();
            Table = table;
            EventsLoad();

            btnAddAction.Caption = "Tahakkuk Yap";
            btnDeleteActon.Caption = "Tahakkuk İptal Et";
            InsUptNavigator.navigator.Buttons.Append.Hint = "Tahakkuk Yap";
            InsUptNavigator.navigator.Buttons.Remove.Hint = "Tahakkuk İptal Et";
        }

        protected internal override void List()
        {
            var selectedItem = ((BillAccrueEditForm)OwnerForm).txtBillTerm.SelectedItem;

            if (selectedItem == null) return;

            var date = DateTime.Parse(selectedItem.ToString());
            table.GridControl.DataSource = ((BillBll)Bll)
                .BillAccrueList(p => p.Accrue.BranchId == MainForm.BranchId &&
                                     p.Accrue.TermId == MainForm.TermId &&
                                     p.PlanDate == date).ToBindingList<BillPlanList>();
        }

        protected override void AddAction()
        {
            if (table.DataRowCount == 0)
            {
                Messages.ErrorMessage("Fatura Tahakkuku Yapılacak Öğrenci Bulunamadı.\nFatura Dönemi Seçilmemiş Olabilir.");
                return;
            }

            if (Messages.NoSelectedYesNo(
                "Seçilen Öğrencilere Yukarıda Girilen Bilgilere Göre Fatura Tahakkuku Yapılacaktır.\nOnaylıyor musunuz?",
                "Tahakkuk Onay") != DialogResult.Yes) return;

            var billNumber = (int)((BillAccrueEditForm)OwnerForm).txtBillNumber.Value;

            var taxType = ((BillAccrueEditForm)OwnerForm).txtTaxType.Text.GetEnum<TaxType>();

            var taxPercentage = (byte)((BillAccrueEditForm)OwnerForm).txtTaxPercentage.Value;

            var addressType = ((BillAccrueEditForm)OwnerForm).txtBillAddress.Text.GetEnum<AddressType>();

            decimal CalculateTax(decimal price)
            {
                return taxType == TaxType.Included
                    ? Math.Round(price * taxPercentage / (100 + taxPercentage), 2)
                    : Math.Round(price * taxPercentage / 100, 2);
            }

            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<BillPlanList>(i);

                if (entity == null) return;

                entity.BillNumber = billNumber + i;
                entity.AccrueDate = entity.PlanDate;
                entity.AccruePrice = entity.PlanPrice;
                entity.AccrueDiscountPrice = entity.PlanDiscountPrice;
                entity.AccrueNetPrice = entity.PlanNetPrice;
                entity.TaxPercentage = taxPercentage;
                entity.TaxPrice = CalculateTax(entity.AccrueNetPrice.Value);
                entity.TaxExcludedPrice = taxType == TaxType.Excluded
                    ? entity.AccrueNetPrice
                    : entity.AccrueNetPrice - entity.TaxPrice;
                entity.SumOfPrice = entity.TaxExcludedPrice + entity.TaxPrice;
                entity.PriceAsText = entity.AccrueNetPrice.Value.PriceAsText();
                entity.TaxType = taxType;

                entity.BillAddress = addressType == AddressType.HomeAddress
                    ? entity.GuardianshipHomeAddress
                    : entity.GuardianshipWorkplaceAddress;

                entity.BillAddressDistrictId = addressType == AddressType.HomeAddress
                    ? entity.GuardianshipHomeAddressDistrictId
                    : entity.GuardianshipWorkplaceAddressDistrictId;

                entity.BillAddressDistrictName = addressType == AddressType.HomeAddress
                    ? entity.GuardianshipHomeAddressDistrictName
                    : entity.GuardianshipWorkplaceAddressDistrictName;

                entity.BillAddressProvinceId = addressType == AddressType.HomeAddress
                    ? entity.GuardianshipHomeAddressProvinceId
                    : entity.GuardianshipWorkplaceAddressProvinceId;

                entity.BillAddressProvinceName = addressType == AddressType.HomeAddress
                    ? entity.GuardianshipHomeAddressProvinceName
                    : entity.GuardianshipWorkplaceAddressProvinceName;

                entity.Update = true;
            }

            table.RefreshData();

            ButtonEnabledStatus(true);
        }

        protected override void DeleteAction()
        {
            if (Messages.NoSelectedYesNo(
                "Seçilen Öğrencilere Yapılan Fatura Tahakkukları İptal Edilecektir.\nOnaylıyor musunuz?",
                "İptal Onay") != DialogResult.Yes) return;

            for (int i = 0; i < table.DataRowCount; i++)
            {
                var entity = table.GetRow<BillPlanList>(i);

                if (entity == null) return;

                entity.BillNumber = null;
                entity.AccrueDate = null;
                entity.AccruePrice = null;
                entity.AccrueDiscountPrice = null;
                entity.AccrueNetPrice = null;
                entity.TaxPercentage = null;
                entity.TaxPrice = null;
                entity.TaxExcludedPrice = null;
                entity.SumOfPrice = null;
                entity.PriceAsText = null;
                entity.TaxType = null;
                entity.BillAddress = null;
                entity.BillAddressDistrictId = null;
                entity.BillAddressDistrictName = null;
                entity.BillAddressProvinceId = null;
                entity.BillAddressProvinceName = null;
                entity.Update = true;
            }

            table.RefreshData();

            ButtonEnabledStatus(true);
        }
    }
}
