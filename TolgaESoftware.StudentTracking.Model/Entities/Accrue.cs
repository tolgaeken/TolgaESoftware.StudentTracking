using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Accrue:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false),RequiredField("Öğrenci No" , "txtCode")]
        public override string Code { get; set; }


        [StringLength(20)]
        public string SchoolNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public EnrollmentType EnrollmentType { get; set; } = EnrollmentType.NewEnrollment;

        public EnrollmentStatus EnrollmentStatus { get; set; } = EnrollmentStatus.CertainEnroll;

        public NextTermEnrollmentStatus NextTermEnrollmentStatus { get; set; } = NextTermEnrollmentStatus.WillBeRenewedEnrollment;

        [StringLength(500)]
        public string NextTermEnrollmentStatusStatement { get; set; }

        public long StudentId { get; set; }
        public Student Student { get; set; }

        [RequiredField("Sınıf Adı","txtClass")]
        public long ClassId { get; set; }
        public Class Class { get; set; }

        public long? ComesFromSchoolId { get; set; }
        public School ComesFromSchool { get; set; }

        public long? QuotaId { get; set; }
        public Quota Quota { get; set; }

        public long? ForeignLanguageId { get; set; }
        public ForeignLanguage ForeignLanguage { get; set; }

        public long? GuideId { get; set; }
        public Guide Guide { get; set; }

        public long? IncentId { get; set; }
        public Incent Incent { get; set; }

        public long? SpecialCode1Id { get; set; }
        public SpecialCode SpecialCode1 { get; set; }

        public long? SpecialCode2Id { get; set; }
        public SpecialCode SpecialCode2 { get; set; }

        public long? SpecialCode3Id { get; set; }
        public SpecialCode SpecialCode3 { get; set; }

        public long? SpecialCode4Id { get; set; }
        public SpecialCode SpecialCode4 { get; set; }

        public long? SpecialCode5Id { get; set; }
        public SpecialCode SpecialCode5 { get; set; }

        public long BranchId { get; set; }
        public Branch Branch { get; set; }

        public long TermId { get; set; }
        public Term Term { get; set; }

        public ICollection<ContactInformations> ContactInformations { get; set; }
        public ICollection<ServiceInformations> ServiceInformations { get; set; }
        public ICollection<DiscountInformations> DiscountInformations { get; set; }
        public ICollection<PaymentInformations> PaymentInformations { get; set; }
        public ICollection<RefundInformations> RefundInformations { get; set; }
        public ICollection<Bill> BillInformations { get; set; }
    }
}