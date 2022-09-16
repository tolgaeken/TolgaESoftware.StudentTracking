using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.DistrictForms
{
    public partial class DistrictListForm : BaseListForm
    {

        #region Variables
        private readonly long _provinceId;
        private readonly string _provinceName; 
        #endregion

        public DistrictListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new DistrictBll();

            _provinceId = (long) prm[0];
            _provinceName = prm[1].ToString();
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.District;
            Navigator = longNavigator.navigator;
            Text = Text + $" - ( {_provinceName} )"; 
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((DistrictBll) Bll).List(p=>p.Status==ShowActiveCards && p.ProvinceId==_provinceId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<DistrictEditForm>.ShowDialogEditForm(CardType.District,id,_provinceId,_provinceName);
            ShowEditFormDefault(result);
        }
    }
}