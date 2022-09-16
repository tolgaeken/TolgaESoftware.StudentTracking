using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class UserSingle:User
    {
        public string RoleName { get; set; }
    }

    public class UserList : BaseEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string Statement { get; set; }
    }
}