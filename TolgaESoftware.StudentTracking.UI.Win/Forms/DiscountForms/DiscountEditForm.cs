using System;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.DiscountForms
{
    public partial class DiscountEditForm : BaseEditForm
    {
        public DiscountEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new DiscountBll(myDataLayoutControl);
            BaseCardType = CardType.Discount;
            EventsLoad();
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new DiscountSingle() : ((DiscountBll)Bll).Single(FilterFunctions.Filter<Discount>(Id));
            LinkObjectToControls();
            LoadTable();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((DiscountBll)Bll).
                GetNewCode(p => p.BranchId == MainForm.BranchId && p.TermId == MainForm.TermId);
            txtDiscountName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (DiscountSingle)OldEntity;

            txtCode.Text = entity.Code;
            txtDiscountName.Text = entity.DiscountName;
            txtDiscountType.Id = entity.DiscountTypeId;
            txtDiscountType.Text = entity.DiscountTypeName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Discount
            {
                Id = Id,
                Code = txtCode.Text,
                DiscountTypeId = Convert.ToInt64(txtDiscountType.Id),
                DiscountName = txtDiscountName.Text,
                Statement = txtStatement.Text,
                BranchId = MainForm.BranchId,
                TermId = MainForm.TermId,
                Status = tglStatus.IsOn

            };

            ButtonEnabledStatus();
        }

        protected internal override void ButtonEnabledStatus()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledStatus
                (btnNew, btnSave, btnUndo, btnDelete, OldEntity, CurrentEntity, servicesTable.TableValueChanged);
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtDiscountType) select.Select(txtDiscountType);
        }


        protected override bool EntityInsert()
        {
            if (servicesTable.WrongData()) return false;

            return ((DiscountBll)Bll)
                .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code
                                            && p.BranchId == MainForm.BranchId
                                            && p.TermId == MainForm.TermId)
                                            && servicesTable.Save();
        }

        protected override bool EntityUpdate()
        {
            if (servicesTable.WrongData()) return false;

            return ((DiscountBll)Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code
                                                       && p.BranchId == MainForm.BranchId
                                                       && p.TermId == MainForm.TermId)
                                                       && servicesTable.Save();
        }

        protected override void LoadTable()
        {
            servicesTable.OwnerForm = this;
            servicesTable.Loads();
        }
    }
}