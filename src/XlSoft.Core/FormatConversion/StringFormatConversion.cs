using System;
using System.Collections.Generic;
using System.Text;

namespace Vulild.Core.FormatConversion
{
    /// <summary>
    /// 数字转为汉字后的样式
    /// </summary>
    public enum CharacterStyle
    {
        /// <summary>
        /// 汉字的“一二三”
        /// </summary>
        Character = 0,

        /// <summary>
        /// 大写的“壹贰叁”
        /// </summary>
        Capitalization = 1
    }
    public static class StringFormatConversion
    {
        // <summary>
        /// 将输入的数字转为汉字数字描述
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToCharacter(this string value)
        {
            return ToCharacter(value, CharacterStyle.Character);
        }

        /// <summary>
        /// 将输入的数字转为汉字数字描述
        /// </summary>
        /// <param name="value">欲转换的数字</param>
        /// <param name="characterStyle">数字转为汉字后的样式</param>
        /// <returns></returns>
        public static string ToCharacter(this object value, CharacterStyle characterStyle)
        {
            if (value.IsNumeric())
            {
                string strValue = "";
                string[] strChar = new string[0];

                switch (characterStyle)
                {
                    case CharacterStyle.Character:
                        strChar = new string[] { "○", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
                        break;
                    case CharacterStyle.Capitalization:
                        strChar = new string[] { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };
                        break;
                }

                foreach (System.Char chrValue in (string)value)
                {
                    if (chrValue == 45)
                    {
                        strValue += "负";
                    }
                    else if (chrValue == 46)
                    {
                        strValue += "点";
                    }
                    else
                    {
                        strValue += strChar[chrValue - 48];
                    }
                }

                return strValue;
            }
            else
            {
                return "";
            }
        }

        public static Type ToType(this string typeStr)
        {
            Type typ = null;
            typ = Type.GetType(typeStr);

            string strNamespace = typeStr;
            while (typ == null)
            {
                if (strNamespace.LastIndexOf(".") > 0)
                {
                    strNamespace = strNamespace.Substring(0, strNamespace.LastIndexOf("."));

                    typ = Type.GetType(typeStr + ", " + strNamespace);
                }
                else
                {
                    break;
                }
            }
            return typ;
        }

        public static byte[] ToBytes(this string str)
        {
            return str.ToBytes("");
        }

        public static byte[] ToBytes(this string value, string separator)
        {
            string strValue = value.Trim();
            if (!string.IsNullOrWhiteSpace(separator))
            {
                strValue = strValue.Replace(separator, "");
            }
            else
            {
                strValue = strValue.Replace(" ", "");
            }

            int intLength = strValue.Length / 2;
            if ((strValue.Length % 2) > 0)
            {
                intLength++;
            }

            byte[] bytDatas = new byte[intLength];

            for (int intIndex = 0; intIndex < strValue.Length; intIndex++)
            {
                if ((intIndex + 2) <= strValue.Length)
                {
                    bytDatas[intIndex / 2] = Convert.ToByte(strValue.Substring(intIndex, 2), 16);
                }
                else
                {
                    bytDatas[intIndex / 2] = Convert.ToByte(strValue.Substring(intIndex, 1), 16);
                }

                intIndex++;
            }
            return bytDatas;
        }

    }
}
