using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ForeignLanguageForms
{
    public partial class ForeignLanguageListForm : BaseListForm
    {
        public ForeignLanguageListForm()
        {
            InitializeComponent();
            Bll = new ForeignLanguageBll();
        }

        protected override void FillVariables()
        {
            
            Table = table;
            BaseCardType = CardType.ForeignLanguage;
            FormShow = new ShowEditForms<ForeignLanguageEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((ForeignLanguageBll) Bll).List(FilterFunctions.Filter<ForeignLanguage>(ShowActiveCards));
        }
    }
}