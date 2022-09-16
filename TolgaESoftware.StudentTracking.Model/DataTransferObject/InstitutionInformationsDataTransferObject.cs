using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class InstitutionInformationsSingle : InstitutionInformations
    {
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }

    }
}
