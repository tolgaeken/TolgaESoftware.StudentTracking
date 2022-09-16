using System;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Show.Interfaces;

namespace TolgaESoftware.StudentTracking.UI.Win.Show
{
    public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm
    {
        public long ShowDialogEditForm(CardType cardType, long id)
        {
            //Authentication Control

            using (var form = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                form.BaseProcessType = id > 0 ? ProcessType.EntityUpdate : ProcessType.EntityInsert;
                form.Id = id;
                form.Loads();
                form.ShowDialog();
                return form.UpdateToDo ? form.Id : 0;
            }
        }

        public static long ShowDialogEditForm(CardType cardType, long id, params object[] prm)
        {
            //Authentication Control

            using (var form = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                form.BaseProcessType = id > 0 ? ProcessType.EntityUpdate : ProcessType.EntityInsert;
                form.Id = id;
                form.Loads();
                form.ShowDialog();
                return form.UpdateToDo ? form.Id : 0;
            }
        }

        public static long ShowDialogEditForm(long id, params object[] prm)
        {
            using (var form = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                form.BaseProcessType = id > 0 ? ProcessType.EntityUpdate : ProcessType.EntityInsert;
                form.Id = id;
                form.Loads();
                form.ShowDialog();
                return form.UpdateToDo ? form.Id : 0;
            }
        }

        public static void ShowDialogEditForm(long? id, params object[] prm)
        {
            using (var form = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                form.Loads();
                form.ShowDialog();
            }
        }

        public static T ShowDialogEditForm<T>(params object[] prm) where T : IBaseEntity
        {
            using (var form = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                form.Loads();
                form.ShowDialog();
                return (T)form.ReturnEntity();
            }
        }

        public static bool ShowDialogEditForm(params object[] prm)
        {
            using (var form = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                form.Loads();
                return form.DialogResult == DialogResult.OK;
            }
        }

        public static bool ShowDialogEditForm(CardType cardType, params object[] prm)
        {
            //Authentication Control

            using (var form = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                form.Loads();
                form.ShowDialog();
                return form.DialogResult == DialogResult.OK;
            }
        }

        public static void ShowDialogEditForm()
        {

            using (var form = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                form.Loads();
                form.ShowDialog();
            }
        }

        public static bool ShowDialogEditForm(ProcessType processType, params object[] prm)
        {

            using (var form = (TForm)Activator.CreateInstance(typeof(TForm),prm))
            {
                form.BaseProcessType = processType;
                form.Loads();
                form.ShowDialog();

                return form.UpdateToDo;
            }
        }

        public static void ShowDialogEditForm(CardType cardType)
        {
            //Authentication Control

            using (var form = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                form.BaseProcessType = ProcessType.EntityUpdate;
                form.Loads();
                form.ShowDialog();
            }
        }
    }
}