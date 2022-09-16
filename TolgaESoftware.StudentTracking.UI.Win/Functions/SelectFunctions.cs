using System;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankAccountForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankBranchForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BranchForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ClassForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ClassGroupForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.CustomerForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DiscountTypeForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DistrictForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ForeignLanguageForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.GuideForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.IncentForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.JobForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.LawyerForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.PaymentMethodForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ProvinceForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.QuotaForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ServiceTypeForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.SpecialCodeForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.VaultForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.VocationForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.WorkplaceForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;

namespace TolgaESoftware.StudentTracking.UI.Win.Functions
{
    public class SelectFunctions : IDisposable
    {
        #region Variables
        private MyButtonEdit _btnEdit;
        private MyButtonEdit _prmEdit;
        private CardType _cardType;
        private PaymentType _paymentType;
        private BankAccountType _accountType;
        #endregion

        public void Select(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            Choose();
        }

        public void Select(MyButtonEdit btnEdit, PaymentType paymentType)
        {
            _btnEdit = btnEdit;
            _paymentType = paymentType;
            Choose();
        }
        public void Select(MyButtonEdit btnEdit, CardType cardType, BankAccountType accountType)
        {
            _btnEdit = btnEdit;
            _cardType = cardType;
            _accountType = accountType;
            Choose();
        }

        public void Select(MyButtonEdit btnEdit, CardType cardType)
        {
            _btnEdit = btnEdit;
            _cardType = cardType;
            Choose();
        }

        public void Select(MyButtonEdit btnEdit, MyButtonEdit prmEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            Choose();
        }

        private void Choose()
        {
            switch (_btnEdit.Name)
            {
                case "txtProvince":
                case "txtAddressProvince":
                case "txtHomeAddressProvince":
                case "txtWorkplaceAddressProvince":
                case "txtIdentityProvince":
                    {
                        var entity = (Province)ShowListForms<ProvinceListForm>.ShowDialogListForm(CardType.Province, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.ProvinceName;
                        }
                    }
                    break;

                case "txtDistrict":
                case "txtAddressDistrict":
                case "txtHomeAddressDistrict":
                case "txtWorkplaceAddressDistrict":
                case "txtIdentityDistrict":
                    {
                        var entity = (District)ShowListForms<DistrictListForm>.ShowDialogListForm(CardType.District, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.DistrictName;
                        }
                    }
                    break;

                case "txtClassGroup":
                    {
                        var entity = (ClassGroup)ShowListForms<ClassGroupListForm>.ShowDialogListForm(CardType.ClassGroup, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GroupName;
                        }
                    }
                    break;

                case "txtServiceType":
                    {
                        var entity = (ServiceType)ShowListForms<ServiceTypeListForm>.ShowDialogListForm(CardType.ServiceType, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.ServiceTypeName;
                        }
                    }
                    break;

                case "txtSpecialCode1":
                    {
                        var entity = (SpecialCode)ShowListForms<SpecialCodeListForm>
                            .ShowDialogListForm(CardType.SpecialCode, _btnEdit.Id, SpecialCodeType.SpecialCode1, _cardType);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SpecialCodeName;
                        }
                    }
                    break;

                case "txtSpecialCode2":
                    {
                        var entity = (SpecialCode)ShowListForms<SpecialCodeListForm>
                            .ShowDialogListForm(CardType.SpecialCode, _btnEdit.Id, SpecialCodeType.SpecialCode2, _cardType);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SpecialCodeName;
                        }
                    }
                    break;

                case "txtSpecialCode3":
                    {
                        var entity = (SpecialCode)ShowListForms<SpecialCodeListForm>
                            .ShowDialogListForm(CardType.SpecialCode, _btnEdit.Id, SpecialCodeType.SpecialCode3, _cardType);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SpecialCodeName;
                        }
                    }
                    break;

                case "txtSpecialCode4":
                    {
                        var entity = (SpecialCode)ShowListForms<SpecialCodeListForm>
                            .ShowDialogListForm(CardType.SpecialCode, _btnEdit.Id, SpecialCodeType.SpecialCode4, _cardType);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SpecialCodeName;
                        }
                    }
                    break;

                case "txtSpecialCode5":
                    {
                        var entity = (SpecialCode)ShowListForms<SpecialCodeListForm>
                            .ShowDialogListForm(CardType.SpecialCode, _btnEdit.Id, SpecialCodeType.SpecialCode5, _cardType);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SpecialCodeName;
                        }
                    }
                    break;

                case "txtBankName":
                    {
                        var entity = (BankList)ShowListForms<BankListForm>.ShowDialogListForm(CardType.Bank, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BankName;
                        }
                    }
                    break;

                case "txtBankBranchName":
                    {
                        var entity = (BankBranch)ShowListForms<BankBranchListForm>.ShowDialogListForm(CardType.BankBranch, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BankBranchName;
                        }
                    }
                    break;

                case "txtVocation":
                    {
                        var entity = (Vocation)ShowListForms<VocationListForm>.ShowDialogListForm(CardType.Vocation, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.VocationName;
                        }
                    }
                    break;

                case "txtWorkplace":
                    {
                        var entity = (Workplace)ShowListForms<WorkplaceListForm>.ShowDialogListForm(CardType.Workplace, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.WorkplaceName;
                        }
                    }
                    break;

                case "txtJob":
                    {
                        var entity = (Job)ShowListForms<JobListForm>.ShowDialogListForm(CardType.Job, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.JobName;
                        }
                    }
                    break;

                case "txtDiscountType":
                    {
                        var entity = (DiscountType)ShowListForms<DiscountTypeListForm>.ShowDialogListForm(CardType.DiscountType, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.DiscountTypeName;
                        }
                    }
                    break;

                case "txtClass":
                    {
                        var entity = (ClassList)ShowListForms<ClassListForm>.ShowDialogListForm(CardType.Class, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.ClassName;
                        }
                    }
                    break;

                case "txtForeignLanguage":
                    {
                        var entity = (ForeignLanguage)ShowListForms<ForeignLanguageListForm>.ShowDialogListForm(CardType.ForeignLanguage, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.ForeignLanguageName;
                        }
                    }
                    break;

                case "txtComesFromSchool":
                    {
                        var entity = (SchoolList)ShowListForms<SchoolListForm>.ShowDialogListForm(CardType.School, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SchoolName;
                        }
                    }
                    break;


                case "txtQuota":
                    {
                        var entity = (Quota)ShowListForms<QuotaListForm>.ShowDialogListForm(CardType.Quota, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.QuotaName;
                        }
                    }
                    break;


                case "txtIncent":
                    {
                        var entity = (Incent)ShowListForms<IncentListForm>.ShowDialogListForm(CardType.Incent, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IncentName;
                        }
                    }
                    break;


                case "txtGuide":
                    {
                        var entity = (Guide)ShowListForms<GuideListForm>.ShowDialogListForm(CardType.Guide, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GuideNameLastname;
                        }
                    }
                    break;

                case "txtBankAccount":
                case "txtDefaultBankAccount":
                    {
                        var entity = (BankAccountList)ShowListForms<BankAccountListForm>.ShowDialogListForm(CardType.BankAccount, _btnEdit.Id, _paymentType);
                        if (entity != null)
                        {
                            _btnEdit.Tag = entity.BlockedDay;
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BankAccountName;
                        }
                    }
                    break;

                case "txtPaymentMethod":
                    {
                        var entity = (PaymentMethod)ShowListForms<PaymentMethodListForm>.ShowDialogListForm(CardType.PaymentMethod, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Tag = entity.PaymentType;
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.PaymentMethodName;
                        }
                    }
                    break;

                case "txtDefaultLawyerAccount":
                    {
                        var entity = (LawyerList)ShowListForms<LawyerListForm>.ShowDialogListForm(CardType.Lawyer, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.NameLastname;
                        }
                    }
                    break;

                case "txtDefaultVaultAccount":
                    {
                        var entity = (VaultList)ShowListForms<VaultListForm>.ShowDialogListForm(CardType.Vault, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.VaultName;
                        }
                    }
                    break;

                case "txtBranch":
                    {
                        var entity = (BranchList)ShowListForms<BranchListForm>.ShowDialogListForm(CardType.Branch, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BranchName;
                        }
                    }
                    break;

                case "txtRole":
                    {
                        var entity = (Role)ShowListForms<RoleListForm>.ShowDialogListForm(CardType.Role, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.RoleName;
                        }
                    }
                    break;

                case "txtAccount":
                    {
                        switch (_cardType)
                        {
                            case CardType.Lawyer:
                                {
                                    var entity = (LawyerList)ShowListForms<LawyerListForm>.ShowDialogListForm(CardType.Lawyer, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.NameLastname;
                                    }
                                    break;
                                }

                            case CardType.Vault:
                                {
                                    var entity = (VaultList)ShowListForms<VaultListForm>.ShowDialogListForm(CardType.Vault, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.VaultName;
                                    }
                                    break;
                                }

                            case CardType.BankAccount:
                                {
                                    var entity = (BankAccountList)ShowListForms<BankAccountListForm>.ShowDialogListForm(CardType.BankAccount, _btnEdit.Id, _accountType);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.BankAccountName;
                                    }
                                    break;
                                }

                            case CardType.Customer:
                                {
                                    var entity = (CustomerList)ShowListForms<CustomerListForm>.ShowDialogListForm(CardType.Customer, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.CustomerName;
                                    }
                                    break;
                                }

                            case CardType.Branch:
                                {
                                    var entity = (BranchList)ShowListForms<BranchListForm>.ShowDialogListForm(CardType.Branch, _btnEdit.Id, true);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.BranchName;
                                    }
                                    break;
                                }
                        }
                    }
                    break;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
