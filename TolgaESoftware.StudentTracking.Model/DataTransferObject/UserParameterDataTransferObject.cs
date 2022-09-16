using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class UserParameterSingle:UserParameter
    {
        public string DefaultLawyerAccountName { get; set; }
        public string DefaultBankAccountName { get; set; }
        public string DefaultVaultAccountName { get; set; }
    }
}
