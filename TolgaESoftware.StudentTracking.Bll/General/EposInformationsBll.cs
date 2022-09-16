using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Functions;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class EposInformationsBll : BaseActionBll<EposInformations, StudentTrackingContext>, IBaseActionSelectBll<EposInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<EposInformations, bool>> filter)
        {
            var entities = List(filter, p => new EposInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                Name = p.Name,
                Lastname = p.Lastname,
                CardType = p.CardType,
                BankId = p.BankId,
                BankName = p.Bank.BankName,
                CardNumber = p.CardNumber,
                ExpirationDate = p.ExpirationDate,
                SecurityCode = p.SecurityCode
            }).ToList();


            foreach (EposInformationsList entity in entities)
            {
                var key = entity.AccrueId + "" + entity.BankId;
                entity.CardNumber = entity.CardNumber.Decrypt(key);
                entity.ExpirationDate = entity.ExpirationDate.Decrypt(key);
                entity.SecurityCode = entity.SecurityCode.Decrypt(key);
            }

            return entities;
        }

        public override bool Insert(IList<BaseActionEntity> entities)
        {
            foreach (EposInformationsList entity in entities)
            {
                var key = entity.AccrueId + "" + entity.BankId;
                entity.CardNumber = entity.CardNumber.Encrypt(key);
                entity.ExpirationDate = entity.ExpirationDate.Encrypt(key);
                entity.SecurityCode = entity.SecurityCode.Encrypt(key);
            }

            return base.Insert(entities);
        }

        public override bool Update(IList<BaseActionEntity> entities)
        {
            foreach (EposInformationsList entity in entities)
            {
                var key = entity.AccrueId + "" + entity.BankId;
                entity.CardNumber = entity.CardNumber.Encrypt(key);
                entity.ExpirationDate = entity.ExpirationDate.Encrypt(key);
                entity.SecurityCode = entity.SecurityCode.Encrypt(key);
            }

            return base.Update(entities);
        }
    }
}