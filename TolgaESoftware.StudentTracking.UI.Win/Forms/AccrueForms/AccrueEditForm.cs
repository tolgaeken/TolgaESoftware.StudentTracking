using System;
using System.Drawing;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.GeneralForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.AccrueEditFormTable;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.AccrueForms
{
    public partial class AccrueEditForm : BaseEditForm
    {
        private readonly Student _student;
        private BaseTable _siblingInformationsTable;
        private BaseTable _familyInformationsTable;
        private BaseTable _examInformationsTable;
        private BaseTable _documentInformationsTable;
        private BaseTable _promotionInformationsTable;
        private BaseTable _contactInformationsTable;
        private BaseTable _eposInformationsTable;
        private BaseTable _noteInformationsTable;

        public AccrueEditForm()
        {
            InitializeComponent();
            DataLayoutControls = new[] { dataLayoutGeneral, dataLayoutGeneralInformations };
            Bll = new AccrueBll(dataLayoutGeneralInformations);
            BaseCardType = CardType.Accrue;
            EventsLoad();

            HideItems = new BarItem[] { btnNew };
            ShowItems = new BarItem[] { btnPrint };

            txtEnrollmentType.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EnrollmentType>());
            txtEnrollmentStatus.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EnrollmentStatus>());
            txtNextTermEnrollmentStatus.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<NextTermEnrollmentStatus>());

            txtRegistrationDate.Properties.MinValue = MainForm.TermParameters.TermStartDate;
            txtRegistrationDate.Properties.MaxValue = MainForm.TermParameters.TermEndDate;

            btnPrint.Caption = "Kayıt Evrakları";

            CloseFormPostRegistration = false;

        }

        public AccrueEditForm(params object[] prm) : this()
        {
            if (prm[0] is Student student) _student = student;
            else if (prm[0] is bool yesNo) AnotherBranchProcess = yesNo;
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new AccrueSingle() : ((AccrueBll)Bll).Single(FilterFunctions.Filter<Accrue>(Id));
            LinkObjectToControls();
            LoadLinkedTable();

            if (BaseProcessType != ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);

            txtCode.Text = ((AccrueBll)Bll).
                GetNewStudentNumber(p => p.BranchId == MainForm.BranchId && p.TermId == MainForm.TermId);
        }

        protected override void LoadLinkedTable()
        {
            bool TableValueChanged(BaseTable table)
            {
                return table.Table.DataController.ListSource.Cast<IBaseActionEntity>().Any(p => p.Insert || p.Update || p.Delete);
            }

            if (_siblingInformationsTable != null && TableValueChanged(_siblingInformationsTable)) _siblingInformationsTable.Loads();
            if (_familyInformationsTable != null && TableValueChanged(_familyInformationsTable)) _familyInformationsTable.Loads();
            if (_examInformationsTable != null && TableValueChanged(_examInformationsTable)) _examInformationsTable.Loads();
            if (_documentInformationsTable != null && TableValueChanged(_documentInformationsTable)) _documentInformationsTable.Loads();
            if (_promotionInformationsTable != null && TableValueChanged(_promotionInformationsTable)) _promotionInformationsTable.Loads();
            if (_contactInformationsTable != null && TableValueChanged(_contactInformationsTable)) _contactInformationsTable.Loads();
            if (_eposInformationsTable != null && TableValueChanged(_eposInformationsTable)) _eposInformationsTable.Loads();
            if (_noteInformationsTable != null && TableValueChanged(_noteInformationsTable)) _noteInformationsTable.Loads();

            if (serviceInformationsTable.OwnerForm == null)
            {
                serviceInformationsTable.OwnerForm = this;
                serviceInformationsTable.Loads();
            }

            if (discountInformationsTable.OwnerForm == null)
            {
                discountInformationsTable.OwnerForm = this;
                discountInformationsTable.Loads();
            }

            if (paymentInformationsTable.OwnerForm == null)
            {
                paymentInformationsTable.OwnerForm = this;
                paymentInformationsTable.Loads();
                paymentInformationsTable.InsUptNavigator.navigator.TextLocation = NavigatorButtonsTextLocation.Begin;
                paymentInformationsTable.InsUptNavigator.navigator.TextStringFormat = "Taksit ( {0} / {1} )";
                paymentInformationsTable.InsUptNavigator.navigator.Appearance.ForeColor = SystemColors.HotTrack;
            }

            if (refundInformationsTable.OwnerForm == null)
            {
                refundInformationsTable.OwnerForm = this;
                refundInformationsTable.Loads();
            }

            if (TableValueChanged(serviceInformationsTable))
            {
                var rowHandle = serviceInformationsTable.Table.FocusedRowHandle;
                serviceInformationsTable.Loads();
                serviceInformationsTable.Table.FocusedRowHandle = rowHandle;
            }

            if (TableValueChanged(discountInformationsTable))
            {
                var rowHandle = discountInformationsTable.Table.FocusedRowHandle;
                discountInformationsTable.Loads();
                discountInformationsTable.Table.FocusedRowHandle = rowHandle;
            }

            if (TableValueChanged(paymentInformationsTable))
            {
                var rowHandle = paymentInformationsTable.Table.FocusedRowHandle;
                paymentInformationsTable.Loads();
                paymentInformationsTable.Table.FocusedRowHandle = rowHandle;
            }

            if (TableValueChanged(refundInformationsTable))
            {
                var rowHandle = refundInformationsTable.Table.FocusedRowHandle;
                refundInformationsTable.Loads();
                refundInformationsTable.Table.FocusedRowHandle = rowHandle;
            }

            Sums();

        }

        protected override void LinkObjectToControls()
        {
            var entity = (AccrueSingle)OldEntity;

            txtTrIdentityNumber.Text = BaseProcessType == ProcessType.EntityInsert ? _student.TrIdentityNumber : entity.TrIdentityNumber;
            txtName.Text = BaseProcessType == ProcessType.EntityInsert ? _student.Name : entity.Name;
            txtLastname.Text = BaseProcessType == ProcessType.EntityInsert ? _student.Lastname : entity.Lastname;
            txtFatherName.Text = BaseProcessType == ProcessType.EntityInsert ? _student.FatherName : entity.FatherName;
            txtMotherName.Text = BaseProcessType == ProcessType.EntityInsert ? _student.MotherName : entity.MotherName;
            txtStatus.Text = entity.Status ? CancelStatus.Continues.ToName() : CancelStatus.Cancelled.ToName();
            txtCode.Text = entity.Code;
            txtSchoolNumber.Text = entity.SchoolNumber;
            txtRegistrationDate.DateTime = entity.RegistrationDate;
            txtEnrollmentType.SelectedItem = entity.EnrollmentType.ToName();
            txtEnrollmentStatus.SelectedItem = entity.EnrollmentStatus.ToName();
            txtClass.Id = entity.ClassId;
            txtClass.Text = entity.ClassName;
            txtForeignLanguage.Id = entity.ForeignLanguageId;
            txtForeignLanguage.Text = entity.ForeignLanguageName;
            txtComesFromSchool.Id = entity.ComesFromSchoolId;
            txtComesFromSchool.Text = entity.ComesFromSchoolName;
            txtQuota.Id = entity.QuotaId;
            txtQuota.Text = entity.QuotaName;
            txtIncent.Id = entity.IncentId;
            txtIncent.Text = entity.IncentName;
            txtGuide.Id = entity.GuideId;
            txtGuide.Text = entity.GuideName;
            txtNextTermEnrollmentStatus.SelectedItem = entity.NextTermEnrollmentStatus.ToName();
            txtNextTermEnrollmentStatusStatement.Text = entity.NextTermEnrollmentStatusStatement;
            txtSpecialCode1.Id = entity.SpecialCode1Id;
            txtSpecialCode1.Text = entity.SpecialCode1Name;
            txtSpecialCode2.Id = entity.SpecialCode2Id;
            txtSpecialCode2.Text = entity.SpecialCode2Name;
            txtSpecialCode3.Id = entity.SpecialCode3Id;
            txtSpecialCode3.Text = entity.SpecialCode3Name;
            txtSpecialCode4.Id = entity.SpecialCode4Id;
            txtSpecialCode4.Text = entity.SpecialCode4Name;
            txtSpecialCode5.Id = entity.SpecialCode5Id;
            txtSpecialCode5.Text = entity.SpecialCode5Name;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Accrue
            {
                Id = Id,
                Code = txtCode.Text,
                StudentId = BaseProcessType == ProcessType.EntityInsert ? _student.Id : ((AccrueSingle)OldEntity).StudentId,
                SchoolNumber = txtSchoolNumber.Text,
                RegistrationDate = txtRegistrationDate.DateTime.Date,
                EnrollmentType = txtEnrollmentType.Text.GetEnum<EnrollmentType>(),
                EnrollmentStatus = txtEnrollmentStatus.Text.GetEnum<EnrollmentStatus>(),
                ClassId = Convert.ToInt64(txtClass.Id),
                ForeignLanguageId = txtForeignLanguage.Id,
                ComesFromSchoolId = txtComesFromSchool.Id,
                QuotaId = txtQuota.Id,
                IncentId = txtIncent.Id,
                GuideId = txtGuide.Id,
                NextTermEnrollmentStatus = txtNextTermEnrollmentStatus.Text.GetEnum<NextTermEnrollmentStatus>(),
                NextTermEnrollmentStatusStatement = txtNextTermEnrollmentStatusStatement.Text,
                SpecialCode1Id = txtSpecialCode1.Id,
                SpecialCode2Id = txtSpecialCode2.Id,
                SpecialCode3Id = txtSpecialCode3.Id,
                SpecialCode4Id = txtSpecialCode4.Id,
                SpecialCode5Id = txtSpecialCode5.Id,
                Status = txtStatus.Text.GetEnum<CancelStatus>() == CancelStatus.Continues,
                BranchId = MainForm.BranchId,
                TermId = MainForm.TermId,
            };

            ButtonEnabledStatus();
        }

        protected override void Select(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var select = new SelectFunctions())
                if (sender == txtClass) select.Select(txtClass);
                else if (sender == txtForeignLanguage) select.Select(txtForeignLanguage);
                else if (sender == txtComesFromSchool) select.Select(txtComesFromSchool);
                else if (sender == txtQuota) select.Select(txtQuota);
                else if (sender == txtIncent) select.Select(txtIncent);
                else if (sender == txtGuide) select.Select(txtGuide);
                else if (sender == txtSpecialCode1) select.Select(txtSpecialCode1, CardType.Accrue);
                else if (sender == txtSpecialCode2) select.Select(txtSpecialCode2, CardType.Accrue);
                else if (sender == txtSpecialCode3) select.Select(txtSpecialCode3, CardType.Accrue);
                else if (sender == txtSpecialCode4) select.Select(txtSpecialCode4, CardType.Accrue);
                else if (sender == txtSpecialCode5) select.Select(txtSpecialCode5, CardType.Accrue);
        }

        protected override bool EntityInsert()
        {
            if (!StatusControl()) return false;

            if (LinkedTableWrongDataControl()) return false;

            var result = ((AccrueBll)Bll)
                         .Insert(CurrentEntity, p => p.Code == CurrentEntity.Code
                                                     && p.BranchId == MainForm.BranchId
                                                     && p.TermId == MainForm.TermId) && SaveLinkedTable();
            if (result && !CloseFormPostRegistration) LoadLinkedTable();
            return result;
        }

        protected override bool EntityUpdate()
        {
            if (!StatusControl()) return false;

            if (LinkedTableWrongDataControl()) return false;

            var result = ((AccrueBll)Bll)
                .Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code
                                                       && p.BranchId == MainForm.BranchId
                                                       && p.TermId == MainForm.TermId) && SaveLinkedTable();
            if (result && !CloseFormPostRegistration) LoadLinkedTable();
            return result;
        }

        protected override bool LinkedTableWrongDataControl()
        {
            if (_examInformationsTable != null && _examInformationsTable.WrongData())
            {
                tabTop.SelectedPage = pageFamilyExamInformations;
                _examInformationsTable.Table.GridControl.Focus();
                return true;
            }

            if (_contactInformationsTable != null && _contactInformationsTable.WrongData())
            {
                tabTop.SelectedPage = pageContactInformations;
                _contactInformationsTable.Table.GridControl.Focus();
                return true;
            }

            if (_eposInformationsTable != null && _eposInformationsTable.WrongData())
            {
                tabTop.SelectedPage = pageEposInformations;
                _eposInformationsTable.Table.GridControl.Focus();
                return true;
            }

            if (_noteInformationsTable != null && _noteInformationsTable.WrongData())
            {
                tabTop.SelectedPage = pageNotes;
                _noteInformationsTable.Table.GridControl.Focus();
                return true;
            }

            if (serviceInformationsTable.WrongData())
            {
                tabBottom.SelectedPage = pageServiceInformations;
                serviceInformationsTable.Table.GridControl.Focus();
                return true;
            }

            if (discountInformationsTable.WrongData())
            {
                tabBottom.SelectedPage = pageDiscountInformations;
                discountInformationsTable.Table.GridControl.Focus();
                return true;
            }

            if (paymentInformationsTable.WrongData())
            {
                tabBottom.SelectedPage = pagePaymentInformations;
                paymentInformationsTable.Table.GridControl.Focus();
                return true;
            }

            if (refundInformationsTable.WrongData())
            {
                tabBottom.SelectedPage = pageRefundInformations;
                refundInformationsTable.Table.GridControl.Focus();
                return true;
            }

            return false;
        }

        protected internal override void ButtonEnabledStatus()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (_siblingInformationsTable != null && _siblingInformationsTable.TableValueChanged) return true;
                if (_familyInformationsTable != null && _familyInformationsTable.TableValueChanged) return true;
                if (_examInformationsTable != null && _examInformationsTable.TableValueChanged) return true;
                if (_documentInformationsTable != null && _documentInformationsTable.TableValueChanged) return true;
                if (_promotionInformationsTable != null && _promotionInformationsTable.TableValueChanged) return true;
                if (_contactInformationsTable != null && _contactInformationsTable.TableValueChanged) return true;
                if (_eposInformationsTable != null && _eposInformationsTable.TableValueChanged) return true;
                if (_noteInformationsTable != null && _noteInformationsTable.TableValueChanged) return true;
                if (serviceInformationsTable.TableValueChanged) return true;
                if (discountInformationsTable.TableValueChanged) return true;
                if (paymentInformationsTable.TableValueChanged) return true;
                if (refundInformationsTable.TableValueChanged) return true;

                return false;
            }

            if (serviceInformationsTable.TableValueChanged || discountInformationsTable.TableValueChanged
                                                          || paymentInformationsTable.TableValueChanged
                                                          || refundInformationsTable.TableValueChanged) Sums();

            if (AnotherBranchProcess) Functions.GeneralFunctions.ButtonEnabledStatus(btnNew, btnSave, btnUndo, btnDelete);
            else Functions.GeneralFunctions.ButtonEnabledStatus(btnNew, btnSave, btnUndo, btnDelete, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override bool SaveLinkedTable()
        {
            if (_siblingInformationsTable != null && !_siblingInformationsTable.Save()) return false;
            if (_familyInformationsTable != null && !_familyInformationsTable.Save()) return false;
            if (_examInformationsTable != null && !_examInformationsTable.Save()) return false;
            if (_documentInformationsTable != null && !_documentInformationsTable.Save()) return false;
            if (_promotionInformationsTable != null && !_promotionInformationsTable.Save()) return false;
            if (_contactInformationsTable != null && !_contactInformationsTable.Save()) return false;
            if (_eposInformationsTable != null && !_eposInformationsTable.Save()) return false;
            if (_noteInformationsTable != null && !_noteInformationsTable.Save()) return false;
            if (_noteInformationsTable != null && !_noteInformationsTable.Save()) return false;
            if (!serviceInformationsTable.Save()) return false;
            if (!discountInformationsTable.Save()) return false;
            if (!paymentInformationsTable.Save()) return false;
            if (!refundInformationsTable.Save()) return false;

            return true;
        }

        private void Sums()
        {
            var sumOfServiceInformations = serviceInformationsTable.Table.DataController.ListSource
                .Cast<ServiceInformationsList>().Where(p => !p.Delete)
                .Sum(p => p.GrossPrice - p.ShortTermDeductedPrice);

            var sumOfDiscountInformations = discountInformationsTable.Table.DataController.ListSource
                .Cast<DiscountInformationsList>().Where(p => !p.Delete)
                .Sum(p => p.GrossDiscount - p.ShortTermDeductedDiscount);

            var sumOfPaymentInformations = paymentInformationsTable.Table.DataController.ListSource
                .Cast<PaymentInformationsList>().Where(p => !p.Delete)
                .Sum(p => p.Price);

            var sumOfReturnInformations = paymentInformationsTable.Table.DataController.ListSource
                .Cast<PaymentInformationsList>().Where(p => !p.Delete)
                .Sum(p => p.Refund);

            var sumOfRefundInformations = refundInformationsTable.Table.DataController.ListSource
                .Cast<RefundInformationsList>().Where(p => !p.Delete)
                .Sum(p => p.Price);


            txtSumOfServiceInformations.Value = sumOfServiceInformations;
            txtSumOfDiscountInformations.Value = sumOfDiscountInformations;
            txtSumOfPaymentInformations.Value = sumOfPaymentInformations;
            txtSumOfReturnInformations.Value = sumOfReturnInformations;
            txtSumOfRefundInformations.Value = sumOfRefundInformations;
            txtDifference.Value = sumOfServiceInformations - sumOfDiscountInformations -
                                  (sumOfPaymentInformations - (sumOfReturnInformations + sumOfRefundInformations));

            txtDifference.Properties.Appearance.BackColor =
                txtDifference.Value != 0 ? Color.IndianRed : Color.GreenYellow;
        }

        private bool StatusControl()
        {
            if (txtDifference.Value != 0)
            {
                Messages.ErrorMessage("Ücret Toplamları Farkı Sıfır ( 0 ) Olmalıdır");
                return false;
            }

            var source = serviceInformationsTable.Table.DataController.ListSource.Cast<ServiceInformationsList>();

            if (!source.Any(p => !p.Delete && !p.Cancelled && p.ServiceTypeEnum == ServiceTypeEnum.Education))
            {
                Messages.WarningMessage("Eğitim Hizmeti Alınmadığı İçin Tahakkuk Pasif Duruma Alınacaktır");
                txtStatus.Text = CancelStatus.Cancelled.ToName();
            }
            else txtStatus.Text = CancelStatus.Continues.ToName();

            return true;

        }

        protected override void Print()
        {
            if (pageContactInformations.Controls.Count == 0)
            {
                _contactInformationsTable = new ContactInformationsTable().AddTable(this);
                pageContactInformations.Controls.Add(_contactInformationsTable);
                _contactInformationsTable.Loads();
            }

            if (pageEposInformations.Controls.Count == 0)
            {
                _eposInformationsTable = new EposInformationsTable().AddTable(this);
                pageEposInformations.Controls.Add(_eposInformationsTable);
                _eposInformationsTable.Loads();
            }

            var studentIndormations = ((AccrueBll)Bll).SingleDetail(p => p.Id == Id);

            var contactInformations = _contactInformationsTable.Table.DataController.ListSource.Cast<IBaseEntity>()
                .EntityListConvert<ContactInformationsReport>();

            var serviceInformations = serviceInformationsTable.Table.DataController.ListSource.Cast<IBaseEntity>()
                .EntityListConvert<ServiceInformationsReport>();

            var discountInformations = discountInformationsTable.Table.DataController.ListSource.Cast<IBaseEntity>()
                .EntityListConvert<DiscountInformationsReport>();

            var paymentInformations = paymentInformationsTable.Table.DataController.ListSource.Cast<IBaseEntity>()
                .EntityListConvert<PaymentInformationsReport>();

            var refundInformations = refundInformationsTable.Table.DataController.ListSource.Cast<IBaseEntity>()
                .EntityListConvert<RefundInformationsReport>();

            var eposInformations = _eposInformationsTable.Table.DataController.ListSource.Cast<IBaseEntity>()
                .EntityListConvert<EposInformationsReport>();

            ShowListForms<ReportSelection>.ShowDialogListForm(CardType.Report, false,ReportSectionType.AccrueReports, studentIndormations,
                contactInformations, serviceInformations, discountInformations, paymentInformations, refundInformations,eposInformations);
        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGeneralInformations)
            {
                txtSchoolNumber.Focus();
                txtSchoolNumber.SelectAll();
            }

            else if (e.Page == pageSiblingInformations)
            {
                if (pageSiblingInformations.Controls.Count == 0)
                {
                    _siblingInformationsTable = new SiblingInformationsTable().AddTable(this);
                    pageSiblingInformations.Controls.Add(_siblingInformationsTable);
                    _siblingInformationsTable.Loads();
                }

                _siblingInformationsTable.Table.GridControl.Focus();
            }

            else if (e.Page == pageFamilyExamInformations)
            {
                if (layoutControlFamilyExamInformations.Items.Count == 0)
                {
                    _familyInformationsTable = new FamilyInformationsTable().AddTable(this);
                    layoutControlFamilyExamInformations.LayoutControlInsert(_familyInformationsTable, 0, 0, 0, 0);
                    _familyInformationsTable.Loads();

                    _examInformationsTable = new ExamInformationsTable().AddTable(this);
                    layoutControlFamilyExamInformations.LayoutControlInsert(_examInformationsTable, 1, 0, 0, 0);
                    _examInformationsTable.Loads();
                }

                _familyInformationsTable.Table.GridControl.Focus();
            }

            else if (e.Page == pageDocumentPromotionInformations)
            {
                if (layoutControlDocumentPromotionInformations.Items.Count == 0)
                {
                    _documentInformationsTable = new DocumentInformationsTable().AddTable(this);
                    layoutControlDocumentPromotionInformations.LayoutControlInsert(_documentInformationsTable, 0, 0, 0, 0);
                    _documentInformationsTable.Loads();

                    _promotionInformationsTable = new PromotionInformationsTable().AddTable(this);
                    layoutControlDocumentPromotionInformations.LayoutControlInsert(_promotionInformationsTable, 1, 0, 0, 0);
                    _promotionInformationsTable.Loads();
                }

                _documentInformationsTable.Table.GridControl.Focus();
            }

            else if (e.Page == pageContactInformations)
            {
                if (pageContactInformations.Controls.Count == 0)
                {
                    _contactInformationsTable = new ContactInformationsTable().AddTable(this);
                    pageContactInformations.Controls.Add(_contactInformationsTable);
                    _contactInformationsTable.Loads();
                }

                _contactInformationsTable.Table.GridControl.Focus();
            }

            else if (e.Page == pageEposInformations)
            {
                if (pageEposInformations.Controls.Count == 0)
                {
                    _eposInformationsTable = new EposInformationsTable().AddTable(this);
                    pageEposInformations.Controls.Add(_eposInformationsTable);
                    _eposInformationsTable.Loads();
                }

                _eposInformationsTable.Table.GridControl.Focus();
            }

            else if (e.Page == pageNotes)
            {
                if (pageNotes.Controls.Count == 0)
                {
                    _noteInformationsTable = new NoteInformationsTable().AddTable(this);
                    pageNotes.Controls.Add(_noteInformationsTable);
                    _noteInformationsTable.Loads();
                }

                _noteInformationsTable.Table.GridControl.Focus();
            }

            else if (e.Page == pageServiceInformations) serviceInformationsTable.Table.GridControl.Focus();

            else if (e.Page == pageDiscountInformations) discountInformationsTable.Table.GridControl.Focus();

            else if (e.Page == pagePaymentInformations) paymentInformationsTable.Table.GridControl.Focus();

            else if (e.Page == pageRefundInformations) refundInformationsTable.Table.GridControl.Focus();
        }
    }
}