using System;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class TermParameter:BaseEntity
    {
        //[Column (TypeName = "date")]
        //public DateTime TermStartDate { get; set; } = new DateTime(2021, 09, 01);

        //[Column (TypeName = "date")]
        //public DateTime TermEndDate { get; set; } = new DateTime(2022, 06, 17);

        //[Column (TypeName = "date")]
        //public DateTime EducationStartDate { get; set; } = new DateTime(2021, 09, 06);

        //[Column (TypeName = "date")]
        //public DateTime EducationEndDate { get; set; }

        //[Column (TypeName = "date")]
        //public DateTime MaxInstallmentDate { get; set; } = DateTime.Now.Date;

        //public bool ServiceStartDateCanEnteredBeforeDayDate { get; set; } = true;
        //public bool ServiceStartDateCanEnteredAfterDayDate { get; set; } = true;
        //public bool CancellationDateCanEnteredBeforeDayDate { get; set; } = true;
        //public bool CancellationDateCanEnteredAfterDayDate { get; set; } = true;
        //public bool ReceiptDateCanEnteredBeforeDayDate { get; set; } = true;
        //public bool ReceiptDateCanEnteredAfterDayDate { get; set; } = true;

        //----------------------------------------

        [Column(TypeName = "date")]
        public DateTime TermStartDate { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime TermEndDate { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime EducationStartDate { get; set; } = DateTime.Now.Date;

        [Column(TypeName = "date")]
        public DateTime EducationEndDate { get; set; } = DateTime.Now.Date;

        public bool ServiceStartDateCanEnteredBeforeDayDate { get; set; }
        public bool ServiceStartDateCanEnteredAfterDayDate { get; set; }
        public bool CancellationDateCanEnteredBeforeDayDate { get; set; } = true;
        public bool CancellationDateCanEnteredAfterDayDate { get; set; } = true;
        public bool ReceiptDateCanEnteredBeforeDayDate { get; set; }
        public bool ReceiptDateCanEnteredAfterDayDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime MaxInstallmentDate { get; set; } = DateTime.Now.Date;

        //----------------------------------------


        public byte NumberOfMaximumInstallment { get; set; } = 12;
        public bool HasRequiredSchoolToGoes { get; set; } = true;
        public bool UseServiceAccruePenny { get; set; }
        public bool UseDiscountAccruePenny { get; set; }
        public bool UsePaymentPlanPenny { get; set; }
        public bool UseBillAccruePenny { get; set; }
        public bool AuthorizationControlWillBeInstantly { get; set; }

        public long BranchId { get; set; }
        public Branch Branch { get; set; }

        public long TermId { get; set; }
        public Term Term { get; set; }
    }
}
