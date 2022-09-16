using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class FilterBll: BaseGeneralBll<Filter>, IBaseCommonBll
    {
        public FilterBll():base(CardType.Filter) { }

        public FilterBll(Control control):base(control,CardType.Filter) { }
    }
}