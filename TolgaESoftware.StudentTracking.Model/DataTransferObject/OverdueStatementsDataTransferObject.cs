using System;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{

    [NotMapped]
    public class OverdueStatementsSingle : OverdueStatements
    {
        public string UserName { get; set; }
    }

    public class OverdueStatementsList : BaseEntity
    {
        public int WalletNumber { get; set; }
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public string Statement { get; set; }
    }
}
