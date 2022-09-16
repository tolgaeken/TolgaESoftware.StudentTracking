using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ReportForms
{
    public partial class ReportEditForm : BaseEditForm
    {
        #region Variables
        private readonly CardType _reportType;
        private readonly ReportSectionType _reportSectionType;
        private readonly byte[] _file; 
        #endregion

        public ReportEditForm(params object[] prm)
        {
            InitializeComponent();
       
            DataLayoutControl = myDataLayoutControl;
            Bll = new ReportBll(myDataLayoutControl);
            BaseCardType = CardType.Report;
            EventsLoad();

            _reportType = (CardType) prm[0];
            _reportSectionType = (ReportSectionType) prm[1];
            _file = (byte[]) prm[2];
        }

        public override void Loads()
        {
            OldEntity = BaseProcessType == ProcessType.EntityInsert ? new Report() : ((ReportBll) Bll).Single(FilterFunctions.Filter<Report>(Id));
            LinkObjectToControls();

            if (BaseProcessType!=ProcessType.EntityInsert) return;
            Id = BaseProcessType.CreateId(OldEntity);
            txtCode.Text = ((ReportBll) Bll).GetNewCode(p=>p.ReportSectionType==_reportSectionType && p.ReportType == _reportType);
            txtReportName.Focus();
        }

        protected override void LinkObjectToControls()
        {
            var entity = (Report) OldEntity;

            txtCode.Text = entity.Code;
            txtReportName.Text = entity.ReportName;
            txtStatement.Text = entity.Statement;
            tglStatus.IsOn = entity.Status;
        }

        protected override void CreateCurrentObject()
        {
            CurrentEntity = new Report
            {
                Id = Id,
                Code = txtCode.Text,
                ReportName = txtReportName.Text,
                ReportType = _reportType,
                ReportSectionType = _reportSectionType,
                File = _file,
                Statement = txtStatement.Text,
                Status = tglStatus.IsOn
            };

            ButtonEnabledStatus();
        }

        protected override bool EntityInsert()
        {
            return ((ReportBll) Bll).Insert(CurrentEntity, p => p.Code == CurrentEntity.Code
                                                                && p.ReportSectionType==_reportSectionType
                                                                && p.ReportType == _reportType);
        }                                               

        protected override bool EntityUpdate()
        {
            return ((ReportBll) Bll).Update(OldEntity, CurrentEntity, p => p.Code == CurrentEntity.Code
                                                                           && p.ReportSectionType==_reportSectionType
                                                                           && p.ReportType == _reportType);
        }
    }
}