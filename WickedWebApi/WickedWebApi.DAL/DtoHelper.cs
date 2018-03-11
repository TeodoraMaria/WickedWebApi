using Common.Attributes;
using System;
using System.Data;
using System.Linq;
using System.Reflection;

namespace WickedWebApi.DAL
{
    class DtoHelper
    {
            #region Methods - Public

            public static T GetDto<T>(IDataReader reader)
            {
                Type type = typeof(T);
                T dto = Activator.CreateInstance<T>();

                PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                   .Where(p => p.GetCustomAttribute<IgnoreColumnAttribute>() == null).ToArray();

                foreach (PropertyInfo prop in properties)
                {
                    if (prop.PropertyType.FullName != null && prop.PropertyType.IsClass &&
                        !prop.PropertyType.FullName.StartsWith("System.", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                    {
                        object value = reader[prop.Name];
                        if (value == DBNull.Value)
                        {
                            value = null;
                        }
                        prop.SetValue(dto, value, null);
                    }
                    else prop.SetValue(dto, ExtractValue(reader, prop));
                }

                return dto;
            }

            #endregion

            #region Methods - Private

            private static object ExtractValue(IDataReader reader, PropertyInfo prop)
            {
                Type type = prop.PropertyType;
                string readerValue = string.Empty;
                string dbColumnName = prop.Name;

                DbColumnAttribute dbColumnAttr = prop.GetCustomAttribute<DbColumnAttribute>();
                if (null != dbColumnAttr)
                {
                    dbColumnName = dbColumnAttr.ColumnName;
                }

                if (type.IsEnum)
                {
                    return Enum.Parse(type, reader.GetByte(reader.GetOrdinal(dbColumnName)).ToString(), true);
                }

                if (reader[dbColumnName] != DBNull.Value)
                {
                    readerValue = reader[dbColumnName].ToString();
                }

                if (!string.IsNullOrEmpty(readerValue))
                {
                    return Convert.ChangeType(readerValue, type);
                }

                return null;
            }

            #endregion
        
}
}
