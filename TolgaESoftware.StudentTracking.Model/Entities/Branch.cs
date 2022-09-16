using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Branch:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = false)]
        public override string Code { get; set; }

        [Required,StringLength(50),RequiredField("Şube Adı","txtBranchName")]
        public string BranchName { get; set; }

        [StringLength(17)]
        public string Phone { get; set; }

        [StringLength(17)]
        public string Fax { get; set; }

        [StringLength(32)]
        public string IbanNumber { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [StringLength(250)]
        public string Address { get; set; }


        [RequiredField("İl Adı","txtAddressProvince")]
        public long AddressProvinceId { get; set; }
        public Province AddressProvince { get; set; }


        [RequiredField("İlçe Adı","txtAddressDistrict")]
        public long AddressDistrictId { get; set; }
        public District AddressDistrict { get; set; }

        [StringLength(30)]
        public string GroupName { get; set; }

        public int? RowNumber { get; set; }
    }
}