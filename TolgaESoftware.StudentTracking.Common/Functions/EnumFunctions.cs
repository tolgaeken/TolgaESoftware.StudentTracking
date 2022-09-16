using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;

namespace TolgaESoftware.StudentTracking.Common.Functions
{
    public static class EnumFunctions
    {
        private static T GetAttribute<T>(this Enum value) where T:Attribute
        {
            if (value == null) return null;
            var memberInfo = value.GetType().GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T) attributes[0];
        }

        public static string ToName(this Enum value)
        {
            if (value == null) return null;
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static ICollection GetEnumDescriptionList<T>()
        {
            return typeof(T).GetMembers()
                .SelectMany(p=>p.GetCustomAttributes(typeof(DescriptionAttribute),true)
                    .Cast<DescriptionAttribute>()).Select(p=>p.Description).ToList();
        }

        public static T GetEnum<T>(this string description)
        {
            if (Enum.IsDefined(typeof(T), description)) return (T) Enum.Parse(typeof(T), description, true);

            var enumNames = Enum.GetNames(typeof(T));

            foreach (var enm in enumNames.Select(p => Enum.Parse(typeof(T), p))
                .Where(c => description == ToName((Enum) c))) return (T)enm;

            return default(T);
        } 
    }
}