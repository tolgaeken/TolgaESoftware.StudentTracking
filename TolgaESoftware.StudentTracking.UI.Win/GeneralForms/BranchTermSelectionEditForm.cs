using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.GeneralForms
{
    public partial class BranchTermSelectionEditForm : BaseEditForm
    {
        #region Variables

        private readonly long _userId;
        private readonly bool _branchSelectionButtonClicked;
        private readonly long _selectedIncomingBranchId;
        private readonly long _selectedIncomingTermId;
        private List<long> _authorizedBranches;
        private bool _loginButtonClicked;

        #endregion

        public BranchTermSelectionEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            HideItems = new BarItem[] { btnNew, btnDelete, btnSave, btnUndo };
            ShowItems = new BarItem[] { btnLogin };
            branchNavigator.navigator.NavigatableControl = branchGrid;
            termNavigator.navigator.NavigatableControl = termGrid;
            EventsLoad();

            _userId = (long) prm[0];
            _branchSelectionButtonClicked = (bool) prm[1];
            _selectedIncomingBranchId = (long) prm[2];
            _selectedIncomingBranchId = (long) prm[3];

        }

        public override void Loads()
        {
            using (var bll = new UserUnitAuthorizationsBll())
            {
                var authorizations = bll.List(p => p.UserId == _userId).Cast<UserUnitAuthorizationsList>().ToList();

                _authorizedBranches = authorizations.Where(p => p.BranchId > 0).Select(p => p.BranchId.Value).ToList();

                var branchSource = authorizations.Where(p => p.BranchId > 0).ToList();
                var termSource = authorizations.Where(p => p.TermId > 0).ToList();

                if (branchSource.Count == 0)
                {
                    Messages.ErrorMessage("Kullanıcı Hiçbir Şubede Yekilendirilmediği için Giriş Yapılamaz");
                    Application.ExitThread();
                }

                if (termSource.Count == 0)
                {
                    Messages.ErrorMessage("Kullanıcı Hiçbir Dönemde Yekilendirilmediği için Giriş Yapılamaz");
                    Application.ExitThread();
                }

                branchGrid.DataSource = branchSource;
                termGrid.DataSource = termSource;

                if (!_branchSelectionButtonClicked) return;

                branchTable.RowFocus("BranchId", _selectedIncomingBranchId);
                termTable.RowFocus("TermId", _selectedIncomingTermId);
            }
        }

        public override void Login()
        {
            var branch = branchTable.GetRow<UserUnitAuthorizationsList>();
            var term = termTable.GetRow<UserUnitAuthorizationsList>();

            using (var bll = new TermParameterBll())
            {
                var entity = (TermParameter)bll.Single(p => p.BranchId == branch.BranchId && p.TermId == term.TermId);

                if (entity == null)
                {
                    Messages.ErrorMessage("Seçilen Şubenin İlgili Dönemine Ait Parametreler Girilmemiş\nLütfen Sistem Yöneticinize Başvurunuz");
                    return;
                }

                MainForm.TermParameters = entity;
                MainForm.AuthorizedBranches = _authorizedBranches;
                MainForm.BranchId = branch.BranchId.Value;
                MainForm.BranchName = branch.BranchName;
                MainForm.TermId = term.TermId.Value;
                MainForm.TermName = term.TermName;
            }

            _loginButtonClicked = true;
            Close();
        }

        protected override void Control_KeyDown(object sender, KeyEventArgs e)
        {
            base.Control_KeyDown(sender, e);

            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Tab && e.KeyCode != Keys.Right && e.KeyCode == Keys.Left) return;

            if (sender == branchGrid) termGrid.Focus();
            else if (sender == termGrid) branchGrid.Focus();
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.BaseEditForm_FormClosing(sender, e);

            if (_loginButtonClicked || _branchSelectionButtonClicked) return;

            if (Messages.NoSelectedYesNo("Programdan Çıkmak İstiyor musunuz?", "Çıkış Onay") == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }
    }
}