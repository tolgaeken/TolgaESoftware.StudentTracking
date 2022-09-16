using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BillForms
{
    public partial class BillPlanListForm : BaseListForm
    {
        public BillPlanListForm()
        {
            InitializeComponent();
            Bll = new AccrueBll();

            HideItems = new BarItem[] { btnNew, barInsert, barInsertStatement, barDelete, barDeleteStatement, btnActivePassiveCards };
            ShowItems = new BarItem[] { btnAccrue };
            btnDelete.Caption = "Fatura Planı İptal Et";
            btnAccrue.Caption = "Toplu Fatura Planı";
            btnPrint.CreateDropDownMenu(new BarItem[] { btnPrintTable });
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Bill;
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((AccrueBll)Bll).BillAccrueList(p => p.BranchId == MainForm.BranchId && p.TermId == MainForm.TermId);
        }

        protected override void ShowEditForm(long id)
        {
            var entity = table.GetRow<BillList>();
            if (entity == null) return;

            if (entity.ServiceNetPrice == 0)
            {
                Messages.ErrorMessage("Öğrencinin Net Ücreti Sıfır ( 0 ) Olduğu İçin Fatura Planı Oluşturulamaz.");
                return;
            }

            var result = ShowEditForms<BillPlanEditForm>.ShowDialogEditForm(CardType.Bill, id, null);

            ShowEditFormDefault(result);
        }

        protected override void Accrue()
        {
            var source = new List<BillList>();

            for (int i = 0; i < table.DataRowCount; i++)
                source.Add(table.GetRow<BillList>(i));

            if (source.Count == 0) return;

            if (ShowEditForms<MassBillPlanEditForm>.ShowDialogEditForm(CardType.Bill, source))
                List();
        }

        protected override void Print()
        {
            var source = new List<BillReport>();

            using (var bll = new BillBll())
            {
                for (int i = 0; i < table.DataRowCount; i++)
                {
                    var entity = table.GetRow<BillList>(i);
                    if (entity == null) return;

                    var list = bll.BillAccrueList(p => p.AccrueId == entity.Id).Cast<BillPlanList>();
                    list.ForEach(p =>
                    {
                        var row = new BillReport
                        {
                            AccrueId = p.AccrueId,
                            SchoolNumber = p.SchoolNumber,
                            TrIdentityNumber = p.TrIdentityNumber,
                            Name = p.Name,
                            Lastname = p.Lastname,
                            ClassName = p.ClassName,
                            GuardianshipTrIdentityNumber = p.GuardianshipTrIdentityNumber,
                            GuardianshipName = p.GuardianshipName,
                            GuardianshipLastname = p.GuardianshipLastname,
                            GuardianshipKinshipName = p.GuardianshipKinshipName,
                            GuardianshipVocationName = p.GuardianshipVocationName,
                            BillAddress = p.BillAddress,
                            BillAddressDistrictName = p.BillAddressDistrictName,
                            BillAddressProvinceName = p.BillAddressProvinceName,
                            Statement = p.Statement,
                            BillNumber = p.BillNumber,
                            Date = p.AccrueDate,
                            Price = p.AccruePrice,
                            Discount = p.AccrueDiscountPrice,
                            NetPrice = p.AccrueNetPrice,
                            TaxType = p.TaxType,
                            TaxPercentage = p.TaxPercentage,
                            TaxExcludedPrice = p.TaxExcludedPrice,
                            TaxPrice = p.TaxPrice,
                            SumOfPrice = p.SumOfPrice,
                            PriceAsText = p.PriceAsText,
                            PlanPrice = entity.PlanPrice,
                            PlanDiscount = entity.PlanDiscount,
                            PlanNetPrice = entity.PlanNetPrice,
                            Branch = p.Branch,
                            Term = p.Term
                        };

                        source.Add(row);
                    });
                }
            }
            ShowListForms<ReportSelection>.ShowDialogListForm(CardType.Report, false, ReportSectionType.BillGeneralReports, source);
        }

        protected override void EntityDelete()
        {
            if (Messages.NoSelectedYesNo(
                "Seçilen Öğrencilere Ait Hareket Görmeyen Tüm Fatura Planları İptal Edilecektir.\nOnaylıyor musunuz?",
                "İptal Onay") != DialogResult.Yes) return;

            var source = new List<BillList>();
            for (int i = 0; i < table.DataRowCount; i++)
                source.Add(table.GetRow<BillList>(i));

            if (source.Count == 0) return;

            using (var bll = new BillBll())
            {
                var position = 0.0;
                progressBarControl.Visible = true;
                progressBarControl.Left = (ClientSize.Width - progressBarControl.Width) / 2;
                progressBarControl.Top = (ClientSize.Height - progressBarControl.Height) / 2;

                source.ForEach(p =>
                {
                    var percent = 100.0 / source.Count;
                    position += percent;

                    var planSource = bll.List(c => c.AccrueId == p.Id)
                        .Where(c => ((BillPlanList)c).AccrueDate == null).ToList();

                    bll.Delete(planSource);

                    progressBarControl.Position = (int)position;
                    progressBarControl.Update();
                });
            }

            progressBarControl.Visible = false;
            Messages.InformationMessage("Seçilen Öğrencilere Ait Fatura Planları Başarılı Bir Şekilde İptal Edilmiştir.");
            List();
        }
    }
}