using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TolgaESoftware.StudentTracking.Bll.Base;
using TolgaESoftware.StudentTracking.Bll.Interfaces;
using TolgaESoftware.StudentTracking.Data.Contexts;
using TolgaESoftware.StudentTracking.Model.DataTransferObject;
using TolgaESoftware.StudentTracking.Model.Entities;
using TolgaESoftware.StudentTracking.Model.Entities.Base;

namespace TolgaESoftware.StudentTracking.Bll.General
{
    public class DocumentInformationsBll: BaseActionBll<DocumentInformations, StudentTrackingContext>, IBaseActionSelectBll<DocumentInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<DocumentInformations, bool>> filter)
        {
            return List(filter, p => new DocumentInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                DocumentId = p.DocumentId,
                Code = p.Document.Code,
                DocumentName = p.Document.DocumentName
            }).ToList();
        }
    }
}