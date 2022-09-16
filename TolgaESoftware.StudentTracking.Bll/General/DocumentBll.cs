using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class DocumentBll:BaseGeneralBll<Document>,IBaseCommonBll
    {
        public DocumentBll() : base(CardType.Document) { }
        public DocumentBll(Control control) : base(control, CardType.Document) { }
    }
}