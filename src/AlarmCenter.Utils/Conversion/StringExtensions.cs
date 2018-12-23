using System;
using System.Text;

namespace AlarmCenter.Utils.Conversion
{
    public static class StringExtensions
    {
        /// <summary>
        /// 字符串转byte数组
        /// </summary>
        /// <param name="text">字符串</param>
        /// <param name="encoding">字符编码，默认为UTF8</param>
        /// <returns></returns>
        public static byte[] StringToBytes(this string text, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return encoding.GetBytes(text);
        }

        /// <summary>
        /// base64字符串转byte数组
        /// </summary>
        /// <param name="base64Text">base64字符串</param>
        /// <returns></returns>
        public static byte[] Base64StringToBytes(this string base64Text)
        {
            return Convert.FromBase64String(base64Text);
        }
    }
}