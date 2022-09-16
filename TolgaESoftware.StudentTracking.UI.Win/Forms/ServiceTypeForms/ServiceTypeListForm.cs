using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ServiceTypeForms
{
    public partial class ServiceTypeListForm : BaseListForm
    {
        public ServiceTypeListForm()
        {
            InitializeComponent();
            Bll = new ServiceTypeBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.ServiceType;
            FormShow = new ShowEditForms<ServiceTypeEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((ServiceTypeBll) Bll).List(FilterFunctions.Filter<ServiceType>(ShowActiveCards));
        }
    }
}