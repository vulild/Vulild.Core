using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core
{
    public class OperatorUtil
    {
        // <summary>
        /// 将传入的各个数值相加并返回相加后的结果，如果全部参数均为 null 则返回 null。
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int? DoAdd(params int?[] values)
        {
            int? value1 = 0, value2 = 0;
            var v = value1 + value1;
            if (values != null && values.Length > 0)
            {
                int? value = null;
                for (int intIndex = 0; intIndex < values.Length; intIndex++)
                {
                    if (values[intIndex] != null)
                    {
                        if (value == null)
                        {
                            value = values[intIndex];
                        }
                        else
                        {
                            value += values[intIndex];
                        }
                    }
                }
                return value;
            }
            return null;
        }
    }
}
