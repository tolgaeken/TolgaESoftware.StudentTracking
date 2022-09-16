using System;
using System.Collections.Generic;
using System.Linq;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;


namespace TolgaESoftware.StudentTracking.Bll.Functions
{
    public static class Converts
    {
        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            if (source == null) return default(TTarget);
            var target = Activator.CreateInstance<TTarget>();
            var sourceProp = source.GetType().GetProperties();
            var targetProp = typeof(TTarget).GetProperties();

            foreach (var src in sourceProp)
            {
                var value = src.GetValue(source);
                var targetProperty = targetProp.FirstOrDefault(p => p.Name == src.Name);
                if (targetProperty!=null)
                {
                    targetProperty.SetValue(target,ReferenceEquals(value,"")?null:value);
                }
            }

            return target;
        }

        public static IEnumerable<TTarget> EntityListConvert<TTarget>(this IEnumerable<IBaseEntity> source)
        {
            return source?.Select(p => p.EntityConvert<TTarget>()).ToList();
        }
    }
}