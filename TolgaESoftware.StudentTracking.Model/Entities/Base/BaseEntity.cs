using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TolgaESoftware.StudentTracking.Model.Attributes;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Model.Entities.Base
{
    public class BaseEntity:IBaseEntity
    {
        [Column(Order = 0),Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        
        [Column(Order = 1),Required,StringLength(20),Code("Kod","txtCode"),RequiredField("Kod","txtCode")]
        public virtual string Code { get; set; }

    }
}