using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.KinshipForms
{
    public partial class KinshipListForm : BaseListForm
    {
        public KinshipListForm()
        {
            InitializeComponent();
            Bll = new KinshipBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.Kinship;
            FormShow = new ShowEditForms<KinshipEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((KinshipBll) Bll).List(FilterFunctions.Filter<Kinship>(ShowActiveCards));
        }
    }
}