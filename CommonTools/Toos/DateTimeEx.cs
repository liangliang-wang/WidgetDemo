using System;

namespace CommonTools.Tools
{
    /// <summary>
    /// 日期扩展类
    /// </summary>
    public static class DateTimeEx
    {
        /// <summary>
        /// utc时间 1970-1-1 0：0：0
        /// </summary>
        private static readonly DateTime JavaTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// 获取java语言中的utc格式的时间
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>utc格式日期</returns>
        public static long CurrentTimeMillis(this DateTime dateTime)
        {
            return (long)(dateTime.ToUniversalTime() - JavaTime).TotalMilliseconds;
        }

        /// <summary>Java毫秒数转DateTime</summary>
        /// <param name="timestamp">毫秒数</param>
        /// <returns>时间</returns>
        public static DateTime UnixTimestampToDateTime(this long timestamp)
        {
            return JavaTime.AddMilliseconds(timestamp).ToLocalTime();
        }
    }
}
