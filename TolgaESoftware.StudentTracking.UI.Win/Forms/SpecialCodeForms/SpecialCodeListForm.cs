using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.SpecialCodeForms
{
    public partial class SpecialCodeListForm : BaseListForm
    {
        #region Variables
        private readonly SpecialCodeType _specialCodeType;
        private readonly CardType _specialCodeCardType; 
        #endregion

        public SpecialCodeListForm(params object[] prm)
        {
            InitializeComponent();
            Bll= new SpecialCodeBll();

            _specialCodeType = (SpecialCodeType) prm[0];
            _specialCodeCardType = (CardType) prm[1];
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.SpecialCode;
            Navigator = longNavigator.navigator;
            Text = $"{Text} - ( {_specialCodeType.ToName()} )";
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((SpecialCodeBll) Bll).List(p=>p.SpecialCodeType==_specialCodeType 
                                                                          && p.SpecialCodeCardType==_specialCodeCardType );
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<SpecialCodeEditForm>.ShowDialogEditForm(CardType.SpecialCode,id,_specialCodeType,_specialCodeCardType);
            ShowEditFormDefault(result);
        }

    }
}