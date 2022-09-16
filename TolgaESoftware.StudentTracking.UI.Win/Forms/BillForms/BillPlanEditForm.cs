using System;
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
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.BillEditFormTable;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BillForms
{
    public partial class BillPlanEditForm : BaseEditForm
    {
        public BillPlanEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BaseCardType = CardType.Bill;
            EventsLoad();

            HideItems = new BarItem[] { btnNew };
            btnDelete.Caption = "İptal Et";
        }

        public override void Loads()
        {
            LoadTable();

            using (var bll = new ServiceInformationsBll())
            {
                var list = bll.BillPlanList(p => p.AccrueId == Id).ToList();

                txtStudentNumber.Text = list[0].SchoolNumber;
                txtName.Text = list[0].Name;
                txtLastname.Text = list[0].Lastname;
                txtClass.Text = list[0].ClassName;
                txtGuardianshipName.Text = list[0].GuardianshipName;
                txtGuardianshipLastname.Text = list[0].GuardianshipLastname;
                txtKinship.Text = list[0].GuardianshipKinshipName;
                txtVocation.Text = list[0].GuardianshipVocationName;

                table.GridControl.DataSource = list;
                //Id = list[0].AccrueId;
            }
        }

        protected internal override void ButtonEnabledStatus()
        {
            GeneralFunctions.ButtonEnabledStatus(btnSave, btnUndo, billPlanTable.TableValueChanged);
        }

        protected override void LoadTable()
        {
            billPlanTable.OwnerForm = this;
            billPlanTable.Loads();
        }

        protected override bool EntityInsert()
        {
            return billPlanTable.Save();
        }

        protected override bool EntityUpdate()
        {
            return billPlanTable.Save();
        }

        protected override void EntityDelete()
        {
            if (Messages.NoSelectedYesNo("Fatura Planı İptal Edilecek\nOnaylıyor musunuz?", "İptal Onay") != DialogResult.Yes) return;

            var source = billPlanTable.Table.DataController.ListSource.Cast<BillPlanList>()
                .Where(p => p.AccrueDate == null).ToList();

            if(source.Count==0) return;

            source.ForEach(p=>p.Delete=true);

            billPlanTable.Table.RefreshDataSource();
            billPlanTable.TableValueChanged = true;
            ButtonEnabledStatus();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            billPlanTable.Table.Focus();
        }
    }
}
