using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core
{
    public static class RandomUtil
    {
        private static Random ran;

        /// <summary>
        /// 获得一个非负随机数。
        /// </summary>
        /// <returns>产生的整型随机数</returns>
        public static int GetRnd()
        {
            if (ran == null)
            {
                ran = new Random();
            }
            return ran.Next();
        }

        /// <summary>
        /// 获得指定范围的随机数。
        /// </summary>
        /// <param name="minValue">随机数的下限（最小值）</param>
        /// <param name="maxValue">随机数的上限（最大值）</param>
        /// <returns>产生的整型随机数</returns>
        public static int GetRnd(int minValue, int maxValue)
        {
            if (ran == null)
            {
                ran = new Random();
            }
            return ran.Next(minValue, maxValue);
        }

        /// <summary>
        /// 获得随机字符串。
        /// </summary>
        /// <param name="enabledNumeric">产生的随机字符串中是否允许包含数字</param>
        /// <param name="enabledCapital">产生的随机字符串中是否允许包含大写字母</param>
        /// <param name="enabledLowercase">产生的随机字符串中是否允许包含小写字母</param>
        /// <param name="enabledInterpunction">产生的随机字符串中是否允许包含符号</param>
        /// <param name="length">需要产生的字符串的长度</param>
        /// <returns></returns>
        public static string GetRnd(bool enabledNumeric, bool enabledCapital, bool enabledLowercase, bool enabledInterpunction, int length)
        {
            if (enabledNumeric == false && enabledCapital == false && enabledLowercase == false && enabledInterpunction == false)
            {
                throw new Exception("输出的字符串至少需要包含一种格式的字符");
            }

            if (length < 1)
            {
                throw new Exception("输出的字符串长度不能小于 1");
            }

            List<char> lstChar = new List<char>();
            if (enabledNumeric)
            {
                lstChar.AddRange(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            }

            if (enabledCapital)
            {
                lstChar.AddRange(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' });
            }

            if (enabledLowercase)
            {
                lstChar.AddRange(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });
            }

            if (enabledInterpunction)
            {
                lstChar.AddRange(new char[] { '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', '\\', '|', ';', ':', '\'', '"', ',', '.', '<', '>', '/', '?' });
            }

            string strRnd = "";
            if (ran == null)
            {
                ran = new Random();
            }

            for (int intIndex = 0; intIndex < length; intIndex++)
            {
                strRnd += lstChar[ran.Next(0, lstChar.Count - 1)];
            }

            return strRnd;
        }
    }
}
