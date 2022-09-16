using System.ComponentModel.DataAnnotations;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class FamilyInformations:BaseActionEntity
    {
        public long AccrueId { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        public FamilyInfo FamilyInfo { get; set; }
        public long FamilyInfoId { get; set; }

    }
}