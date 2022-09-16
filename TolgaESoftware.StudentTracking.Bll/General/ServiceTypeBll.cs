using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class ServiceTypeBll:BaseGeneralBll<ServiceType>,IBaseGeneralBll,IBaseCommonBll
    {
        public ServiceTypeBll() : base(CardType.ServiceType) { }
        public ServiceTypeBll(Control control) : base(control, CardType.ServiceType) { }
    }
}