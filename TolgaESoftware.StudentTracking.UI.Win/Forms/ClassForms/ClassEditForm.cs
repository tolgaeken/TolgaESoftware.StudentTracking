using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ClassForms
{
    public partial class ClassEditForm : BaseEditForm
    {
        public ClassEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ClassBll(myDataLayoutControl);
            BaseCardType = CardType.Class;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new ClassSingle() : ((ClassBll)Bll).Single(FilterFunctions.Filter<Class>(Id));
            LinkObjectToControls();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((ClassBll)Bll).GetNewCode(p => p.BranchId == MainForm.BranchId);
            txtClassName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (ClassSingle)OldEntity;

            txtCode.Text = entity.Code;
            txtClassName.Text = entity.ClassName;
            txtClassGroup.Id = entity.ClassGroupId;
            txtClassGroup.Text = entity.GroupName;
            txtTargetNumberOfStudents.Value = entity.TargetNumberOfStudents;
            txtTargetProfit.Value = entity.TargetProfit;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Class
            {
                Id = Id,
                Code = txtCode.Text,
                ClassName = txtClassName.Text,
                ClassGroupId = Convert.ToInt64(txtClassGroup.Id),//"(long) txtClassGroup.Id," şeklinde cast işlemi yaılırsa veri silme işleminde hata verir
                TargetNumberOfStudents = (int)txtTargetNumberOfStudents.Value,
                TargetProfit = txtTargetProfit.Value,
                Statement = txtStatement.Text,
                BranchId = MainForm.BranchId,
                Status = tglStatus.IsOn

            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtClassGroup) select.Select(txtClassGroup);
        }

        protected override bool EntityInsert()
        {
            return ((ClassBll)Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code
                                            && p.BranchId == MainForm.BranchId);
        }

        protected override bool EntityUpdate()
        {
            return ((ClassBll)Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code
                                                       && p.BranchId == MainForm.BranchId);
        }
    }
}