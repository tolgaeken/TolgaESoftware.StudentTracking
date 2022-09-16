using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.DiscountTypeForms
{
    public partial class DiscountTypeListForm : BaseListForm
    {
        public DiscountTypeListForm()
        {
            InitializeComponent();
            Bll = new DiscountTypeBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.DiscountType;
            FormShow = new ShowEditForms<DiscountTypeEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((DiscountTypeBll) Bll).List(FilterFunctions.Filter<DiscountType>(ShowActiveCards));
        }
    }
}