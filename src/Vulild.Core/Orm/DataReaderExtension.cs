using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Vulild.Core.Orm
{
    public static class DataReaderExtension
    {
        public static List<T> ToList<T>(this IDataReader dr) where T : new()
        {
            List<T> ts = new List<T>();
            Type type = typeof(T);
            List<string> columns = dr.GetColumns();
            PropertyInfo[] pis = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            while (dr.Read())
            {
                T t = new T();
                foreach (var pi in pis)
                {
                    foreach (var column in columns)
                    {
                        if (column.Equals(pi.Name, StringComparison.CurrentCultureIgnoreCase))
                        {
                            var value = dr[pi.Name];
                            if (value != DBNull.Value)
                            {
                                pi.SetValue(t, value);
                            }
                            break;
                        }
                    }
                }
                ts.Add(t);
            }
            return ts;
        }

        public static List<string> GetColumns(this IDataReader dr)
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < dr.FieldCount; i++)
            {
                lst.Add(dr.GetName(i));
            }
            return lst;
        }
    }
}
