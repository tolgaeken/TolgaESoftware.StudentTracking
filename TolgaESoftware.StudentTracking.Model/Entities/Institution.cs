using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class Institution : BaseEntity
    {
        [Index("IX_Code", IsUnique = true)] 
        public override string Code { get; set; }

        [Required, StringLength(50), RequiredField("Kurum Adı", "txtInstitutionName")]
        public string InstitutionName { get; set; }
        
        [Required, StringLength(200), RequiredField("Server Adı", "txtServer")]
        public string Server { get; set; }

        public AuthenticationType AuthenticationType { get; set; } = AuthenticationType.SqlServerAuthentication;

        [Required, StringLength(50), RequiredField("Kullanıcı Adı", "txtUserName")]
        public string UserName { get; set; }

        [Required, StringLength(50), RequiredField("Parola", "txtPassword")]
        public string Password { get; set; }
    }
}