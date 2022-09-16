using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.FilterForms
{
    public partial class FilterListForm : BaseListForm
    {
        #region Variables
        private readonly CardType _filterCardType;
        private readonly GridControl _filterGrid; 
        #endregion

        public FilterListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new FilterBll();

            _filterCardType = (CardType) prm[0];
            _filterGrid = (GridControl) prm[1];

            HideItems=new BarItem[]
            {
                btnFilter,
                btnColumns,
                btnPrint,
                btnSend,
                barFilter,
                barFilterStatement,
                barColumns,
                barColumnsStatement,
                barPrint,
                barPrintStatement,
                barSend,
                barSendStatement,
            };
        }
        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Filter;
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((FilterBll) Bll).List(p=>p.CardType==_filterCardType);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<FilterEditForm>.ShowDialogEditForm(CardType.Filter,id,_filterCardType,_filterGrid);
            ShowEditFormDefault(result);
        }
    }
}