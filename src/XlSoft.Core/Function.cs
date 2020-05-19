using Vulild.Core.FormatConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core
{
    public class Function
    {
        /// <summary>
        /// 比较两个可空数字是否完全相等。如果两个值均为空返回 true；均不为空且值相等返回 true；其余情况均返回 false。
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static bool Equals(int? value1, int? value2)
        {
            if (value1 == null && value2 == null)
            {
                return true;
            }
            else if (value1 != null && value2 != null)
            {
                return value1 == value2;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 比较两个可空数字是否完全相等。如果两个值均为空返回 true；均不为空且值相等返回 true；其余情况均返回 false。
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static bool Equals(long? value1, long? value2)
        {
            if (value1 == null && value2 == null)
            {
                return true;
            }
            else if (value1 != null && value2 != null)
            {
                return value1 == value2;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 比较两个可空数字是否完全相等。如果两个值均为空返回 true；均不为空且值相等返回 true；其余情况均返回 false。
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static bool Equals(decimal? value1, decimal? value2)
        {
            if (value1 == null && value2 == null)
            {
                return true;
            }
            else if (value1 != null && value2 != null)
            {
                return value1 == value2;
            }
            else
            {
                return false;
            }
        }

        #region 数学运算

        /// <summary>
        /// 将传入的各个数值相加并返回相加后的结果，如果全部参数均为 null 则返回 null。
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int? DoAdd(params int?[] values)
        {
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

        /// <summary>
        /// 将传入的各个数值相加并返回相加后的结果，如果全部参数均为 null 则返回 null。
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static decimal? DoAdd(params decimal?[] values)
        {
            if (values != null && values.Length > 0)
            {
                decimal? value = null;
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

        /// <summary>
        /// 返回 value1 - value2 的结果。如果其中一个数据为 null 则返回 null。
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static decimal? DoSub(decimal? value1, decimal? value2)
        {
            if (value1.HasValue && value2.HasValue)
            {
                return value1.Value - value2.Value;
            }
            return null;
        }

        /// <summary>
        /// 返回 value1 - value2 的结果，并判断两个数字的大小关系。如果其中一个数据为 null 则返回 null。
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="notLessThan">[true]如果 value1 小于 value2 则返回 null；[false]如果 value2 小于 value1 则返回 null。</param>
        /// <returns></returns>
        public static decimal? DoSub(decimal? value1, decimal? value2, bool notLessThan)
        {
            if (value1.HasValue && value2.HasValue)
            {
                if (notLessThan)
                {
                    if (value1.Value < value2.Value)
                    {
                        return null;
                    }
                }
                else
                {
                    if (value2.Value < value1.Value)
                    {
                        return null;
                    }
                }
                return value1 - value2;
            }
            return null;
        }

        /// <summary>
        /// 返回多个数据的乘积。如果其中一个数据为 null 则返回 null。
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int? DoMult(params int?[] values)
        {
            if (values != null && values.Length > 0)
            {
                int? value = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i].HasValue && value.HasValue)
                    {
                        value = value.Value * values[i].Value;
                    }
                    else
                    {
                        return null;
                    }
                }
                return value;
            }
            return null;
        }

        /// <summary>
        /// 返回多个数据的乘积。如果其中一个数据为 null 则返回 null。
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static decimal? DoMult(params decimal?[] values)
        {
            if (values != null && values.Length > 0)
            {
                decimal? value = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i].HasValue && value.HasValue)
                    {
                        value = value.Value * values[i].Value;
                    }
                    else
                    {
                        return null;
                    }
                }
                return value;
            }
            return null;
        }

        /// <summary>
        /// 计算两数相除的结果。如果其中一个数据为 null 或者分母等于 0 则返回 null。
        /// </summary>
        /// <param name="numerator">分子</param>
        /// <param name="denominator">分母</param>
        /// <returns></returns>
        public static decimal? DoDiv(decimal? numerator, decimal? denominator)
        {
            if (numerator != null && denominator != null && denominator != 0)
            {
                return numerator / denominator;
            }
            return null;
        }

        #endregion


        /// <summary>
        /// 根据指定的年月日参数获取整型日期。并格式化为正确的整型日期。
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>整型年月日 yyyyMMdd</returns>
        public static int DateSerial(int year, int month, int day)
        {
            if (year == 0)
            {
                return 0;
            }
            else
            {
                DateTime dtm = new DateTime();
                dtm = dtm.AddYears(year - 1);

                if (month > 0)
                {
                    dtm = dtm.AddMonths(month - 1);
                }

                if (day > 0)
                {
                    dtm = dtm.AddDays(day - 1);
                }

                int intDateNum = dtm.Year * 10000;

                if (month > 0)
                {
                    intDateNum += dtm.Month * 100;
                }

                if (day > 0)
                {
                    intDateNum += dtm.Day;
                }

                return intDateNum;
            }
        }

        /// <summary>
        /// 根据指定时分秒获取整型时间，并格式化为正确的整型时间。
        /// </summary>
        /// <param name="hour">时</param>
        /// <param name="minute">分</param>
        /// <param name="second">秒</param>
        /// <returns></returns>
        public static int TimeSerial(int hour, int minute, int second)
        {
            DateTime dtm = new DateTime();
            dtm = dtm.AddHours(hour);
            dtm = dtm.AddMinutes(minute);
            dtm = dtm.AddSeconds(second);
            return dtm.Hour * 10000 + dtm.Minute * 100 + dtm.Second;
        }

        /// <summary>
        /// 按指定日期样式将输入的整型日期、时间转为日期型日期时间
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="timeNum">6位整型时间</param>
        /// <param name="inDateStyle">输入的整型日期格式</param>
        /// <returns>日期型日期</returns>
        public static DateTime ToDateTime(int dateNum, int timeNum, DateStyle inDateStyle)
        {
            DateTime dtm = new DateTime();

            if (dateNum > 10000 && dateNum <= 99991231)
            {
                //自动判断日期类型
                if (inDateStyle == DateStyle.Automatism)
                {
                    if ((dateNum % 100) != 0)
                    {
                        inDateStyle = DateStyle.yyyyMMdd;
                    }
                    else if ((dateNum % 10000) != 0)
                    {
                        inDateStyle = DateStyle.YYYYMM00;
                    }
                    else
                    {
                        inDateStyle = DateStyle.YYYY0000;
                    }
                }

                switch (inDateStyle)
                {
                    case DateStyle.yyyyMMdd:
                        dtm = dtm.AddYears((dateNum / 10000) - 1);
                        dtm = dtm.AddMonths(((dateNum / 100) % 100) - 1);
                        dtm = dtm.AddDays((dateNum % 100) - 1);
                        break;

                    case DateStyle.YYYYMM00:
                        dtm = dtm.AddYears((dateNum / 10000) - 1);
                        dtm = dtm.AddMonths(((dateNum / 100) % 100) - 1);

                        if (dtm.Day != 0)
                        {
                            dtm = dtm.AddDays(1 - dtm.Day);
                        }
                        break;

                    case DateStyle.YYYY0000:
                        dtm = dtm.AddYears((dateNum / 10000) - 1);
                        dtm = dtm.AddMonths(((dateNum / 100) % 100) - 1);
                        dtm = dtm.AddDays((dateNum % 100) - 1);

                        if (dtm.Day != 0)
                        {
                            dtm = dtm.AddDays(1 - dtm.Day);
                        }

                        if (dtm.Month != 0)
                        {
                            dtm = dtm.AddMonths(1 - dtm.Month);
                        }
                        break;
                }
            }

            if (timeNum > 0)
            {
                dtm = dtm.AddHours(timeNum / 10000);
                dtm = dtm.AddMinutes((timeNum / 100) % 100);
                dtm = dtm.AddSeconds(timeNum % 100);
            }
            return dtm;
        }

        /// <summary>
        /// 自动判断日期样式，并将输入的整型日期、时间转为日期型日期时间
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="timeNum">6位整型时间</param>
        /// <returns></returns>
        public static DateTime ToDateTime(int dateNum, int timeNum)
        {
            return ToDateTime(dateNum, timeNum, DateStyle.Automatism);
        }

        /// <summary>
        /// 将输入的对象转为字符串。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToString(object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return "";
                }
                else if (value == null)
                {
                    return "";
                }
                else
                {
                    return Convert.ToString(value);
                }
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// 将输入的对象转为字符串并去除空格。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToStringTrim(object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return "";
                }
                else if (value == null)
                {
                    return "";
                }
                else
                {
                    return Convert.ToString(value).Replace(" ", "");
                }
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// 确保将传入的对象转为字符串，并除去两头空格。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToTrim(object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return "";
                }
                else if (value == null)
                {
                    return "";
                }
                else
                {
                    return Convert.ToString(value).Trim();
                }
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// 获取指定类型名的类型对象。
        /// </summary>
        /// <param name="typeName">类型名称，如“命名空间1.命名空间2.类名”</param>
        /// <returns>类型声明</returns>
        public static Type GetType(string typeName)
        {
            Type typ = null;
            typ = Type.GetType(typeName);

            string strNamespace = typeName;
            while (typ == null)
            {
                if (strNamespace.LastIndexOf(".") > 0)
                {
                    strNamespace = strNamespace.Substring(0, strNamespace.LastIndexOf("."));

                    typ = Type.GetType(typeName + ", " + strNamespace);
                }
                else
                {
                    break;
                }
            }
            return typ;
        }
    }
}
