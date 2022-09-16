using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class UserParameterBll:BaseGeneralBll<UserParameter>,IBaseGeneralBll
    {
        public UserParameterBll() : base(CardType.UserParameter) { }

        public UserParameterBll(Control control) : base(control, CardType.UserParameter) { }

        public override BaseEntity Single(Expression<Func<UserParameter, bool>> filter)
        {
            return BaseSingle(filter, p => new UserParameterSingle
            {
                Id = p.Id,
                Code = p.Code,
                UserId = p.UserId,
                DefaultLawyerAccountId = p.DefaultLawyerAccountId,
                DefaultLawyerAccountName = p.DefaultLawyerAccount.NameLastname,
                DefaultBankAccountId = p.DefaultBankAccountId,
                DefaultBankAccountName = p.DefaultBankAccount.BankAccountName,
                DefaultVaultAccountId = p.DefaultVaultAccountId,
                DefaultVaultAccountName = p.DefaultVaultAccount.VaultName,
                CloseReportsWithoutConfirmation = p.CloseReportsWithoutConfirmation,
                TableViewCaptionForeColor = p.TableViewCaptionForeColor,
                TableColumnHeaderForeColor = p.TableColumnHeaderForeColor,
                TableBandPanelForeColor = p.TableBandPanelForeColor,
                BackgroundImage = p.BackgroundImage,
            });
        }
    }
}
