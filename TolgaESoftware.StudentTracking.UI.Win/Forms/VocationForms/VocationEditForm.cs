using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.VocationForms
{
    public partial class VocationEditForm : BaseEditForm
    {
        public VocationEditForm()
        {
            InitializeComponent();
      
            DataLayoutControl = myDataLayoutControl;
            Bll = new VocationBll(myDataLayoutControl);
            BaseCardType = CardType.Vocation;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Vocation() : ((VocationBll) Bll).Single(FilterFunctions.Filter<Vocation>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((VocationBll) Bll).GetNewCode();
            txtVocationName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Vocation) OldEntity;

            txtCode.Text = entity.Code;
            txtVocationName.Text = entity.VocationName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Vocation
            {
                Id = Id,
                Code = txtCode.Text,
                VocationName = txtVocationName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}