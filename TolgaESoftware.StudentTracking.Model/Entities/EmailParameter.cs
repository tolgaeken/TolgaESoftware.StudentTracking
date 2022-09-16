using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class EmailParameter:BaseEntity
    {
        [Required,StringLength(50),RequiredField("E - Mail Adresi","txtEmail")]
        public string Email { get; set; }
        
        [Required,StringLength(70),RequiredField("Parola","txtPassword")]
        public string Password { get; set; }
        
        [RequiredField("Port Numarası","txtPortNumber")]
        public int PortNumber { get; set; }
        
        [Required,StringLength(50),RequiredField("Host Adresi","txtHost")]
        public string Host { get; set; }

        public YesNo UseSSL { get; set; } = YesNo.Yes;
    }
}