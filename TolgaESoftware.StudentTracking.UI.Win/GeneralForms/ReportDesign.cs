using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UserDesigner;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.ReportForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class ReportDesign : RibbonForm,ICommandHandler
    {
        #region Variables
        private readonly Report _report; 
        #endregion

        public ReportDesign(params object[] prm)
        {
            InitializeComponent();

            _report = (Report) prm[0];

            Loads();
        }

        protected internal void Loads()
        {
            var stream = new MemoryStream(_report.File);
            var report = stream.StreamToReport();
            reportDesigner.AddCommandHandler(this);
            reportDesigner.OpenReport(report);
            reportDesigner.XtraTabbedMdiManager.View.DocumentProperties.AllowClose = false;
            reportDesigner.XtraTabbedMdiManager.View.DocumentProperties.AllowDock = false;
            reportDesigner.XtraTabbedMdiManager.View.DocumentProperties.AllowFloat = false;
            reportDesigner.ActiveDesignPanel.Report.DisplayName = _report.ReportName;
        }

        private void Save()
        {
            _report.File = reportDesigner.ActiveDesignPanel.Report.ReportToStream().ToArray();
            var result = ShowEditForms<ReportEditForm>.ShowDialogEditForm(CardType.Report, _report.Id,
                _report.ReportType, _report.ReportSectionType, _report.File);

            if(result<=0) return;

            reportDesigner.ActiveDesignPanel.ReportState = ReportState.Saved;
            DialogResult = DialogResult.OK;
            Tag = result;
            Close();
        }

        private void SaveAs()
        {
            _report.Id = 0;
            _report.File = reportDesigner.ActiveDesignPanel.Report.ReportToStream().ToArray();
            var result = ShowEditForms<ReportEditForm>.ShowDialogEditForm(CardType.Report, _report.Id,
                _report.ReportType, _report.ReportSectionType, _report.File);

            if(result<=0) return;

            reportDesigner.ActiveDesignPanel.ReportState = ReportState.Saved;
            DialogResult = DialogResult.OK;
            Tag = result;
            Close();
        }

        public bool CanHandleCommand(ReportCommand command, ref bool useNextHandler)
        {
            useNextHandler = !(command == ReportCommand.SaveFile || 
                               command == ReportCommand.SaveFileAs ||
                               command == ReportCommand.Closing);
            return !useNextHandler;
        }

        public void HandleCommand(ReportCommand command, object[] args)
        {
            if(command==ReportCommand.SaveFile) Save();

            else if(command == ReportCommand.SaveFileAs) SaveAs();

            else if (command == ReportCommand.Closing)
                if (reportDesigner.ActiveDesignPanel.ReportState == ReportState.Changed)
                {
                    var result = Messages.ClosingMessage();

                    switch (result)
                    {
                        case DialogResult.Yes:
                            Save();
                            break;

                        case DialogResult.No:
                            reportDesigner.ActiveDesignPanel.ReportState = ReportState.Closing;
                            Close();
                            break;

                        case DialogResult.Cancel:
                            var eventArgs = args.Cast<CancelEventArgs>().FirstOrDefault();
                            if (eventArgs != null) eventArgs.Cancel = true;
                            break;
                    }
                }
        }
    }
}