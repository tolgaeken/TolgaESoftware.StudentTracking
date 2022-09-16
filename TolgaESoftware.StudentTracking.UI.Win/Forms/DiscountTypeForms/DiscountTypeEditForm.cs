using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.DiscountTypeForms
{
    public partial class DiscountTypeEditForm : BaseEditForm
    {
        public DiscountTypeEditForm()
        {
            InitializeComponent();
       
            DataLayoutControl = myDataLayoutControl;
            Bll = new DiscountTypeBll(myDataLayoutControl);
            BaseCardType = CardType.DiscountType;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new DiscountType() : ((DiscountTypeBll) Bll).Single(FilterFunctions.Filter<DiscountType>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((DiscountTypeBll) Bll).GetNewCode();
            txtDiscountTypeName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (DiscountType) OldEntity;

            txtCode.Text = entity.Code;
            txtDiscountTypeName.Text = entity.DiscountTypeName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new DiscountType
            {
                Id = Id,
                Code = txtCode.Text,
                DiscountTypeName = txtDiscountTypeName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}