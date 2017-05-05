using System;
using WidgetDemo.Common;

namespace WidgetDemo.Context
{
    /// <summary>帮助 类Context </summary>
    public class HelperContext
    {
        /// <summary>将Java的毫秒数转化为时间 </summary>
        /// <param name="millisecond">毫秒数</param>
        /// <returns>时间</returns>
        public static DateTime GetTimeByJavaMilliseconds(long millisecond)
        {
            return millisecond.UnixTimestampToDateTime();
        }

        /// <summary>  时间戳转为C#格式时间 </summary>  
        /// <param name="timeStamp">Unix时间戳格式</param>  
        /// <returns>C#格式时间</returns>  
        public static DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        /// <summary>
        /// timestamp转datetime
        /// </summary>
        /// <param name="timestamp">timestamp</param>
        /// <returns>时间</returns>
        public static DateTime ConvertTimestamp(double timestamp)
        {
            DateTime converted = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateTime newDateTime = converted.AddSeconds(timestamp);
            return newDateTime.ToLocalTime();
        }

        /// <summary>
        /// datetime转时间戳
        /// </summary>
        /// <param name="timeStr">时间</param>
        /// <returns>时间戳</returns>
        public static double ToTimestamp(string timeStr)
        {
            DateTime time = new DateTime();
            try
            {
                time = DateTime.Parse(timeStr);
            }
            catch (Exception)
            {
                
            }
            TimeSpan span = (time - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());
            return span.TotalSeconds;
        } 
    }
}
