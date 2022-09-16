using System.Linq;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.Forms.TermForms;
using TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;
using TolgaESoftware.StudentTracking.UI.Win.Show;
using TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.Base;

namespace TolgaESoftware.StudentTracking.UI.Win.UserControls.UserControl.UserUnitAuthorizationsEditFormTable
{
    public partial class TermTable : BaseTable
    {
        public TermTable()
        {
            InitializeComponent();

            Bll = new UserUnitAuthorizationsBll();
            Table = table;
            EventsLoad();
        }

        protected internal override void List()
        {
            table.GridControl.DataSource =
                ((UserUnitAuthorizationsBll)Bll).List(p => p.UserId == OwnerForm.Id && p.CardType == CardType.Term).ToBindingList<UserUnitAuthorizationsList>();
        }

        protected override void AddAction()
        {
            var source = table.DataController.ListSource;
            UnlistedData = source.Cast<UserUnitAuthorizationsList>().Select(p => p.TermId.Value).ToList();

            var entities =
                ShowListForms<TermListForm>.ShowDialogListForm(UnlistedData, true, false)
                    .EntityListConvert<Term>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new UserUnitAuthorizationsList
                {
                    Code = entity.Code,
                    TermName = entity.TermName,
                    CardType = CardType.Term,
                    UserId = OwnerForm.Id,
                    TermId = entity.Id,
                    Insert = true
                };

                source.Add(row);
            }

            if (!Save()) return;
            List();

            table.Focus();
            table.FocusedRowHandle = table.DataRowCount - 1;
        }

        protected override void DeleteAction()
        {
            if (table.DataRowCount == 0) return;

            if (Messages.DeletionMessage("Dönem Kartı") != DialogResult.Yes) return;

            table.GetRow<IBaseActionEntity>().Delete = true;
            table.RefreshDataSource();

            var rowHandle = table.FocusedRowHandle;

            if (!Save()) return;

            List();
            table.FocusedRowHandle = rowHandle;
        }

        protected override void Table_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            btnDeleteActon.Enabled = table.DataRowCount > 0;
            btnAddAction.Enabled = ((UserUnitAuthorizationEditForm)OwnerForm).userTable.Table.DataRowCount > 0;
            e.ShowRightClickMenu(popupMenu);
        }
    }
}
