using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.DistrictForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ProvinceForms
{
    public partial class ProvinceListForm : BaseListForm
    {
        public ProvinceListForm()
        {
            InitializeComponent();
            Bll = new ProvinceBll();
            btnLinkedCards.Caption = "İlçe Kartları";
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Province;
            FormShow = new ShowEditForms<ProvinceEditForm>();
            Navigator = longNavigator.navigator;

            if (IsMdiChild) ShowItems=new BarItem[] {btnLinkedCards};
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((ProvinceBll) Bll).List(FilterFunctions.Filter<Province>(ShowActiveCards));
        }

        protected override void OpenLinkedCard()
        {
            var entity = table.GetRow<Province>();
            if(entity==null)return;
            ShowListForms<DistrictListForm>.ShowListForm(CardType.District,entity.Id,entity.ProvinceName);
        }
    }
}