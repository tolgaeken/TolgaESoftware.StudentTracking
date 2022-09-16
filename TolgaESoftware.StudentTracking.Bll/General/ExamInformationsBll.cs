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
    public class ExamInformationsBll : BaseActionBll<ExamInformations, StudentTrackingContext>, IBaseActionSelectBll<ExamInformations>
    {
        public IEnumerable<BaseActionEntity> List(Expression<Func<ExamInformations, bool>> filter)
        {
            return List(filter, p => new ExamInformationsList
            {
                Id = p.Id,
                AccrueId = p.AccrueId,
                Date = p.Date,
                ExamName = p.ExamName,
                ScoreType = p.ScoreType,
                Score = p.Score,
                Ranking = p.Ranking,
                RankingPercentage = p.RankingPercentage
            }).ToList();
        }
    }
}