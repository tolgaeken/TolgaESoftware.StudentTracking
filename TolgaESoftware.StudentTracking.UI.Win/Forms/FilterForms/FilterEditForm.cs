using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.FilterForms
{
    public partial class FilterEditForm : BaseEditForm
    {
        #region Variables
        private readonly CardType _filterCardType;
        private readonly GridControl _filterGrid;
        #endregion

        public FilterEditForm(params object[] prm)
        {
            InitializeComponent();

            _filterCardType = (CardType)prm[0];
            _filterGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnNew, btnUndo };
            ShowItems = new BarItem[] { btnSaveAs, btnApply,btnClear };

            DataLayoutControl = myDataLayoutControl;
            Bll = new FilterBll(myDataLayoutControl);
            BaseCardType = CardType.Filter;
            EventsLoad();
        }

        public override void Loads()
        {
            txtFilterText.SourceControl = _filterGrid;

            while (true)
            {
                if (BaseProcessType == ProcessType.EntityInsert)
                {
                    OldEntity = new Filter();
                    Id = BaseProcessType.CreateId(OldEntity);

                    txtCode.Text = ((FilterBll)Bll).GetNewCode(p => p.CardType == _filterCardType);
                    txtFilterName.Focus();
                }
                else
                {
                    OldEntity = ((FilterBll)Bll).Single(FilterFunctions.Filter<Filter>(Id));
                    if (OldEntity == null)
                    {
                        BaseProcessType = ProcessType.EntityInsert;
                        continue;
                    }

                    LinkObjectToControls();
                } 

                break;
            }
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Filter)OldEntity;

            txtCode.Text = entity.Code;
            txtFilterName.Text = entity.FilterName;
            txtFilterText.FilterString = entity.FilterText;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Filter
            {
                Id = Id,
                Code = txtCode.Text,
                FilterName = txtFilterName.Text,
                CardType = _filterCardType,
                FilterText = txtFilterText.FilterString,
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            return ((FilterBll)Bll).Insert(CurrentEntity, p => p.Code == CurrentEntity.Code && p.CardType == _filterCardType);
        }

        protected override bool EntityUpdate()
        {
            return ((FilterBll)Bll).Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code && p.CardType == _filterCardType);
        }

        protected override void ApplyFilter()
        {
            txtFilterText.Select();
            txtFilterText.ApplyFilter();
        }

        protected override void ClearFilter()
        {
            if(Messages.FilterClearMessage()!=DialogResult.Yes) return;
            txtFilterText.ClearFilter();
        }

        protected internal override void ButtonEnabledStatus()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledStatus(btnSave,btnSaveAs,btnDelete,BaseProcessType,OldEntity,CurrentEntity);
        }
    }
}