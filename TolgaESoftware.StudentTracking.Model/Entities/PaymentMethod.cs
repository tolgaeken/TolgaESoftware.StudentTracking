using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class PaymentMethod:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Ödeme Türü Adı","txtPaymentMethodName")]
        public string PaymentMethodName { get; set; }
        public PaymentType PaymentType { get; set; } = PaymentType.Cash;

        [StringLength(500)]
        public string Statement { get; set; }
    }
}