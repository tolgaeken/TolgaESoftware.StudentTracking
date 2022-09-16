using System;
using System.Collections.Generic;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BillForms
{
    public partial class BillAccrueEditForm : BaseEditForm
    {
        public BillAccrueEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BaseCardType = CardType.Bill;
            EventsLoad();

            HideItems = new BarItem[] { btnNew , btnDelete};
            ShowItems = new BarItem[] { btnPrint };
            txtTaxType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<TaxType>());
            txtBillAddress.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AddressType>());
            CloseFormPostRegistration = false;
        }

        public override void Loads()
        {
            txtTaxType.SelectedItem = TaxType.Included.ToName();
            txtBillAddress.SelectedItem = AddressType.HomeAddress.ToName();
            LoadBillTerm();
            LoadBillBumber();
            LoadTable();
        }

        private void LoadBillTerm()
        {
            using (var bll = new BillBll())
            {
                var list = bll.BillTermList(p =>
                    p.Accrue.BranchId == MainForm.BranchId && p.Accrue.TermId == MainForm.TermId);
                list.ForEach(p=>txtBillTerm.Properties.Items.Add(p.Date.ToString("d")));
            }
        }

        private void LoadBillBumber()
        {
            using (var bll = new BillBll())
            {
                txtLastBillNumber.Value = bll.MaxBillNumber(p =>
                    p.Accrue.BranchId == MainForm.BranchId && p.Accrue.TermId == MainForm.TermId);
                txtBillNumber.Value = txtLastBillNumber.Value + 1;
            }
        }

        protected internal override void ButtonEnabledStatus()
        {
            GeneralFunctions.ButtonEnabledStatus(btnSave,btnUndo,billAccrueTable.TableValueChanged);
        }

        protected override void LoadTable()
        {
            billAccrueTable.OwnerForm = this;
            billAccrueTable.Loads();
        }

        protected override void Print()
        {
            var source = new List<BillReport>();
            for (int i = 0; i < billAccrueTable.Table.DataRowCount; i++)
            {
                var entity = billAccrueTable.Table.GetRow<BillPlanList>(i);
                if (entity== null)return;

                var row = new BillReport
                {
                    SchoolNumber = entity.SchoolNumber,
                    TrIdentityNumber = entity.TrIdentityNumber,
                    Name = entity.Name,
                    Lastname = entity.Lastname,
                    ClassName = entity.ClassName,
                    GuardianshipTrIdentityNumber = entity.GuardianshipTrIdentityNumber,
                    GuardianshipName = entity.GuardianshipName,
                    GuardianshipLastname = entity.GuardianshipLastname,
                    GuardianshipKinshipName = entity.GuardianshipKinshipName,
                    GuardianshipVocationName = entity.GuardianshipVocationName,
                    BillAddress = entity.BillAddress,
                    BillAddressDistrictName = entity.BillAddressDistrictName,
                    BillAddressProvinceName = entity.BillAddressProvinceName,
                    Statement = entity.Statement,
                    BillNumber = entity.BillNumber,
                    Date = entity.AccrueDate,
                    Price = entity.AccruePrice,
                    Discount = entity.AccrueDiscountPrice,
                    NetPrice = entity.AccrueNetPrice,
                    TaxType = entity.TaxType,
                    TaxPercentage = entity.TaxPercentage,
                    TaxExcludedPrice = entity.TaxExcludedPrice,
                    TaxPrice = entity.TaxPrice,
                    SumOfPrice = entity.SumOfPrice,
                    PriceAsText = entity.PriceAsText,
                    Branch = entity.Branch,
                    Term = entity.Term
                };

                source.Add(row);
            }

            ShowListForms<ReportSelection>.ShowDialogListForm(CardType.Report, false ,ReportSectionType.BillTermReports, source);
        }

        protected override bool EntityUpdate()
        {
            if (!billAccrueTable.Save()) return false;

            billAccrueTable.Loads();
            LoadBillBumber();
            return true;
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if(sender!=txtBillTerm) return;

            billAccrueTable.List();
            billAccrueTable.Table.Focus();
        }
    }
}