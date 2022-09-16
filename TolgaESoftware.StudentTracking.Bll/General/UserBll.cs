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
    public class UserBll : BaseGeneralBll<User>, IBaseGeneralBll, IBaseCommonBll
    {
        public UserBll() : base(CardType.User) { }
        public UserBll(Control control) : base(control, CardType.User) { }

        public override BaseEntity Single(Expression<Func<User, bool>> filter)
        {
            return BaseSingle(filter, p => new UserSingle
            {
                Id = p.Id,
                Code = p.Code,
                Name = p.Name,
                Lastname = p.Lastname,
                Email = p.Email,
                RoleId = p.RoleId,
                RoleName = p.Role.RoleName,
                Statement = p.Statement,
                Status = p.Status
            });
        }
        
        public BaseEntity SingleDetail(Expression<Func<User, bool>> filter)
        {
            return BaseSingle(filter, p => new UserSingle
            {
                Id = p.Id,
                Code = p.Code,
                Name = p.Name,
                Lastname = p.Lastname,
                Email = p.Email,
                RoleId = p.RoleId,
                RoleName = p.Role.RoleName,
                Password = p.Password,
                Hint = p.Hint,
                Statement = p.Statement,
                Status = p.Status
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<User, bool>> filter)
        {
            return BaseList(filter, p => new UserList
            {
                Id = p.Id,
                Code = p.Code,
                Name = p.Name,
                Lastname = p.Lastname,
                Email = p.Email,
                RoleName = p.Role.RoleName,
                Statement = p.Statement
            }).OrderBy(p => p.Code).ToList();
        }
    }
}