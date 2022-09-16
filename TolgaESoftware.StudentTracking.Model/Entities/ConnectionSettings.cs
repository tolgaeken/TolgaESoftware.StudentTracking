using System.Security;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.Entities
{
    public class ConnectionSettings:BaseEntity
    {
        public string Server { get; set; }
        public AuthenticationType AuthenticationType { get; set; }
        public SecureString UserName { get; set; }
        public SecureString Password { get; set; }
    }
}