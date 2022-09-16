namespace TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces
{
    public interface IBaseActionEntity
    {
        bool Insert { get; set; }
        bool Update { get; set; }
        bool Delete { get; set; }
    }
}