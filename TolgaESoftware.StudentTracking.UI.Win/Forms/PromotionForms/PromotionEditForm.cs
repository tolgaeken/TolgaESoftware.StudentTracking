using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.PromotionForms
{
    public partial class PromotionEditForm : BaseEditForm
    {
        public PromotionEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new PromotionBll(myDataLayoutControl);
            BaseCardType = CardType.Promotion;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Promotion() : ((PromotionBll) Bll).Single(FilterFunctions.Filter<Promotion>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((PromotionBll) Bll).GetNewCode(p=> p.BranchId==MainForm.BranchId && p.TermId==MainForm.TermId);
            txtPromotionName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Promotion) OldEntity;

            txtCode.Text = entity.Code;
            txtPromotionName.Text = entity.PromotionName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Promotion
            {
                Id = Id,
                Code = txtCode.Text,
                PromotionName = txtPromotionName.Text,
                Statement = txtStatement.Text,
                BranchId = MainForm.BranchId,
                TermId = MainForm.TermId,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            return ((PromotionBll) Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code 
                                            && p.BranchId==MainForm.BranchId 
                                            && p.TermId==MainForm.TermId);
        }

        protected override bool EntityUpdate()
        {
            return ((PromotionBll) Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code 
                                                       && p.BranchId == MainForm.BranchId 
                                                       && p.TermId == MainForm.TermId);
        }
    }
}