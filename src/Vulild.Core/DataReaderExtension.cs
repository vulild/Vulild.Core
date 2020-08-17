using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace Vulild.Core
{
    public static class DataReaderExtension
    {
        public static List<T> ToList<T>(this IDataReader dr) where T : new()
        {
            List<T> ts = new List<T>();
            Type type = typeof(T);
            List<string> columns = dr.GetColumns();
            PropertyInfo[] pis = type.GetProperties();
            while (dr.Read())
            {
                T t = new T();
                foreach (var pi in pis)
                {
                    if (columns.Contains(pi.Name))
                    {
                        var value = dr[pi.Name];
                        pi.SetValue(t, Convert.ChangeType(value, pi.PropertyType));
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
