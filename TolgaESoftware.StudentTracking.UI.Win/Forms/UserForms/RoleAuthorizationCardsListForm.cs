using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Common.Functions;
using TolgaESoftware.StudentTracking.Common.Message;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.UI.Win.Forms.BaseForms;

namespace TolgaESoftware.StudentTracking.UI.Win.Forms.UserForms
{
    public partial class RoleAuthorizationCardsListForm : BaseListForm
    {
        public RoleAuthorizationCardsListForm()
        {
            InitializeComponent();
            HideItems = new BarItem[]
            {
                btnNew, btnDelete, btnEdit, btnColumns,
                barInsert, barInsertStatement, barDelete, barDeleteStatement,
                barEdit, barEditStatement, barColumns, barColumnsStatement
            };
        }

        protected override void FillVariables()
        {
            Table = table;
            BaseCardType = CardType.Authorization;
            Navigator = longNavigator.navigator;
        }

        protected override void List()
        {
            var enumList = Enum.GetValues(typeof(CardType)).Cast<CardType>().ToList();
            var roleList = new List<RoleAuthorization>();

            enumList.ForEach(p =>
            {
                var entity = new RoleAuthorization
                {
                    CardType = p
                };

                roleList.Add(entity);
            });

            var list = roleList.Where(p => p.CardType != CardType.UserParameter &&
                                           p.CardType != CardType.Institution &&
                                           p.CardType != CardType.EmailParameter &&
                                           p.CardType != CardType.Term &&
                                           p.CardType != CardType.TermParameter &&
                                           p.CardType != CardType.InstitutionInformations &&
                                           p.CardType != CardType.Role &&
                                           p.CardType != CardType.User &&
                                           p.CardType != CardType.ConnectionSettings &&
                                           p.CardType != CardType.ForgotPassword &&
                                           p.CardType != CardType.Authorization)
                .Where(p => !UnlistedData.Contains((long)p.CardType)).OrderBy(p => p.CardType.ToName());
            Table.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any()) HasAddableEntity = true;
            else Messages.CardNotFoundMessage("Kart");
        }
    }
}