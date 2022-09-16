using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.DataAccess.ObjectBinding;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.DataTransferObject
{
    [NotMapped]
    public class EposInformationsList:EposInformations,IBaseActionEntity
    {
        public string BankName { get; set; }

        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class EposInformationsReport
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string BankName { get; set; }
        public EposCardType CardType { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
    }
}