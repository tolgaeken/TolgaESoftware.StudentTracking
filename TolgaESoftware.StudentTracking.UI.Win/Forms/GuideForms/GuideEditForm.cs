using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.GuideForms
{
    public partial class GuideEditForm : BaseEditForm
    {
        public GuideEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new GuideBll(myDataLayoutControl);
            BaseCardType = CardType.Guide;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Guide() : ((GuideBll) Bll).Single(FilterFunctions.Filter<Guide>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((GuideBll) Bll).GetNewCode();
            txtGuideNameLastname.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Guide) OldEntity;

            txtCode.Text = entity.Code;
            txtGuideNameLastname.Text = entity.GuideNameLastname;
            txtPhone1.Text = entity.Phone1;
            txtPhone2.Text = entity.Phone2;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Guide
            {
                Id = Id,
                Code = txtCode.Text,
                GuideNameLastname = txtGuideNameLastname.Text,
                Phone1 = txtPhone1.Text,
                Phone2 = txtPhone2.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}