using System;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Events;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities.Base;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Controls;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.Grids;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        #region Variables
        private bool _formTemplateToSave;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected IBaseBll Bll;
        protected CardType BaseCardType;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected bool IsLoaded;
        protected bool AnotherBranchProcess;
        protected bool CloseFormPostRegistration = true;
        protected internal ProcessType BaseProcessType;
        protected internal long Id;
        protected internal bool UpdateToDo;
        #endregion

        public BaseEditForm()
        {
            InitializeComponent();
        }


        private void ShowHideButtons()
        {

            ShowItems?.ForEach(p => p.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(p => p.Visibility = BarItemVisibility.Never);
        }
        private void Undo()
        {
            if (Messages.NoSelectedYesNo
                ("Yapılan Değişiklikler Geri Alınacaktır. Onaylıyor musunuz?", "Geri Al Onay") != DialogResult.Yes) return;
            if (BaseProcessType == ProcessType.EntityUpdate) Loads();
            else Close();
        }

        private bool Save(bool closing, CardType cardType)
        {
            bool RegisterProcessing()
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (BaseProcessType)
                {
                    case ProcessType.EntityInsert:
                        if (EntityInsert()) return PostRegistrationProcesses();
                        break;

                    case ProcessType.EntityUpdate:
                        if (EntityUpdate()) return PostRegistrationProcesses();
                        break;
                }

                bool PostRegistrationProcesses()
                {
                    OldEntity = CurrentEntity;
                    UpdateToDo = true;
                    ButtonEnabledStatus();

                    if (CloseFormPostRegistration) Close();
                    else
                        BaseProcessType = BaseProcessType == ProcessType.EntityInsert ? ProcessType.EntityUpdate : BaseProcessType;

                    return true;
                }

                return false;
            }



            var result = closing ? Messages.ClosingMessage(cardType) : Messages.RegistrationMessage(cardType);

            switch (result)
            {
                case DialogResult.Yes:
                    return RegisterProcessing();

                case DialogResult.No:
                    if (closing) btnSave.Enabled = false;
                    return true;

                case DialogResult.Cancel:
                    return false;

            }

            return false;
        }

        private void SaveAs()
        {
            if (Messages.YesSelectedYesNo("Bu Filtre Referans Alınarak Yeni Bir Filtre Oluşturulacaktır. Onaylıyor musunuz?"
                , "Kayıt Onay") != DialogResult.Yes) return;
            BaseProcessType = ProcessType.EntityInsert;
            Loads();
            if (Save(true, BaseCardType)) Close();
        }
        private void LoadTemplate() { Name.LoadFormTemplate(this); }
        protected void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Form Events
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            Shown += BaseEditForm_Shown;


            //Functions
            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                control.GotFocus += Control_GotFocus;
                control.Leave += Control_Leave;
                control.Enter += Control_Enter;

                switch (control)
                {
                    case FilterControl edit:
                        edit.FilterChanged += Control_EditValueChanged;
                        break;
                    case ComboBoxEdit edit:
                        edit.EditValueChanged += Control_SelectedValueChanged;
                        edit.SelectedValueChanged += Control_EditValueChanged;
                        break;
                    case MyButtonEdit edit:
                        edit.IdChanged += Control_IdChanged;
                        edit.EnabledChanged += Control_EnabledChanged;
                        edit.ButtonClick += Control_ButtonClick;
                        edit.DoubleClick += Control_DoubleClick;
                        break;
                    case BaseEdit edit:
                        edit.EditValueChanged += Control_EditValueChanged;
                        break;
                    case TabPane tab:
                        tab.SelectedPageChanged += Control_SelectedPageChanged;
                        break;
                    case PropertyGridControl propertyGrid:
                        propertyGrid.CellValueChanged += Control_CellValueChanged;
                        propertyGrid.FocusedRowChanged += Control_FocusedRowChanged;
                        break;
                }
            }

            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;
                foreach (Control ctrl in DataLayoutControl.Controls) ControlEvents(ctrl);
            }
            else
                foreach (var layout in DataLayoutControls)
                    foreach (Control ctrl in layout.Controls) ControlEvents(ctrl);

        }

        protected void SaveTemplate()
        {
            if (_formTemplateToSave) Name.SaveFormTemplate(Left, Top, Width, Height, WindowState);
        }
        protected virtual void ApplyFilter() { }
        protected virtual void ClearFilter() { }
        protected virtual void CreateInstallment() { }
        protected virtual void LinkObjectToControls() { }
        protected virtual void CreateCurrentObject() { }
        protected virtual void LoadTable() { }
        protected virtual void ResetPassword() { }
        protected virtual void Preview() { }
        protected virtual void Print() { }
        protected virtual void Select(object sender) { }
        protected virtual void LoadLinkedTable() { }
        protected virtual bool SaveLinkedTable() { return false; }
        protected virtual bool LinkedTableWrongDataControl() { return false; }
        protected virtual bool EntityInsert() { return ((IBaseGeneralBll)Bll).Insert(CurrentEntity); }
        protected virtual bool EntityUpdate() { return ((IBaseGeneralBll)Bll).Update(OldEntity, CurrentEntity); }
        protected virtual void EntityDelete()
        {
            if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;
            UpdateToDo = true;
            Close();
        }
        protected internal virtual IBaseEntity ReturnEntity() { return null; }
        public virtual void Loads() { }
        public virtual void Login() { }
        protected internal virtual void ButtonEnabledStatus()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledStatus(btnNew, btnSave, btnUndo, btnDelete, OldEntity, CurrentEntity);

        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnNew)
            {
                //Authentication Control
                BaseProcessType = ProcessType.EntityInsert;
                Loads();
            }
            else if (e.Item == btnSave) Save(false, BaseCardType);
            else if (e.Item == btnSaveAs) SaveAs(); //Authentication Control
            else if (e.Item == btnUndo) Undo();
            else if (e.Item == btnDelete) EntityDelete(); //Authentication Control
            else if (e.Item == btnApply) ApplyFilter();
            else if (e.Item == btnClear) ClearFilter();
            else if (e.Item == btnCreateInstallment) CreateInstallment();
            else if (e.Item == btnPrint) Print();
            else if (e.Item == btnPreview) Preview();
            else if (e.Item == btnResetPassword) ResetPassword();
            else if (e.Item == btnLogin) Login();
            else if (e.Item == btnExit) Close();

            Cursor.Current = DefaultCursor;
        }
        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            _formTemplateToSave = true;
        }
        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            _formTemplateToSave = true;
        }
        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            CreateCurrentObject();
            LoadTemplate();
            ShowHideButtons();

            if (AnotherBranchProcess)
                Messages.WarningMessage("İşlem Yapılan Kart Çalışılan Şube veya Dönemde Olmadığı İçin Yapılan Değişiklikler Kayıt Edilemez");
        }
        protected virtual void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTemplate();

            if (btnSave.Visibility == BarItemVisibility.Never || !btnSave.Enabled) return;
            if (!Save(true, BaseCardType)) e.Cancel = true;
        }
        protected virtual void BaseEditForm_Shown(object sender, EventArgs e) { }
        protected virtual void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();

            if (sender is MyButtonEdit edit)
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift:
                        edit.Id = null;
                        edit.EditValue = null;
                        break;

                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        Select(edit);
                        break;
                }
        }
        private void Control_GotFocus(object sender, EventArgs e)
        {
            var type = sender.GetType();

            if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) ||
                type == typeof(MyComboBoxEdit) || type == typeof(MyDateEdit) || type == typeof(MyCalcEdit) ||
                type == typeof(MyMoneyCalcEdit) || type == typeof(MyColorPickEdit))
            {
                StatusBarShortcut.Visibility = BarItemVisibility.Always;
                StatusBarShortcutStatement.Visibility = BarItemVisibility.Always;

                StatusBarStatement.Caption = ((IStatusBarStatement)sender).StatusBarStatement;
                StatusBarShortcut.Caption = ((IStatusBarShortcut)sender).StatusBarShortcut;
                StatusBarShortcutStatement.Caption = ((IStatusBarShortcut)sender).StatusBarShortcutStatement;
            }
            else if (sender is IStatusBarStatement control) StatusBarStatement.Caption = control.StatusBarStatement;
        }
        private void Control_Leave(object sender, EventArgs e)
        {
            StatusBarShortcut.Visibility = BarItemVisibility.Never;
            StatusBarShortcutStatement.Visibility = BarItemVisibility.Never;
        }
        protected virtual void Control_Enter(object sender, EventArgs e) { }
        protected virtual void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            CreateCurrentObject();
        }
        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }
        protected virtual void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;
            CreateCurrentObject();
        }
        protected virtual void Control_EnabledChanged(object sender, EventArgs e) { }
        private void Control_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            Select(sender);
        }
        private void Control_DoubleClick(object sender, EventArgs e)
        {
            Select(sender);
        }
        protected virtual void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) { }
        protected virtual void Control_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e) { }
        protected virtual void Control_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) { }
    }
}