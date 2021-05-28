using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core.FormatConversion
{
    public static class NumberFormatConversion
    {
        /// <summary>
        /// 确保将输入的参数转为 Integer 型数字
        /// </summary>
        /// <param name="value">-2,147,483,648 到 2,147,483,647；舍去小数部分。</param>
        /// <returns>-2,147,483,648 到 2,147,483,647 之间的数字，如果遇到异常返回“0”</returns>
        public static int ToInt(this object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return 0;
                }
                else if (value == null)
                {
                    return 0;
                }
                else
                {
                    int intValue;
                    string strValue = value.ToString();
                    if (Int32.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out intValue))
                    {
                        return intValue;
                    }
                    else
                    {
                        decimal decValue;
                        if (Decimal.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decValue))
                        {
                            return (int)decValue;
                        }
                        else if (strValue.Length > 0)
                        {
                            return Convert.ToInt32(strValue);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 将输入的参数转为 Integer 型可空数字
        /// </summary>
        /// <param name="value">-2,147,483,648 到 2,147,483,647；舍去小数部分。</param>
        /// <returns>-2,147,483,648 到 2,147,483,647 之间的数字，如果遇到异常返回“null”</returns>
        public static int? ToIntNull(this object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return null;
                }
                else if (value == null)
                {
                    return null;
                }
                else
                {
                    int intValue;
                    string strValue = value.ToString();
                    if (Int32.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out intValue))
                    {
                        return intValue;
                    }
                    else
                    {
                        decimal decValue;
                        if (Decimal.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decValue))
                        {
                            return (int)decValue;
                        }
                        else if (strValue.Length > 0)
                        {
                            return Convert.ToInt32(strValue);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 确保将输入的参数转为 Long 型数字
        /// </summary>
        /// <param name="value">-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807；舍去小数部分。</param>
        /// <returns>-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807 之间的数字，如果遇到异常返回“0”</returns>
        public static long ToLong(this object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return 0;
                }
                else if (value == null)
                {
                    return 0;
                }
                else
                {
                    long lngValue;
                    string strValue = value.ToString();
                    if (Int64.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out lngValue))
                    {
                        return lngValue;
                    }
                    else
                    {
                        decimal decValue;
                        if (Decimal.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decValue))
                        {
                            return (long)decValue;
                        }
                        else if (strValue.Length > 0)
                        {
                            return Convert.ToInt64(strValue);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 将输入的参数转为 Long 型可空数字
        /// </summary>
        /// <param name="value">-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807；舍去小数部分。</param>
        /// <returns>-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807 之间的数字，如果遇到异常返回“null”</returns>
        public static long? ToLongNull(this object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return null;
                }
                else if (value == null)
                {
                    return null;
                }
                else
                {
                    long lngValue;
                    string strValue = value.ToString();
                    if (Int64.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out lngValue))
                    {
                        return lngValue;
                    }
                    else
                    {
                        decimal decValue;
                        if (Decimal.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decValue))
                        {
                            return (long)decValue;
                        }
                        else if (strValue.Length > 0)
                        {
                            return Convert.ToInt64(strValue);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        // <summary>
        /// 确保将输入的参数转为 Decimal 型数字
        /// </summary>
        /// <param name="value">对于零变比数值，即无小数位数值，为 +/-79,228,162,514,264,337,593,543,950,335。对于具有 28 位小数位的数字，范围是 +/-7.9228162514264337593543950335。最小的可用非零数是 0.0000000000000000000000000001 (+/-1E-28)。</param>
        /// <returns>Decimal 型数字，如果遇到异常返回“0”</returns>
        public static decimal ToDecimal(this object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return 0;
                }
                else if (value == null)
                {
                    return 0;
                }
                else
                {
                    decimal decValue;
                    string strValue = value.ToString();
                    if (Decimal.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decValue))
                    {
                        return decValue;
                    }
                    else
                    {
                        if (strValue.Length > 0)
                        {
                            return Convert.ToDecimal(strValue);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 将输入的参数转为 Decimal 型可空数字
        /// </summary>
        /// <param name="value">对于零变比数值，即无小数位数值，为 +/-79,228,162,514,264,337,593,543,950,335。对于具有 28 位小数位的数字，范围是 +/-7.9228162514264337593543950335。最小的可用非零数是 0.0000000000000000000000000001 (+/-1E-28)。</param>
        /// <returns>Decimal 型数字，如果遇到异常返回“null”</returns>
        public static decimal? ToDecimalNull(this object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return null;
                }
                else if (value == null)
                {
                    return null;
                }
                else
                {
                    decimal decValue;
                    string strValue = value.ToString();
                    if (Decimal.TryParse(strValue, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decValue))
                    {
                        return decValue;
                    }
                    else
                    {
                        if (strValue.Length > 0)
                        {
                            return Convert.ToDecimal(strValue);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 判断传入的对象是否可以转为数字
        /// </summary>
        /// <param name="value">数字、字符串或任一对象</param>
        /// <returns>如果是数字返回 True，否则返回 False</returns>
        public static bool IsNumeric(this object value)
        {
            try
            {
                if (value == System.DBNull.Value)
                {
                    return false;
                }
                else if (value == null)
                {
                    return false;
                }
                else
                {
                    decimal decValue;
                    return decimal.TryParse(value.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decValue);
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 将传入的整型日期格式化为正确的整型日期。例如传入 20090431 返回 20090501
        /// </summary>
        /// <param name="dateNum"></param>
        /// <returns></returns>
        public static int DateSerial(this int dateNum)
        {
            return Function.DateSerial(dateNum / 10000, (dateNum / 100) % 100, dateNum % 100);
        }

        /// <summary>
        /// 将传入的整型时间格式化为正确的整型时间。例如传入 232860 返回 232900
        /// </summary>
        /// <param name="timeNum">整型时间</param>
        /// <returns></returns>
        public static int TimeSerial(int timeNum)
        {
            return Function.TimeSerial(timeNum / 10000, (timeNum / 100) % 100, timeNum % 100);
        }

        /// <summary>
        /// 自动判断传入的整型日期格式并转换为 yyyyMMdd 格式的整型日期
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <returns></returns>
        public static int ToIntDate(this int dateNum)
        {
            if ((dateNum % 100) != 0)
            {
                return ToIntDate(dateNum, DateStyle.yyyyMMdd, DateStyle.yyyyMMdd);
            }
            else if ((dateNum % 10000) != 0)
            {
                return ToIntDate(dateNum, DateStyle.YYYYMM00, DateStyle.yyyyMMdd);
            }
            else
            {
                return ToIntDate(dateNum, DateStyle.YYYY0000, DateStyle.yyyyMMdd);
            }
        }

        /// <summary>
        /// 指定传入的整型日期格式并转为 yyyyMMdd 格式的日期
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="inDateStyle">输入的整型日期格式</param>
        /// <returns></returns>
        public static int ToIntDate(this int dateNum, DateStyle inDateStyle)
        {
            return ToIntDate(dateNum, inDateStyle, DateStyle.yyyyMMdd);
        }

        /// <summary>
        /// 将传入的指定格式的整型日期转为指定格式的整型日期
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="inDateStyle">输入的整型日期格式</param>
        /// <param name="outDateStyle">希望输出的日期格式</param>
        /// <returns></returns>
        public static int ToIntDate(this int dateNum, DateStyle inDateStyle, DateStyle outDateStyle)
        {
            DateTime dtm = Function.ToDateTime(dateNum, 0, inDateStyle);

            int intDateValue = 0;

            switch (outDateStyle)
            {
                case DateStyle.yyyyMMdd:
                    intDateValue = dtm.Year * 10000 + dtm.Month * 100 + dtm.Day;
                    break;

                case DateStyle.YYYYMM00:
                    intDateValue = dtm.Year * 10000 + dtm.Month * 100;
                    break;

                case DateStyle.YYYY0000:
                    intDateValue = dtm.Year * 10000;
                    break;
            }

            return intDateValue;
        }

        /// <summary>
        /// 按指定日期样式将输入的整型日期转为日期型日期
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this int dateNum)
        {
            return Function.ToDateTime(dateNum, 0, DateStyle.Automatism);
        }

        public static DateTime ToDateTime(this long datetimeNum)
        {
            return Function.ToDateTime((int)(datetimeNum / 1000000), (int)(datetimeNum % 1000000));
        }

        // <summary>
        /// 按指定日期样式将输入的整型日期转为日期型日期
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="inDateStyle">输入的整型日期格式</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this int dateNum, DateStyle inDateStyle)
        {
            return Function.ToDateTime(dateNum, 0, inDateStyle);
        }

        /// <summary>
        /// 将小于10的数字加上前缀“0”，用于“OutDateTime”函数输出时间时使用
        /// </summary>
        /// <param name="num">数字</param>
        /// <returns></returns>
        public static string OutDateTimeNum(this int num)
        {
            if (num < 10)
            {
                return "0" + num;
            }
            else
            {
                return num.ToString();
            }

        }

        /// <summary>
        /// 获得传入的整型日期是该年中的第几周
        /// </summary>
        /// <param name="dateNum">需要计算周数的整型日期</param>
        /// <returns>该日期是该年度中的第几周</returns>
        public static int GetWeekOfYear(this int dateNum)
        {
            DateTime dtm = new DateTime();
            dtm = dtm.AddYears((dateNum / 10000) - 1);
            dtm = dtm.AddMonths(((dateNum / 100) % 100) - 1);
            dtm = dtm.AddDays((dateNum % 100) - 1);
            return dtm.GetWeekOfYear();
        }


        /// <summary>
        /// 将传入的数字星期转为汉字星期描述。“0”代表星期日，“6”代表星期六
        /// </summary>
        /// <param name="weekday">星期的数字描述</param>
        /// <returns>汉字的星期描述</returns>
        public static string GetWeekdayName(this int weekday)
        {
            return ((System.DayOfWeek)weekday).GetWeekdayName();
        }

        /// <summary>
        /// 显示秒数
        /// </summary>
        /// <param name="secord"></param>
        /// <returns></returns>
        public static string OutSecord(this int secord)
        {
            if (secord < 60)
            {
                return secord + "秒";
            }
            if (secord < 3600)
            {
                return (secord / 60) + "分钟" + (secord % 60) + "秒";
            }
            if (secord < 86400)
            {
                return (secord / 3600) + "小时" + ((secord / 60) % 60) + "分钟";
            }
            else
            {
                return (secord / 86400) + "天" + ((secord / 3600) % 24) + "小时";
            }
        }

        /// <summary>
        /// 将输入的数字转为汉字数字描述
        /// </summary>
        /// <param name="value"></param>
        /// <param name="characterStyle">数字转为汉字后的样式</param>
        /// <returns></returns>
        public static string ToCharacter(this int value, CharacterStyle characterStyle)
        {
            return value.ToString().ToCharacter(characterStyle);
        }


    }
}
