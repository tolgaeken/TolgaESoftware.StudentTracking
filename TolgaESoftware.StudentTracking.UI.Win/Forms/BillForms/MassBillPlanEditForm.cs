using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraLayout.Utils;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BillForms
{
    public partial class MassBillPlanEditForm : BaseEditForm
    {
        private readonly IList<BillTakenServicesList> _takenServicesSource;
        private readonly IList _billPlanSource;
        private readonly IList<BillList> _billPlanCards;


        public MassBillPlanEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            EventsLoad();

            HideItems = new BarItem[] { btnNew, btnSave, btnSaveAs, btnUndo, btnDelete, btnApply };
            ShowItems = new BarItem[] { btnCreateInstallment };
            txtSummaryAccrue.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YesNo>());
            txtMonthInfo.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YesNo>());
        }

        public MassBillPlanEditForm(params object[] prm) : this()
        {
            if (prm.Length == 1) _billPlanCards = (IList<BillList>)prm[0];

            else
            {
                _takenServicesSource = (IList<BillTakenServicesList>)prm[0];
                _billPlanSource = (IList)prm[1];
            }

        }

        public override void Loads()
        {
            btnCreateInstallment.Caption = "Plan\nOluştur";
            txtFirstBillDate.DateTime = DateTime.Now.Date;
            txtFixPrice.Value = 0;
            txtSummaryAccrue.SelectedItem = YesNo.No.ToName();
            txtMonthInfo.SelectedItem = YesNo.No.ToName();

            if (_billPlanCards != null)
            {
                MinimumSize = new Size(520,280);
                Size = new Size(520,280);
            }
                

            else
            {
                layoutControlProgress.Visibility = LayoutVisibility.Never;
                layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.RemoveAt(4);
                layoutControlGroup.Update();
                MaximumSize = new Size(520,250);
                Size = new Size(520,250);
            }
        }

        private static string TakenServices(IList<string> servicesSource)
        {
            var takenServices = "";

            for (int i = 0; i < servicesSource.Count; i++)
            {
                takenServices += servicesSource[i];
                if (i + 1 < servicesSource.Count) takenServices += " , ";
            }
            return takenServices;
        }

        protected override void CreateInstallment()
        {
            if (_billPlanCards != null)
            {
                MassBillPlan();
                return;
            }

            var accrueId = _takenServicesSource.Select(p => p.AccrueId).First();
            var takenServices = _takenServicesSource.Select(p => p.ServiceName).ToList();
            var sumOfServices = _takenServicesSource.Sum(p => p.GrossPrice);
            var sumOfDiscounts = _takenServicesSource.Sum(p => p.Discount);

            var firstBillDate = txtFirstBillDate.DateTime.Date;
            var numberOfBill = (int)txtQuantity.Value;
            var fixPrice = txtFixPrice.Value;
            var summaryAccrue = txtSummaryAccrue.Text.GetEnum<YesNo>();
            var summaryAccrueStatement = txtSummaryAccrueStatement.Text;

            var sumOfEnteredGrossPrice = _billPlanSource.Cast<BillPlanList>().Where(p => !p.Delete).Sum(p => p.PlanPrice);
            var sumOfEnteredDiscountPrice = _billPlanSource.Cast<BillPlanList>().Where(p => !p.Delete).Sum(p => p.PlanDiscountPrice);

            var grossPriceToBeEnter = fixPrice > 0 ? fixPrice :
                Math.Round((sumOfServices - sumOfEnteredGrossPrice) / numberOfBill, MainForm.TermParameters.UseBillAccruePenny ? 2 : 0);

            var discountPriceToBeEnter = fixPrice > 0 ? 0 :
                Math.Round((sumOfDiscounts - sumOfEnteredDiscountPrice) / numberOfBill, MainForm.TermParameters.UseBillAccruePenny ? 2 : 0);

            var netPriceToBeEnter = grossPriceToBeEnter - discountPriceToBeEnter;

            if (grossPriceToBeEnter <= 0)
            {
                Messages.WarningMessage("Verilen Hizmetler Toplamı Kadar Fatura Planı Zaten Oluşturulmuştur");
                return;
            }

            for (int i = 0; i < numberOfBill; i++)
            {
                var row = new BillPlanList
                {
                    AccrueId = accrueId,
                    Statement = summaryAccrue == YesNo.Yes ? summaryAccrueStatement : TakenServices(takenServices) + " Bedeli",
                    PlanDate = firstBillDate.AddMonths(i),
                    PlanPrice = grossPriceToBeEnter,
                    PlanDiscountPrice = discountPriceToBeEnter,
                    PlanNetPrice = netPriceToBeEnter,
                    Insert = true
                };

                if (txtSummaryAccrue.Text.GetEnum<YesNo>() == YesNo.Yes) row.Statement = summaryAccrueStatement;

                if (txtMonthInfo.Text.GetEnum<YesNo>() == YesNo.Yes)
                {
                    var month = (Months)row.PlanDate.Month;
                    row.Statement = month.ToName() + " - " + row.PlanDate.Year + " Ayı " + row.Statement;
                }

                if (i + 1 == numberOfBill && fixPrice == 0)
                {
                    row.PlanPrice = sumOfServices - _billPlanSource.Cast<BillPlanList>().Where(p => !p.Delete).Sum(p => p.PlanPrice);
                    row.PlanDiscountPrice = sumOfDiscounts - _billPlanSource.Cast<BillPlanList>().Where(p => !p.Delete).Sum(p => p.PlanDiscountPrice);
                    row.PlanNetPrice = row.PlanPrice - row.PlanDiscountPrice;
                }

                _billPlanSource.Add(row);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void MassBillPlan()
        {
            if(Messages.NoSelectedYesNo("Toplu Fatura Planı Oluşturulacaktır.\nOnaylıyor musunuz?","Onay")!=DialogResult.Yes) return;

            var firstBillDate = txtFirstBillDate.DateTime.Date;
            var numberOfBill = (int)txtQuantity.Value;
            var fixPrice = txtFixPrice.Value;
            var summaryAccrue = txtSummaryAccrue.Text.GetEnum<YesNo>();
            var summaryAccrueStatement = txtSummaryAccrueStatement.Text;
            var position = 0.0;

            using (var billBll = new BillBll())
            {
                using (var serviceInformationsBll = new ServiceInformationsBll())
                {
                    _billPlanCards.ForEach(p =>
                    {
                        var percent = 100.0 / _billPlanCards.Count;
                        position += percent;

                        var servicePrice = p.ServicePrice;
                        var serviceDiscount = p.ServiceDiscount;
                        var planPrice = p.PlanPrice;
                        var planDiscount = p.PlanDiscount;
                        var takenServices = TakenServices(serviceInformationsBll.BillPlanList(c => c.AccrueId == p.Id)
                            .Select(c => c.ServiceName).ToList());

                        var grossPriceToBeEnter = fixPrice > 0 ? fixPrice :
                            Math.Round((servicePrice - planPrice) / numberOfBill, MainForm.TermParameters.UseBillAccruePenny ? 2 : 0);

                        var discountPriceToBeEnter = fixPrice > 0 ? 0 :
                            Math.Round((serviceDiscount - planDiscount) / numberOfBill, MainForm.TermParameters.UseBillAccruePenny ? 2 : 0);

                        var netPriceToBeEnter = grossPriceToBeEnter - discountPriceToBeEnter;

                        if (servicePrice == 0 || servicePrice == planPrice && serviceDiscount == planDiscount)
                        {
                            progressBarControl.Position = 100;
                            return;
                        }

                        for (int i = 0; i < numberOfBill; i++)
                        {
                            var row = new BillPlanList
                            {
                                AccrueId = p.Id,
                                Statement = summaryAccrue == YesNo.Yes ? summaryAccrueStatement : takenServices + " Bedeli",
                                PlanDate = firstBillDate.AddMonths(i),
                                PlanPrice = grossPriceToBeEnter,
                                PlanDiscountPrice = discountPriceToBeEnter,
                                PlanNetPrice = netPriceToBeEnter,
                                Insert = true
                            };

                            if (txtSummaryAccrue.Text.GetEnum<YesNo>() == YesNo.Yes) row.Statement = summaryAccrueStatement;

                            if (txtMonthInfo.Text.GetEnum<YesNo>() == YesNo.Yes)
                            {
                                var month = (Months)row.PlanDate.Month;
                                row.Statement = month.ToName() + " - " + row.PlanDate.Year + " Ayı " + row.Statement;
                            }

                            if (i + 1 == numberOfBill && fixPrice == 0)
                            {
                                row.PlanPrice = (servicePrice - planPrice) - (grossPriceToBeEnter * i);
                                row.PlanDiscountPrice = (serviceDiscount - planDiscount) - (discountPriceToBeEnter * i);
                                row.PlanNetPrice = row.PlanPrice - row.PlanDiscountPrice;
                            }

                            if (!billBll.InsertSingle(row)) return;
                            progressBarControl.Position = (int) position;
                            progressBarControl.Update();
                        }
                    });
                }
            }

            Messages.InformationMessage("Fatura Planı Oluşturma İşlemi Başarılı Bir Şekilde Tamamlanmıştır.");
            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtSummaryAccrue) return;

            txtSummaryAccrueStatement.Enabled = txtSummaryAccrue.Text.GetEnum<YesNo>() == YesNo.Yes;
            txtSummaryAccrueStatement.Focus();
        }
    }
}