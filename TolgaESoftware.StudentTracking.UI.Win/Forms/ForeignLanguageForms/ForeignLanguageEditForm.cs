using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ForeignLanguageForms
{
    public partial class ForeignLanguageEditForm : BaseEditForm
    {
        public ForeignLanguageEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ForeignLanguageBll();
            BaseCardType = CardType.ForeignLanguage;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? 
                new ForeignLanguage() : 
                ((ForeignLanguageBll) Bll).Single(FilterFunctions.Filter<ForeignLanguage>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((ForeignLanguageBll) Bll).GetNewCode();
            txtForeignLanguageName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (ForeignLanguage) OldEntity;

            txtCode.Text = entity.Code;
            txtForeignLanguageName.Text = entity.ForeignLanguageName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new ForeignLanguage
            {
                Id = Id,
                Code = txtCode.Text,
                ForeignLanguageName = txtForeignLanguageName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}