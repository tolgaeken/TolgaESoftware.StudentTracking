using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Functions;

namespace TolgaESoftware.StudentTracking.UI.Win.Show
{
    public class ShowListForms<TForm> where TForm : BaseListForm
    {
        public static void ShowListForm(CardType cardType)
        {
            //Authentication Control

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Loads();
            frm.Show();
        }

        public static void ShowListForm(CardType cardType, params object[] prm)
        {
            //Authentication Control

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            frm.MdiParent = Form.ActiveForm;

            frm.Loads();
            frm.Show();
        }

        public static void ShowDialogListForm()
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.ShowActivePassiveButton = true;
                frm.Loads();
                frm.ShowDialog();
            }
        }

        public static BaseEntity ShowDialogListForm(CardType cardType, long? selectedIncomingId, params object[] prm)
        {
            //Authentication Control

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.SelectedIncomingId = selectedIncomingId;
                frm.Loads();

                if (!frm.IsDisposed) frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(CardType cardType, IList<long> unlistedData, bool multiSelect, params object[] prm)
        {
            //Authentication Control

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.UnlistedData = unlistedData;
                frm.MultiSelect = multiSelect;
                frm.Loads();
                frm.RowSelect = new SelectRowFunctions(frm.Table);

                if (frm.HasAddableEntity) frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(IList<long> unlistedData, bool multiSelect, params object[] prm)
        {

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.UnlistedData = unlistedData;
                frm.MultiSelect = multiSelect;
                frm.Loads();
                frm.RowSelect = new SelectRowFunctions(frm.Table);

                if (frm.HasAddableEntity) frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(CardType cardType, bool multiSelect, params object[] prm)
        {
            //Authentication Control

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.MultiSelect = multiSelect;
                frm.Loads();
                frm.RowSelect = new SelectRowFunctions(frm.Table);

                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }
    }
}