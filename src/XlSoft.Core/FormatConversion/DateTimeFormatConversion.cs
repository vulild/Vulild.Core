using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core.FormatConversion
{
    /// <summary>
    /// 系统内的日期格式
    /// </summary>
    public enum DateStyle
    {
        /// <summary>
        /// 自动识别该日期格式
        /// </summary>
        Automatism = 0,

        /// <summary>
        /// 4位年，2位月，2位日。例如：20010310（2001年3月10日）
        /// </summary>
        yyyyMMdd = 1,

        /// <summary>
        /// 4位年，2位月，2位零。例如：20010300（2001年3月）
        /// </summary>
        YYYYMM00 = 2,

        /// <summary>
        /// 4位年，4位零。例如：20010000（2001年）
        /// </summary>
        YYYY0000 = 5
    }

    /// <summary>
    /// 输出的日期样式
    /// </summary>
    public enum OutDateStyle
    {
        /// <summary>
        /// 输出样式：YYYY-MM-DD
        /// </summary>
        /// <remarks></remarks>
        YMD_Sign,
        /// <summary>
        /// 输出样式：YYYY年MM月DD日
        /// </summary>
        /// <remarks></remarks>
        YMD_Num,
        /// <summary>
        /// 输出样式：ＹＹＹＹ年ＭＭ月ＤＤ日 （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        YMD_Char,

        /// <summary>
        /// 输出样式：YY-MM-DD
        /// </summary>
        YMD_ShortSign,
        /// <summary>
        /// 输出样式：YY年MM月DD日
        /// </summary>
        YMD_ShortNum,

        /// <summary>
        /// 输出样式：YYYY年MM月DD日 星期Ｗ （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        YMDW_Num,
        /// <summary>
        /// 输出样式：ＹＹＹＹ年ＭＭ月ＤＤ日 星期Ｗ （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        YMDW_Char,

        /// <summary>
        /// 输出样式：YYYY年 第N周
        /// </summary>
        /// <remarks></remarks>
        YW_Num,
        /// <summary>
        /// 输出样式：ＹＹＹＹ年 第Ｎ周 （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        YW_Char,

        /// <summary>
        /// 输出样式：YYYY年 第N周(MM月DD日 - MM月DD日)
        /// </summary>
        /// <remarks></remarks>
        YWmd_Num,
        /// <summary>
        /// 输出样式：ＹＹＹＹ年 第Ｎ周(MM月DD日 - MM月DD日) （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        YWmd_Char,

        /// <summary>
        /// 输出样式：YYYY-MM
        /// </summary>
        /// <remarks></remarks>
        YM_Sign,
        /// <summary>
        /// 输出样式：YYYY年MM月
        /// </summary>
        /// <remarks></remarks>
        YM_Num,
        /// <summary>
        /// 输出样式：ＹＹＹＹ年ＭＭ月 （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        YM_Char,

        /// <summary>
        /// 输出样式：YYYY年 第Q季度
        /// </summary>
        /// <remarks></remarks>
        YQ_Num,
        /// <summary>
        /// 输出样式：ＹＹＹＹ年 第Ｑ季度 （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        YQ_Char,

        /// <summary>
        /// 输出样式：YYYY年
        /// </summary>
        /// <remarks></remarks>
        Y_Num,
        /// <summary>
        /// 输出样式：ＹＹＹＹ年 （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        Y_Char,

        /// <summary>
        /// 输出样式：MM月DD日
        /// </summary>
        /// <remarks></remarks>
        MD_Num,
        /// <summary>
        /// 输出样式：ＭＭ月ＤＤ日 （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        MD_Char,

        /// <summary>
        /// 输出样式：星期Ｗ （其中全角的字母表示汉字文字的数字）
        /// </summary>
        /// <remarks></remarks>
        W_Char,
    }

    /// <summary>
    /// 输出的时间样式
    /// </summary>
    public enum OutTimeStyle
    {
        /// <summary>
        /// 输出样式：HH:MM:SS
        /// </summary>
        HMS_Sign = 1,

        /// <summary>
        /// 输出样式：HH时MM分SS秒
        /// </summary>
        HMS_Num = 2,

        /// <summary>
        /// 输出样式： ＨＨ时ＭＭ分ＳＳ秒
        /// </summary>
        HMS_Char = 3,

        /// <summary>
        /// 输出样式：AM/PM HH:MM:SS
        /// </summary>
        THMS_Sign = 4,

        /// <summary>
        /// 输出样式：AM/PM HH时MM分SS秒
        /// </summary>
        THMS_Num = 5,

        /// <summary>
        /// 输出样式：上午/下午 ＨＨ时ＭＭ分ＳＳ秒
        /// </summary>
        THMS_Char = 6,

        /// <summary>
        /// 输出样式：HH:MM
        /// </summary>
        HM_Sign = 7,

        /// <summary>
        /// 输出样式：HH时MM分
        /// </summary>
        HM_Num = 8,

        /// <summary>
        /// 输出样式：ＨＨ时ＭＭ分
        /// </summary>
        HM_Char = 9,

        /// <summary>
        /// 输出样式：AM/PM HH:MM
        /// </summary>
        THM_Sign = 10,

        /// <summary>
        /// 输出样式：AM/PM HH时MM分
        /// </summary>
        THM_Num = 11,

        /// <summary>
        /// 输出样式：上午/下午 ＨＨ时ＭＭ分
        /// </summary>
        THM_Char = 12,

        /// <summary>
        /// 输出样式：HH时
        /// </summary>
        H_Num = 13,

        /// <summary>
        /// 输出样式：ＨＨ时
        /// </summary>
        H_Char = 14,

        /// <summary>
        /// 输出样式：AM/PM HH时
        /// </summary>
        TH_Num = 15,

        /// <summary>
        /// 输出样式：上午/下午 ＨＨ时
        /// </summary>
        TH_Char = 16,
    }

    /// <summary>
    /// 指示在调用与日期相关的函数时如何确定日期间隔和设置日期间隔的格式。
    /// </summary>
    public enum DateInterval
    {
        /// <summary>
        /// 秒
        /// </summary>
        Second,

        /// <summary>
        /// 分钟
        /// </summary>
        Minute,

        /// <summary>
        /// 小时
        /// </summary>
        Hour,

        /// <summary>
        /// 天
        /// </summary>
        Day,

        /// <summary>
        /// 星期
        /// </summary>
        Weekday,

        /// <summary>
        /// 月
        /// </summary>
        Month,

        /// <summary>
        /// 季度
        /// </summary>
        Season,

        /// <summary>
        /// 年
        /// </summary>
        Year
    }

    /// <summary>
    /// 表示 8 位整型日期和 6 位整型时间的结构
    /// </summary>
    public struct IntDateTime
    {
        private int m_DateNum;
        /// <summary>
        /// 8位的整型日期
        /// </summary>
        public int DateNum
        {
            get { return m_DateNum; }
            set { m_DateNum = value; }
        }

        private int m_TimeNum;
        /// <summary>
        /// 6位的整型时间
        /// </summary>
        public int TimeNum
        {
            get { return m_TimeNum; }
            set { m_TimeNum = value; }
        }
    }
    public static class DateTimeFormatConversion
    {
        /// <summary>
        /// 将输入的可空日期转换为可空的整型日期(yyyyMMdd)。
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int? ToIntDateNull(this DateTime? date)
        {
            if (date == null)
            {
                return null;
            }
            else
            {
                return date.Value.Year * 10000 + date.Value.Month * 100 + date.Value.Day;
            }
        }

        /// <summary>
        /// 将输入的可空时间转为可空的整型时间(HHmmss)。
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int? ToIntTimeNull(this DateTime? time)
        {
            if (time == null)
            {
                return null;
            }
            else
            {
                return time.Value.Hour * 10000 + time.Value.Minute * 100 + time.Value.Second;
            }
        }


        /// <summary>
        /// 获取系统整型时间值
        /// </summary>
        /// <returns></returns>
        public static int ToIntTime(this DateTime time)
        {
            return time.Hour * 10000 + time.Minute * 100 + time.Second;
        }

        /// <summary>
        /// 将传入的日期转为 yyyyMMdd 格式的整型日期。函数将自动判断传入的参数是日期型还是 8 位整型日期。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToIntDate(object value)
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
                else if (value.IsNumeric())                                           //尝试转为数字型
                {
                    return ToIntDate(Convert.ToInt32(value));
                }
                else
                {                                                               //尝试转为日期型
                    DateTime dtmValue = Convert.ToDateTime(value);
                    return ToIntDate(dtmValue, DateStyle.yyyyMMdd);
                }
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 将传入的日期转为 yyyyMMdd 格式的整型日期
        /// </summary>
        /// <param name="dateTime">DateTime 型的日期</param>
        /// <returns></returns>
        public static int ToIntDate(this DateTime dateTime)
        {
            return (dateTime.Year * 10000 + dateTime.Month * 100 + dateTime.Day).ToIntDate(DateStyle.yyyyMMdd, DateStyle.yyyyMMdd);
        }

        /// <summary>
        /// 将传入的日期转为指定格式的整型日期
        /// </summary>
        /// <param name="dateTime">DateTime 型日期时间</param>
        /// <param name="outDateStyle">希望输出的日期格式</param>
        /// <returns></returns>
        public static int ToIntDate(this DateTime dateTime, DateStyle outDateStyle)
        {
            return (dateTime.Year * 10000 + dateTime.Month * 100 + dateTime.Day).ToIntDate(DateStyle.yyyyMMdd, outDateStyle);
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的日期字符串
        /// </summary>
        /// <param name="dateTime">需要输出的日期型日期和时间</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <returns>适合页面显示的日期字符串</returns>
        public static string OutDateTime(DateTime dateTime, OutDateStyle outDateStyle)
        {
            return OutDateTime(ToIntDate(dateTime), DateStyle.yyyyMMdd, outDateStyle, null, null, "", "", "");
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的日期字符串
        /// </summary>
        /// <param name="dateTime">需要输出的日期型日期和时间</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <returns>适合页面显示的日期字符串</returns>
        public static string OutDateTime(DateTime dateTime, OutDateStyle outDateStyle, string replaceNull)
        {
            return OutDateTime(ToIntDate(dateTime), DateStyle.yyyyMMdd, outDateStyle, null, null, replaceNull, "", "");
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的日期字符串
        /// </summary>
        /// <param name="dateTime">需要输出的日期型日期和时间</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <param name="prefix">前缀</param>
        /// <param name="postfix">后缀</param>
        /// <returns>适合页面显示的日期字符串</returns>
        public static string OutDateTime(DateTime dateTime, OutDateStyle outDateStyle, string replaceNull, string prefix, string postfix)
        {
            return OutDateTime(ToIntDate(dateTime), DateStyle.yyyyMMdd, outDateStyle, null, null, replaceNull, prefix, postfix);
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的时间字符串
        /// </summary>
        /// <param name="dateTime">需要输出的日期型日期和时间</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <returns>适合页面显示的时间字符串</returns>
        public static string OutDateTime(DateTime dateTime, OutTimeStyle outTimeStyle)
        {
            return OutDateTime(null, null, null, ToIntTime(dateTime), outTimeStyle, "", "", "");
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的时间字符串
        /// </summary>
        /// <param name="dateTime">需要输出的日期型日期和时间</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <returns>适合页面显示的时间字符串</returns>
        public static string OutDateTime(DateTime dateTime, OutTimeStyle outTimeStyle, string replaceNull)
        {
            return OutDateTime(null, null, null, ToIntTime(dateTime), outTimeStyle, replaceNull, "", "");
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的时间字符串
        /// </summary>
        /// <param name="dateTime">需要输出的日期型日期和时间</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <param name="prefix">前缀</param>
        /// <param name="postfix">后缀</param>
        /// <returns>适合页面显示的时间字符串</returns>
        public static string OutDateTime(DateTime dateTime, OutTimeStyle outTimeStyle, string replaceNull, string prefix, string postfix)
        {
            return OutDateTime(null, null, null, ToIntTime(dateTime), outTimeStyle, replaceNull, prefix, postfix);
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的日期、时间字符串
        /// </summary>
        /// <param name="dateTime">需要输出的日期型日期和时间</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <returns>适合页面显示的日期时间字符串</returns>
        public static string OutDateTime(DateTime dateTime, OutDateStyle outDateStyle, OutTimeStyle outTimeStyle)
        {
            return OutDateTime(ToIntDate(dateTime), DateStyle.yyyyMMdd, outDateStyle, ToIntTime(dateTime), outTimeStyle, "", "", "");
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的日期、时间字符串
        /// </summary>
        /// <param name="dateTime">需要输出的日期型日期和时间</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <returns>适合页面显示的日期时间字符串</returns>
        public static string OutDateTime(DateTime dateTime, OutDateStyle outDateStyle, OutTimeStyle outTimeStyle, string replaceNull)
        {
            return OutDateTime(ToIntDate(dateTime), DateStyle.yyyyMMdd, outDateStyle, ToIntTime(dateTime), outTimeStyle, replaceNull, "", "");
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的日期、时间字符串
        /// </summary>
        /// <param name="dateTime">需要输出的日期型日期和时间</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <param name="prefix">前缀</param>
        /// <param name="postfix">后缀</param>
        /// <returns>适合页面显示的日期时间字符串</returns>
        public static string OutDateTime(DateTime dateTime, OutDateStyle outDateStyle, OutTimeStyle outTimeStyle, string replaceNull, string prefix, string postfix)
        {
            return OutDateTime(ToIntDate(dateTime), DateStyle.yyyyMMdd, outDateStyle, ToIntTime(dateTime), outTimeStyle, replaceNull, prefix, postfix);
        }


        /// <summary>
        /// 将输入的日期按指定格式转换为适合页面显示的日期字符串
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="inDateStyle">输入的日期格式</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <returns>适合页面显示的日期字符串</returns>
        public static string OutDateTime(object dateNum, DateStyle inDateStyle, OutDateStyle outDateStyle)
        {
            return OutDateTime(dateNum, inDateStyle, outDateStyle, null, null, "", "", "");
        }

        /// <summary>
        /// 将输入的日期按指定格式转换为适合页面显示的日期字符串
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="inDateStyle">输入的日期格式</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <returns>适合页面显示的日期字符串</returns>
        public static string OutDateTime(object dateNum, DateStyle inDateStyle, OutDateStyle outDateStyle, string replaceNull)
        {
            return OutDateTime(dateNum, inDateStyle, outDateStyle, null, null, replaceNull, "", "");
        }

        /// <summary>
        /// 将输入的日期按指定格式转换为适合页面显示的日期字符串
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="inDateStyle">输入的日期格式</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <param name="prefix">前缀</param>
        /// <param name="postfix">后缀</param>
        /// <returns>适合页面显示的日期字符串</returns>
        public static string OutDateTime(object dateNum, DateStyle inDateStyle, OutDateStyle outDateStyle, string replaceNull, string prefix, string postfix)
        {
            return OutDateTime(dateNum, inDateStyle, outDateStyle, null, null, replaceNull, prefix, postfix);
        }

        /// <summary>
        /// 将输入的时间按指定格式转换为适合页面显示的时间字符串
        /// </summary>
        /// <param name="timeNum">6位整型时间</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <returns></returns>
        public static string OutDateTime(object timeNum, OutTimeStyle outTimeStyle)
        {
            return OutDateTime(null, null, null, timeNum, outTimeStyle, "", "", "");
        }

        /// <summary>
        /// 将输入的时间按指定格式转换为适合页面显示的时间字符串
        /// </summary>
        /// <param name="timeNum">6位整型时间</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <returns>适合页面显示的时间字符串</returns>
        public static string OutDateTime(object timeNum, OutTimeStyle outTimeStyle, string replaceNull)
        {
            return OutDateTime(null, null, null, timeNum, outTimeStyle, replaceNull, "", "");
        }

        /// <summary>
        /// 将输入的时间按指定格式转换为适合页面显示的时间字符串
        /// </summary>
        /// <param name="timeNum">6位整型时间</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <param name="prefix">前缀</param>
        /// <param name="postfix">后缀</param>
        /// <returns>适合页面显示的时间字符串</returns>
        public static string OutDateTime(object timeNum, OutTimeStyle outTimeStyle, string replaceNull, string prefix, string postfix)
        {
            return OutDateTime(null, null, null, timeNum, outTimeStyle, replaceNull, prefix, postfix);
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的日期、时间字符串
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="inDateStyle">输入的日期格式</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="timeNum">6位整型时间</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <returns>适合页面显示的日期时间字符串</returns>
        public static string OutDateTime(object dateNum, DateStyle inDateStyle, OutDateStyle outDateStyle, object timeNum, OutTimeStyle outTimeStyle)
        {
            return OutDateTime(dateNum, inDateStyle, outDateStyle, timeNum, outTimeStyle, "", "", "");
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的日期、时间字符串
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="inDateStyle">输入的日期格式</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="timeNum">6位整型时间</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <param name="replaceNull">如果传入的参数为空是返回的值</param>
        /// <returns>适合页面显示的日期时间字符串</returns>
        public static string OutDateTime(object dateNum, DateStyle? inDateStyle, OutDateStyle? outDateStyle, object timeNum, OutTimeStyle? outTimeStyle, string replaceNull)
        {
            return OutDateTime(dateNum, inDateStyle, outDateStyle, timeNum, outTimeStyle, replaceNull, "", "");
        }

        /// <summary>
        /// 将输入的日期、时间按指定格式转换为适合页面显示的日期、时间字符串
        /// </summary>
        /// <param name="dateNum">8位整型日期</param>
        /// <param name="inDateStyle">输入的日期格式</param>
        /// <param name="outDateStyle">输出的日期样式</param>
        /// <param name="timeNum">6位整型时间</param>
        /// <param name="outTimeStyle">输出的时间样式</param>
        /// <param name="replaceNull">如果传入的参数为空时返回的值</param>
        /// <param name="prefix">前缀</param>
        /// <param name="postfix">后缀</param>
        /// <returns>适合页面显示的日期时间字符串</returns>
        public static string OutDateTime(this object dateNum, DateStyle? inDateStyle, OutDateStyle? outDateStyle, object timeNum, OutTimeStyle? outTimeStyle, string replaceNull, string prefix, string postfix)
        {
            try
            {
                string strValue = "";

                if (dateNum != System.DBNull.Value && dateNum != null && outDateStyle != null)
                {
                    if (null == inDateStyle)
                    {
                        inDateStyle = DateStyle.Automatism;
                    }
                    DateTime dtm = ((int)dateNum).ToDateTime((DateStyle)inDateStyle);

                    switch (outDateStyle)
                    {
                        case OutDateStyle.YMD_Sign:
                            strValue += dtm.Year + "-" + dtm.Month.OutDateTimeNum() + "-" + dtm.Day.OutDateTimeNum();
                            break;

                        case OutDateStyle.YMD_Num:
                            strValue += dtm.Year + "年" + dtm.Month + "月" + dtm.Day + "日";
                            break;

                        case OutDateStyle.YMD_Char:
                            strValue += dtm.Year.ToCharacter(CharacterStyle.Character) + "年" + dtm.Month.ToCharacter(CharacterStyle.Character) + "月" + dtm.Day.ToCharacter(CharacterStyle.Character) + "日";
                            break;

                        case OutDateStyle.YMD_ShortSign:
                            strValue += dtm.ToString("yy-MM-dd");
                            break;

                        case OutDateStyle.YMD_ShortNum:
                            strValue += dtm.ToString("yy年MM月dd日");
                            break;

                        case OutDateStyle.YMDW_Num:
                            strValue += dtm.Year + "年" + dtm.Month + "月" + dtm.Day + "日 " + GetWeekdayName(dtm.DayOfWeek);
                            break;

                        case OutDateStyle.YMDW_Char:
                            strValue += dtm.Year.ToCharacter(CharacterStyle.Character) + "年" + dtm.Month.ToCharacter(CharacterStyle.Character) + "月" + dtm.Day.ToCharacter(CharacterStyle.Character) + "日 " + dtm.DayOfWeek.GetWeekdayName();
                            break;

                        case OutDateStyle.YW_Num:
                            strValue += dtm.Year.ToCharacter(CharacterStyle.Character) + "年 第" + dtm.GetWeekOfYear().ToCharacter(CharacterStyle.Character) + "周";
                            break;

                        case OutDateStyle.YW_Char:
                            strValue += dtm.Year.ToCharacter(CharacterStyle.Character) + "年 第" + dtm.GetWeekOfYear().ToCharacter(CharacterStyle.Character) + "周";
                            break;

                        case OutDateStyle.YWmd_Num:
                            DateTime dtmYWmd_Num = dtm.AddDays(-(int)dtm.DayOfWeek);
                            strValue += dtmYWmd_Num.Year + "年 第" + GetWeekOfYear(dtmYWmd_Num) + "周 (" + dtmYWmd_Num.Month + "月" + dtmYWmd_Num.Day + "日－" + dtmYWmd_Num.AddDays(6).Month + "月" + dtmYWmd_Num.AddDays(6).Day + "日)";
                            break;

                        case OutDateStyle.YWmd_Char:
                            DateTime dtmYWmd_Char = dtm.AddDays(-(int)dtm.DayOfWeek);
                            strValue += dtmYWmd_Char.Year.ToCharacter(CharacterStyle.Character) + "年 第" + dtmYWmd_Char.GetWeekOfYear().ToCharacter(CharacterStyle.Character) + "周 (" + dtmYWmd_Char.Month + "月" + dtmYWmd_Char.Day + "日－" + dtmYWmd_Char.AddDays(6).Month + "月" + dtmYWmd_Char.AddDays(6).Day + "日)";
                            break;

                        case OutDateStyle.YM_Sign:
                            strValue += dtm.Year + "-" + dtm.Month.OutDateTimeNum();
                            break;

                        case OutDateStyle.YM_Num:
                            strValue += dtm.Year + "年" + dtm.Month + "月";
                            break;

                        case OutDateStyle.YM_Char:
                            strValue += dtm.Year.ToCharacter(CharacterStyle.Character) + "年" + dtm.GetWeekOfYear().ToCharacter(CharacterStyle.Character) + "月";
                            break;

                        case OutDateStyle.YQ_Num:
                            strValue += dtm.Year + "年 第" + ((dtm.Month + 2) / 3) + "季度";
                            break;

                        case OutDateStyle.YQ_Char:
                            strValue += dtm.Year.ToCharacter(CharacterStyle.Character) + "年 第" + ((dtm.Month + 2) / 3).ToCharacter(CharacterStyle.Character) + "季度";
                            break;

                        case OutDateStyle.Y_Num:
                            strValue += dtm.Year + "年";
                            break;

                        case OutDateStyle.Y_Char:
                            strValue += dtm.Year.ToCharacter(CharacterStyle.Character) + "年";
                            break;

                        case OutDateStyle.MD_Num:
                            strValue += dtm.Month + "月" + dtm.Day + "日";
                            break;

                        case OutDateStyle.MD_Char:
                            strValue += dtm.GetWeekOfYear().ToCharacter(CharacterStyle.Character) + "月" + dtm.Day.ToCharacter(CharacterStyle.Character) + "日";
                            break;

                        case OutDateStyle.W_Char:
                            strValue += GetWeekdayName(dtm.DayOfWeek);
                            break;
                    }
                }

                if (null != outDateStyle && null != outTimeStyle)
                {
                    if (null == dateNum && null == timeNum)
                    {
                        return replaceNull;
                    }

                    if (null != dateNum && null != timeNum)
                    {
                        strValue += " ";
                    }
                }

                if (null != timeNum && null != outTimeStyle)
                {
                    DateTime dtm = Function.ToDateTime(0, timeNum.ToInt());

                    switch (outTimeStyle)
                    {
                        case OutTimeStyle.HMS_Sign:
                            strValue += dtm.Hour.OutDateTimeNum() + ":" + dtm.Minute.OutDateTimeNum() + ":" + dtm.Second.OutDateTimeNum();
                            break;

                        case OutTimeStyle.HMS_Num:
                            strValue += dtm.Hour + "时" + dtm.Minute.OutDateTimeNum() + "分" + dtm.Second.OutDateTimeNum() + "秒";
                            break;

                        case OutTimeStyle.HMS_Char:
                            strValue += dtm.Hour.ToCharacter(CharacterStyle.Character) + "时" + dtm.Minute.ToCharacter(CharacterStyle.Character) + "分" + dtm.Second.ToCharacter(CharacterStyle.Character) + "秒";
                            break;

                        case OutTimeStyle.THMS_Sign:
                            if ((dtm.Hour) < 12)
                            {
                                strValue += "AM ";
                            }
                            else
                            {
                                strValue += "PM ";
                            }
                            strValue += (dtm.Hour % 12) + ":" + dtm.Minute.OutDateTimeNum() + ":" + dtm.Second.OutDateTimeNum();
                            break;

                        case OutTimeStyle.THMS_Num:
                            if ((dtm.Hour) < 12)
                            {
                                strValue += "上午 ";
                            }
                            else
                            {
                                strValue += "下午 ";
                            }
                            strValue += (dtm.Hour % 12) + "时" + dtm.Minute.OutDateTimeNum() + "分" + dtm.Second.OutDateTimeNum() + "秒";
                            break;

                        case OutTimeStyle.THMS_Char:
                            if ((dtm.Hour) < 12)
                            {
                                strValue += "上午 ";
                            }
                            else
                            {
                                strValue += "下午 ";
                            }
                            strValue += (dtm.Hour % 12).ToCharacter(CharacterStyle.Character) + "时" + dtm.Minute.ToCharacter(CharacterStyle.Character) + "分" + dtm.Second.ToCharacter(CharacterStyle.Character) + "秒";
                            break;

                        case OutTimeStyle.HM_Sign:
                            strValue += dtm.Hour.OutDateTimeNum() + ":" + dtm.Minute.OutDateTimeNum();
                            break;

                        case OutTimeStyle.HM_Num:
                            strValue += dtm.Hour + "时" + dtm.Minute.OutDateTimeNum() + "分";
                            break;

                        case OutTimeStyle.HM_Char:
                            strValue += dtm.Hour.ToCharacter(CharacterStyle.Character) + "时" + dtm.Minute.ToCharacter(CharacterStyle.Character) + "分";
                            break;

                        case OutTimeStyle.THM_Sign:
                            if ((dtm.Hour) < 12)
                            {
                                strValue += "AM ";
                            }
                            else
                            {
                                strValue += "PM ";
                            }
                            strValue += (dtm.Hour % 12) + ":" + dtm.Minute.OutDateTimeNum();
                            break;

                        case OutTimeStyle.THM_Num:
                            if ((dtm.Hour) < 12)
                            {
                                strValue += "上午 ";
                            }
                            else
                            {
                                strValue += "下午 ";
                            }
                            strValue += (dtm.Hour % 12) + "时" + dtm.Minute.OutDateTimeNum() + "分";
                            break;

                        case OutTimeStyle.THM_Char:
                            if ((dtm.Hour) < 12)
                            {
                                strValue += "上午 ";
                            }
                            else
                            {
                                strValue += "下午 ";
                            }
                            strValue += (dtm.Hour % 12).ToCharacter(CharacterStyle.Character) + "时" + dtm.Minute.ToCharacter(CharacterStyle.Character) + "分";
                            break;

                        case OutTimeStyle.H_Num:
                            strValue += dtm.Hour + "时";
                            break;

                        case OutTimeStyle.H_Char:
                            strValue += dtm.Hour.ToCharacter(CharacterStyle.Character) + "时";
                            break;

                        case OutTimeStyle.TH_Num:
                            if ((dtm.Hour) < 12)
                            {
                                strValue += "上午 ";
                            }
                            else
                            {
                                strValue += "下午 ";
                            }
                            strValue += (dtm.Hour % 12) + "时";
                            break;

                        case OutTimeStyle.TH_Char:
                            if ((dtm.Hour) < 12)
                            {
                                strValue += "上午 ";
                            }
                            else
                            {
                                strValue += "下午 ";
                            }
                            strValue += (dtm.Hour % 12).ToCharacter(CharacterStyle.Character) + "时";
                            break;
                    }
                }

                return prefix + strValue + postfix;
            }
            catch
            {
                return replaceNull;
            }
        }

        /// <summary>
        /// 获得传入的日期是该年中的第几周
        /// </summary>
        /// <param name="dateTime">需要计算周数的日期</param>
        /// <returns>该日期是该年度中的第几周</returns>
        public static int GetWeekOfYear(this DateTime dateTime)
        {
            DateTime dtm = new DateTime(dateTime.Year, 1, 1);                                                //该年度1月1日的日期
            int intFirstDayOfWeek = (int)dtm.DayOfWeek;                                             //1月1日距周的起始日相差几天
            dtm = dtm.AddDays(-intFirstDayOfWeek);                                                  //将日期改变成1月1日所在周的起始日的日期
            return ((dateTime.Subtract(dtm).Days) / 7) + 1;
        }


        /// <summary>
        /// 将传入的 DayOfWeek 行星期转为汉字星期描述
        /// </summary>
        /// <param name="weekday">DayOfWeek 的星期枚举</param>
        /// <returns>汉字的星期描述</returns>
        public static string GetWeekdayName(this System.DayOfWeek weekday)
        {
            switch (weekday)
            {
                case DayOfWeek.Monday:
                    return "星期一";
                case DayOfWeek.Tuesday:
                    return "星期二";
                case DayOfWeek.Wednesday:
                    return "星期三";
                case DayOfWeek.Thursday:
                    return "星期四";
                case DayOfWeek.Friday:
                    return "星期五";
                case DayOfWeek.Saturday:
                    return "星期六";
                default:
                    return "星期日";
            }
        }

    }
}
