using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.SpecialCodeForms
{
    public partial class SpecialCodeEditForm : BaseEditForm
    {

        #region Variables
        private readonly SpecialCodeType _specialCodeType;
        private readonly CardType _specialCodeCardType; 
        #endregion

        public SpecialCodeEditForm(params object[] prm)
        {
            InitializeComponent();

            _specialCodeType = (SpecialCodeType) prm[0];
            _specialCodeCardType = (CardType) prm[1];

            DataLayoutControl = myDataLayoutControl;
            Bll = new SpecialCodeBll(myDataLayoutControl);
            BaseCardType = CardType.SpecialCode;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new SpecialCode() : ((SpecialCodeBll) Bll).Single(FilterFunctions.Filter<SpecialCode>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((SpecialCodeBll) Bll).GetNewCode(p=>p.SpecialCodeType==_specialCodeType && p.SpecialCodeCardType == _specialCodeCardType);
            txtSpecialCodeName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (SpecialCode) OldEntity;

            txtCode.Text = entity.Code;
            txtSpecialCodeName.Text = entity.SpecialCodeName;
            txtStatement.Text = entity.Statement;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new SpecialCode
            {
                Id = Id,
                Code = txtCode.Text,
                SpecialCodeName = txtSpecialCodeName.Text,
                SpecialCodeType = _specialCodeType,
                SpecialCodeCardType = _specialCodeCardType,
                Statement = txtStatement.Text,
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            return ((SpecialCodeBll) Bll).Insert(CurrentEntity, p => p.Code == CurrentEntity.Code 
                                                                  && p.SpecialCodeType==_specialCodeType 
                                                                  && p.SpecialCodeCardType==_specialCodeCardType);
        }

        protected override bool EntityUpdate()
        {
            return ((SpecialCodeBll) Bll).Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code 
                                                                             && p.SpecialCodeType==_specialCodeType 
                                                                             && p.SpecialCodeCardType==_specialCodeCardType);
        }
    }
}