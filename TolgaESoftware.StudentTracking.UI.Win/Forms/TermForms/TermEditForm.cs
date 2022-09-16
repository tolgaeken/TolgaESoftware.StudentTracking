using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.TermForms
{
    public partial class TermEditForm : BaseEditForm
    {
        public TermEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new TermBll(myDataLayoutControl);
            BaseCardType = CardType.Term;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Term() : ((TermBll)Bll).Single(FilterFunctions.Filter<Term>(Id));
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((TermBll)Bll).GetNewCode();
            txtTermName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Term)OldEntity;

            txtCode.Text = entity.Code;
            txtTermName.Text = entity.TermName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Term
            {
                Id = Id,
                Code = txtCode.Text,
                TermName = txtTermName.Text,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}