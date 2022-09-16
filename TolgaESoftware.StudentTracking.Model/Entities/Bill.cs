using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Bill:BaseActionEntity
    {
        [Column(TypeName = "date")]
        public DateTime PlanDate { get; set; }

        [Column(TypeName = "money")]
        public decimal PlanPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal PlanDiscountPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal PlanNetPrice { get; set; }

        [StringLength(200)]
        public string Statement { get; set; }
        public int? BillNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AccrueDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AccruePrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? AccrueDiscountPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? AccrueNetPrice { get; set; }
        public TaxType? TaxType { get; set; }
        public byte? TaxPercentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxExcludedPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfPrice { get; set; }

        [StringLength(50)]
        public string PriceAsText { get; set; }

        [StringLength(250)]
        public string BillAddress { get; set; }

        public long AccrueId { get; set; }
        public Accrue Accrue { get; set; }

        public long? BillAddressProvinceId { get; set; }
        public Province BillAddressProvince { get; set; }

        public long? BillAddressDistrictId { get; set; }
        public District BillAddressDistrict { get; set; }
    }
}