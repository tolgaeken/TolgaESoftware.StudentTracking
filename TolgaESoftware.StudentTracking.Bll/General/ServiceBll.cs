using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Common.Enums;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class ServiceBll : BaseGeneralBll<Service>, IBaseCommonBll
    {
        public ServiceBll() : base(CardType.Service) { }
        public ServiceBll(Control control) : base(control, CardType.Service) { }

        public override BaseEntity Single(Expression<Func<Service, bool>> filter)
        {
            return BaseSingle(filter, p => new ServiceSingle
            {
                Id = p.Id,
                Code = p.Code,
                ServiceName = p.ServiceName,
                ServiceTypeId = p.ServiceTypeId,
                ServiceTypeName = p.ServiceType.ServiceTypeName,
                StartDate = p.StartDate,
                EndDate = p.EndDate,
                Price = p.Price,
                BranchId = p.BranchId,
                TermId = p.TermId,
                Statement = p.Statement,
                Status = p.Status
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Service, bool>> filter)
        {
            return BaseList(filter, p => new ServiceList
            {
                Id = p.Id,
                Code = p.Code,
                ServiceName = p.ServiceName,
                ServiceTypeId = p.ServiceTypeId,
                ServiceTypeName = p.ServiceType.ServiceTypeName,
                ServiceTypeEnum = p.ServiceType.ServiceTypeEnum,
                StartDate = p.StartDate,
                EndDate = p.EndDate,
                Price = p.Price,
                Statement = p.Statement
            }).OrderBy(p => p.Code).ToList();
        }
    }
}