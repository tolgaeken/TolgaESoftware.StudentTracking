using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankAccountForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankBranchForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BankForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.CancellationReasonForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.KinshipForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.SchoolForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.VaultForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Functions
{
    public static class SelectRepositoryFunctions
    {
        #region Variables
        private static GridView _table;
        private static ControlNavigator _navigator;
        private static RepositoryItemButtonEdit _buttonEdit;
        private static GridColumn _idColumn;
        private static GridColumn _nameColumn;
        private static GridColumn _prmIdColumn;
        private static GridColumn _prmNameColumn;
        #endregion

        private static void RemoveEvent()
        {
            if (_buttonEdit == null) return;

            _buttonEdit.ButtonClick -= ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown -= ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick -= ButtonEdit_DoubleClick;
            _table.KeyDown -= Table_KeyDown;
        }

        public static void Select(this GridColumn nameColumn, GridView table, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit,
            GridColumn idColumn)
        {
            RemoveEvent();

            _table = table;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _table.KeyDown += Table_KeyDown;
        }

        public static void Select(this GridColumn nameColumn, GridView table, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit,
            GridColumn idColumn, GridColumn prmIdColumn, GridColumn prmNameColumn)
        {
            RemoveEvent();

            _table = table;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;
            _prmIdColumn = prmIdColumn;
            _prmNameColumn = prmNameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _table.KeyDown += Table_KeyDown;
        }

        private static void Choose()
        {
            switch (_buttonEdit.Name)
            {
                case "repositoryItemKinship":
                    {
                        var id = _table.GetRowCellId(_idColumn);
                        var entity =
                            (Kinship)ShowListForms<KinshipListForm>.ShowDialogListForm(CardType.Kinship, id);
                        if (entity != null)
                        {
                            _table.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _table.SetFocusedRowCellValue(_nameColumn, entity.KinshipName);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);

                        }
                    }
                    break;

                case "repositoryItemBank":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _table.GetRowCellId(_idColumn);
                        var entity =
                            (BankList)ShowListForms<BankListForm>.ShowDialogListForm(CardType.Bank, id);
                        if (entity != null)
                        {
                            _table.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _table.SetFocusedRowCellValue(_nameColumn, entity.BankName);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);

                        }
                    }
                    break;

                case "repositoryItemBankBranch":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _table.GetRowCellId(_idColumn);
                        var bankId = _table.GetRowCellId(_prmIdColumn);
                        var bankName = _table.GetFocusedRowCellValue(_prmNameColumn).ToString();

                        var entity =
                            (BankBranch)ShowListForms<BankBranchListForm>.ShowDialogListForm(CardType.BankBranch, id, bankId, bankName);
                        if (entity != null)
                        {
                            _table.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _table.SetFocusedRowCellValue(_nameColumn, entity.BankBranchName);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;

                case "repositoryItemBankAccount":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _table.GetRowCellId(_idColumn);
                        var paymentType = _table.GetFocusedRowCellValue("PaymentType").ToString().GetEnum<PaymentType>();

                        var entity =
                            (BankAccountList)ShowListForms<BankAccountListForm>.ShowDialogListForm(CardType.BankAccount, id, paymentType);
                        if (entity != null)
                        {
                            _table.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _table.SetFocusedRowCellValue(_nameColumn, entity.BankAccountName);
                            _table.SetFocusedRowCellValue("BlockedDay", entity.BlockedDay);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        }
                    }
                    break;

                case "repositoryItemCancellationReason":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _table.GetRowCellId(_idColumn);
                        var entity =
                            (CancellationReason)ShowListForms<CancellationReasonListForm>.ShowDialogListForm(CardType.CancellationReason, id);
                        if (entity != null)
                        {
                            _table.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _table.SetFocusedRowCellValue(_nameColumn, entity.CancellationReasonName);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);

                        }
                    }
                    break;

                case "repositoryItemSchoolToGoes":
                    {
                        if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        var id = _table.GetRowCellId(_idColumn);
                        var entity =
                            (SchoolList)ShowListForms<SchoolListForm>.ShowDialogListForm(CardType.School, id);
                        if (entity != null)
                        {
                            _table.SetFocusedRowCellValue(_idColumn, entity.Id);
                            _table.SetFocusedRowCellValue(_nameColumn, entity.SchoolName);
                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);

                        }
                    }
                    break;

                case "repositoryItemAccount":
                    {
                        var id = _table.GetRowCellId(_idColumn);

                        switch (_table.GetRow<RefundInformationsList>().AccountType)
                        {
                            case RefundAccountType.Bank:
                                var bankEntity =
                                    (BankAccountList)ShowListForms<BankAccountListForm>.ShowDialogListForm(CardType.BankAccount, id, PaymentType.Cash);
                                if (bankEntity == null) return;

                                _table.SetFocusedRowCellValue(_idColumn, bankEntity.Id);
                                _table.SetFocusedRowCellValue(_nameColumn, bankEntity.BankAccountName);
                                _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);


                                break;

                            case RefundAccountType.Vault:
                                var vaultEntity =
                                    (VaultList)ShowListForms<VaultListForm>.ShowDialogListForm(CardType.Vault, id);
                                if (vaultEntity == null) return;

                                _table.SetFocusedRowCellValue(_idColumn, vaultEntity.Id);
                                _table.SetFocusedRowCellValue(_nameColumn, vaultEntity.VaultName);
                                _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);

                                break;
                        }
                    }
                    break;
            }
        }

        private static void ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            Choose();
        }

        private static void ButtonEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _table.SetFocusedRowCellValue(_idColumn, null);
                    _table.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                    break;
                case Keys.F4:
                case Keys.Down when e.Alt:
                    Choose();
                    break;
            }
        }

        private static void ButtonEdit_DoubleClick(object sender, EventArgs e)
        {
            Choose();
        }

        private static void Table_KeyDown(object sender, KeyEventArgs e)
        {
            if (_table.FocusedColumn.ColumnEdit == null) return;
            var type = _table.FocusedColumn.ColumnEdit.GetType();

            if (type != typeof(RepositoryItemButtonEdit)) return;

            switch (e.KeyCode)
            {
                case Keys.Delete when e.Control && e.Shift:
                    _table.SetFocusedRowCellValue(_idColumn, null);
                    _table.SetFocusedRowCellValue(_nameColumn, null);
                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                    break;
                case Keys.F4:
                case Keys.Down when e.Alt:
                    Choose();
                    break;
            }
        }
    }
}