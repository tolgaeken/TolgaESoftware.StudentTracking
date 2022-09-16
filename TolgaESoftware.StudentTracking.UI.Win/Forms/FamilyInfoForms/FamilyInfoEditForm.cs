using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.FamilyInfoForms
{
    public partial class FamilyInfoEditForm : BaseEditForm
    {
        public FamilyInfoEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new FamilyInfoBll(myDataLayoutControl);
            BaseCardType = CardType.FamilyInfo;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new FamilyInfo() : ((FamilyInfoBll) Bll).Single(FilterFunctions.Filter<FamilyInfo>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((FamilyInfoBll) Bll).GetNewCode();
            txtFamilyInfoName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (FamilyInfo) OldEntity;

            txtCode.Text = entity.Code;
            txtFamilyInfoName.Text = entity.FamilyInfoName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new FamilyInfo
            {
                Id = Id,
                Code = txtCode.Text,
                FamilyInfoName = txtFamilyInfoName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}