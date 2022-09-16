using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.DocumentForms
{
    public partial class DocumentEditForm : BaseEditForm
    {
        public DocumentEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new DocumentBll(myDataLayoutControl);
            BaseCardType = CardType.Document;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Document() : ((DocumentBll) Bll).Single(FilterFunctions.Filter<Document>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((DocumentBll) Bll).GetNewCode(p=> p.BranchId==MainForm.BranchId && p.TermId==MainForm.TermId);
            txtDocumentName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Document) OldEntity;

            txtCode.Text = entity.Code;
            txtDocumentName.Text = entity.DocumentName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Document
            {
                Id = Id,
                Code = txtCode.Text,
                DocumentName = txtDocumentName.Text,
                Statement = txtStatement.Text,
                BranchId = MainForm.BranchId,
                TermId = MainForm.TermId,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            return ((DocumentBll) Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code 
                                            && p.BranchId==MainForm.BranchId 
                                            && p.TermId==MainForm.TermId);
        }

        protected override bool EntityUpdate()
        {
            return ((DocumentBll) Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code 
                                                       && p.BranchId == MainForm.BranchId 
                                                       && p.TermId == MainForm.TermId);
        }
    }
}