using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class InstitutionInformationsBll : BaseGeneralBll<InstitutionInformations>, IBaseGeneralBll, IBaseCommonBll
    {
        public InstitutionInformationsBll(Control control) : base(control) { }

        public override BaseEntity Single(Expression<Func<InstitutionInformations, bool>> filter)
        {
            return BaseSingle(filter, p => new InstitutionInformationsSingle
            {
                Id = p.Id,
                Code = p.Code,
                InstitutionName = p.InstitutionName,
                TaxAdministration = p.TaxAdministration,
                TaxNumber = p.TaxNumber,
                ProvinceId = p.ProvinceId,
                ProvinceName = p.Province.ProvinceName,
                DistrictId = p.DistrictId,
                DistrictName = p.District.DistrictName,

            });
        }
    }
}