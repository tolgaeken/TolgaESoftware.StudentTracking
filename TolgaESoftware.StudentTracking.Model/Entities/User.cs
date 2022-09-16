using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class User:BaseEntityStatus
    {
        [Index("IX_Code",IsUnique = true),Code("Kullanıcı Adı","txtUserName"),RequiredField("Kullanıcı Adı","txtUserName")]
        public override string Code { get; set; }

        [Required,StringLength(30),RequiredField("Adı","txtName")]
        public string Name { get; set; }

        [Required,StringLength(30),RequiredField("Soyadı","txtLastname")]
        public string Lastname { get; set; }

        [Required,StringLength(50),RequiredField("E - Mail","txtEmail")]
        public string Email { get; set; }

        [StringLength(32)]
        public string Password { get; set; }

        [StringLength(32)]
        public string Hint { get; set; }

        [StringLength(500)]
        public string Statement { get; set; }

        [RequiredField("Rol","txtRole")]
        public long RoleId { get; set; }
        public Role Role { get; set; }
    }
}