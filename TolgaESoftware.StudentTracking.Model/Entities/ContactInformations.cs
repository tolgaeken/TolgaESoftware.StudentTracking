using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class ContactInformations:BaseActionEntity
    {
        public bool Guardianship { get; set; }
        public AddressType? BillingAddress { get; set; }

        public Contact Contact { get; set; }
        public long ContactId { get; set; }

        public Kinship Kinship { get; set; }
        public long KinshipId { get; set; }

        //public Accrue Accrue { get; set; }
        public long AccrueId { get; set; }
    }
}