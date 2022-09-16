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
    public class NoteInformationsBll : BaseActionBll<NoteInformations, StudentTrackingContext>, IBaseActionSelectBll<NoteInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<NoteInformations, bool>> filter)
        {
            return List(filter, p => new NoteInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                Date = p.Date,
                Note = p.Note
            }).ToList();
        }
    }
}