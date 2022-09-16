using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.KinshipForms
{
    public partial class KinshipEditForm : BaseEditForm
    {
        public KinshipEditForm()
        {
            InitializeComponent();
          
            DataLayoutControl = myDataLayoutControl;
            Bll = new KinshipBll(myDataLayoutControl);
            BaseCardType = CardType.Kinship;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Kinship() : ((KinshipBll) Bll).Single(FilterFunctions.Filter<Kinship>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((KinshipBll) Bll).GetNewCode();
            txtKinshipName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Kinship) OldEntity;

            txtCode.Text = entity.Code;
            txtKinshipName.Text = entity.KinshipName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Kinship
            {
                Id = Id,
                Code = txtCode.Text,
                KinshipName = txtKinshipName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}