using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ClassGroupForms
{
    public partial class ClassGroupEditForm : BaseEditForm
    {
        public ClassGroupEditForm()
        {
            InitializeComponent();
       
            DataLayoutControl = myDataLayoutControl;
            Bll = new ClassGroupBll(myDataLayoutControl);
            BaseCardType = CardType.ClassGroup;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new ClassGroup() : ((ClassGroupBll) Bll).Single(FilterFunctions.Filter<ClassGroup>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((ClassGroupBll) Bll).GetNewCode();
            txtGroupName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (ClassGroup) OldEntity;

            txtCode.Text = entity.Code;
            txtGroupName.Text = entity.GroupName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new ClassGroup
            {
                Id = Id,
                Code = txtCode.Text,
                GroupName = txtGroupName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}