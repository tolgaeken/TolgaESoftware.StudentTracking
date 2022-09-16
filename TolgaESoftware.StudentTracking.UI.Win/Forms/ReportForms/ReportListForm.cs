using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ReportForms
{
    public partial class ReportListForm : BaseListForm
    {
        #region Variables
        private readonly CardType _reportType;
        private readonly ReportSectionType _reportSectionType;
        private readonly byte[] _file; 
        #endregion

        public ReportListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new ReportBll();

            _reportType = (CardType) prm[0];
            _reportSectionType = (ReportSectionType) prm[1];
            _file = (byte[]) prm[2];
        }

        protected override void FillVariables()
        {

            Table = table;
            BaseCardType = CardType.Report;
            FormShow = new ShowEditForms<ReportEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            Table.GridControl.DataSource = ((ReportBll)Bll).List(p=>p.Status == ShowActiveCards && p.ReportType == _reportType);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<ReportEditForm>.ShowDialogEditForm(CardType.Report,id,_reportType,_reportSectionType,_file);
            ShowEditFormDefault(result);
        }
    }
}