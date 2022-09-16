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
    public class SchoolBll:BaseGeneralBll<School>,IBaseGeneralBll,IBaseCommonBll
    {
        public SchoolBll():base(CardType.School) { }

        public SchoolBll(Control control):base(control,CardType.School) { }

        public override BaseEntity Single(Expression<Func<School, bool>> filter)
        {
            return BaseSingle(filter, p => new SchoolSingle
            {
                Id = p.Id,
                Code = p.Code,
                SchoolName = p.SchoolName,
                ProvinceId = p.ProvinceId,
                ProvinceName = p.Province.ProvinceName,
                DistrictId = p.DistrictId,
                DistrictName = p.District.DistrictName,
                Statement = p.Statement,
                Status = p.Status
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<School, bool>> filter)
        {
            return BaseList(filter, p => new SchoolList
            {
                Id = p.Id,
                Code = p.Code,
                SchoolName = p.SchoolName,
                ProvinceName = p.Province.ProvinceName,
                DistrictName = p.District.DistrictName,
                Statement = p.Statement
            }).OrderBy(p=>p.Code).ToList();
        }
    }
}