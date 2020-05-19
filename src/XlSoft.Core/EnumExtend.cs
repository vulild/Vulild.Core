using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Vulild.Core
{
    public static class EnumExtend
    {
        public static string GetDescription<T>(this T value) where T : Enum
        {
            Type type = typeof(T);
            FieldInfo fi = type.GetField(value.ToString());
            if (fi != null)
            {
                DescriptionAttribute attr = fi.GetCustomAttribute<DescriptionAttribute>();
                if (attr != null)
                {
                    return attr.Description;
                }
                else
                {
                    throw new NotImplementedException($"{value.GetType().FullName}.{ value} 的枚举未设置描述信息");
                }
            }
            else
            {
                throw new NotImplementedException($"尚未实现{ value.GetType().FullName}.{value}的枚举。");
            }
        }

    }

    public enum Test
    {
        test
    }
}
