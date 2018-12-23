using System;
using System.Text;

namespace AlarmCenter.Utils.Conversion
{
    public static class BytesExtensions
    {
        /// <summary>
        /// byte数组转字符串
        /// </summary>
        /// <param name="bytes">byte数组</param>
        /// <param name="encoding">字符编码，默认为UTF8</param>
        /// <returns></returns>
        public static string BytesToString(this byte[] bytes, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return encoding.GetString(bytes);
        }

        /// <summary>
        /// byte数组转base64字符串
        /// </summary>
        /// <param name="bytes">byte数组</param>
        /// <returns></returns>
        public static string BytesToBase64(this byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// byte数组转16进制
        /// </summary>
        /// <param name="bytes">byte数组</param>
        /// <param name="toUpper">是否转换为大写</param>
        /// <returns></returns>
        public static string BytesToHex(this byte[] bytes, bool toUpper = false)
        {
            var builder = new StringBuilder();
            var format = toUpper ? "{0:X2}" : "{0:x2}";
            foreach (var b in bytes)
            {
                builder.AppendFormat(format, b);
            }
            return builder.ToString();
        }
    }
}