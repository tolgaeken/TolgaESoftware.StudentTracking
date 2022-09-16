using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolBusForms
{
    public partial class SchoolBusEditForm : BaseEditForm
    {
        public SchoolBusEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new SchoolBusBll(myDataLayoutControl);
            BaseCardType = CardType.SchoolBus;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new SchoolBus() : ((SchoolBusBll)Bll).Single(FilterFunctions.Filter<SchoolBus>(Id));
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((SchoolBusBll)Bll).GetNewCode(p => p.BranchId == MainForm.BranchId && p.TermId == MainForm.TermId);
            txtSchoolBusName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (SchoolBus)OldEntity;

            txtCode.Text = entity.Code;
            txtSchoolBusName.Text = entity.SchoolBusName;
            txtPrice.Value = entity.Price;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new SchoolBus
            {
                Id = Id,
                Code = txtCode.Text,
                SchoolBusName = txtSchoolBusName.Text,
                Price = txtPrice.Value,
                Statement = txtStatement.Text,
                BranchId = MainForm.BranchId,
                TermId = MainForm.TermId,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            return ((SchoolBusBll)Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code
                                            && p.BranchId == MainForm.BranchId
                                            && p.TermId == MainForm.TermId);
        }

        protected override bool EntityUpdate()
        {
            return ((SchoolBusBll)Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code
                                                       && p.BranchId == MainForm.BranchId
                                                       && p.TermId == MainForm.TermId);
        }
    }
}