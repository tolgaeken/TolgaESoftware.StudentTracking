using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Runtime.InteropServices;
using System.Security;
using DevExpress.Utils.Extensions;
using TolgaESoftware.Dal.Base;
using TolgaESoftware.Dal.Interfaces;
using TolgaESoftware.StudentTracking.Model.Entities.Base.Interfaces;

namespace TolgaESoftware.StudentTracking.Bll.Functions
{
    public static class GeneralFunctions
    {
        public static List<string> GetChangingFields<T>(this T oldEntity, T currentEntity)
        {
            List<string> fields = new List<string>();
            foreach (var property in currentEntity.GetType().GetProperties())
            {
                if (property.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = property.GetValue(oldEntity) ?? string.Empty;
                var currentValue = property.GetValue(currentEntity) ?? string.Empty;

                if (property.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };

                    if (string.IsNullOrEmpty(currentValue.ToString()))
                        currentValue = new byte[] { 0 };

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                        fields.Add(property.Name);
                }

                if (property.PropertyType == typeof(SecureString))
                {
                    var oldString = ((SecureString) oldValue).ConvertToUnsecureString();
                    var currentString = ((SecureString) currentValue).ConvertToUnsecureString();

                    if (!oldString.Equals(currentString))
                        fields.Add(property.Name);
                }

                else if (!currentValue.Equals(oldValue))
                    fields.Add(property.Name);

            }

            return fields;
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["StudentTrackingContext"].ConnectionString;
        }

        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }

        public static void CreateUnitOfWork<T, TContext>(ref IUnitOfWork<T> unitOfWork)
            where T : class, IBaseEntity
            where TContext : DbContext
        {
            unitOfWork?.Dispose();
            unitOfWork = new UnitOfWork<T>(CreateContext<TContext>());
        }

        public static SecureString ConvertToSecureString(this string value)
        {
            var secureString = new SecureString();

            if (value.Length > 0)
                value.ToCharArray().ForEach(p => secureString.AppendChar(p));

            secureString.MakeReadOnly();
            return secureString;
        }

        public static string ConvertToUnsecureString(this SecureString value)
        {
            var result = Marshal.SecureStringToBSTR(value);
            return Marshal.PtrToStringAuto(result);
        }
    }
}