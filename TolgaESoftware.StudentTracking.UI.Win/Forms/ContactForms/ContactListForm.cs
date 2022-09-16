using System;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.General;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;
using TolgaESoftware.StudentTracking.UI.Win.Show;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.ContactForms
{
    public partial class ContactListForm : BaseListForm
    {

        #region Variables
        private readonly Expression<Func<Contact, bool>> _filter;
        #endregion

        public ContactListForm()
        {
            InitializeComponent();
            Bll= new ContactBll();
            _filter=p => p.Status == ShowActiveCards;
        }

        public ContactListForm(params object[] prm):this()
        {
            _filter = p => !UnlistedData.Contains(p.Id) && p.Status == ShowActiveCards;

        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Contact;
            FormShow = new ShowEditForms<ContactEditForm>();
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            var list = ((ContactBll) Bll).List(_filter);
            Table.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if(list.Any()) HasAddableEntity = true;
            else Messages.CardNotFoundMessage("Kart");
        }
    }
}