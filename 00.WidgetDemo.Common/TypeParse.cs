using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemo.Common
{
    public static class TypeParse
    {
        /// <summary>
        /// 转化为int32
        /// </summary>
        /// <param name="value">原值</param>
        /// <param name="defaultValue">失败后的默认值</param>
        /// <returns>结果</returns>
        public static int ToInt32(this string value, int defaultValue)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>
        /// 转化为int32
        /// </summary>
        /// <param name="value">原值</param>
        /// <param name="defaultValue">失败后的默认值</param>
        /// <returns>结果</returns>
        public static int ToInt32(this object value, int defaultValue)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>
        /// 转化为long
        /// </summary>
        /// <param name="value">原值</param>
        /// <param name="defaultValue">失败后的默认值</param>
        /// <returns>结果</returns>
        public static long ToLong(this string value, long defaultValue)
        {
            long result = 0;
            try
            {
                result = Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>
        /// 转化为long
        /// </summary>
        /// <param name="value">原值</param>
        /// <param name="defaultValue">失败后的默认值</param>
        /// <returns>结果</returns>
        public static long ToLong(this object value, long defaultValue)
        {
            long result = 0;
            try
            {
                result = Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>
        /// 转化为dateTime
        /// </summary>
        /// <param name="value">原值</param>
        /// <param name="defaultValue">失败后的默认值</param>
        /// <returns>结果</returns>
        public static DateTime ToDateTime(this object value, DateTime defaultValue)
        {
            DateTime result = defaultValue;
            try
            {
                result = Convert.ToDateTime(value);
            }
            catch (Exception ex)
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>
        /// 转化为Double 
        /// </summary>
        /// <param name="value">原值</param>
        /// <param name="defaultValue">失败后的默认值</param>
        /// <returns>结果</returns>
        public static double ToDouble(this object value, double defaultValue)
        {
            double result = 0;
            try
            {
                result = Convert.ToDouble(value);
            }
            catch (Exception ex)
            {
                result = defaultValue;
            }
            return result;
        }
    }
}
