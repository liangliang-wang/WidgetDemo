using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WidgetDemo.Context;

namespace WidgetDemo.Web.Controllers
{
    /// <summary>redis</summary>
    public class RedisController : AdminControllerBase
    {
        /// <summary>添加redis </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <returns>结果</returns>
        public bool AddRedis(string key,string value)
        {
            bool result = false;
            try
            {
                result = RedisContext.Instance.AddRedis(key, value);
            }
            catch (Exception exception)
            {
                var message = exception;
            }
            
            return result;
        }

        /// <summary>获取redis </summary>
        /// <param name="key">键</param>
        /// <returns>结果</returns>
        public string GetRedis(string key)
        {
            string result = string.Empty;
            try
            {
                result = RedisContext.Instance.GetRedis(key);
            }
            catch (Exception exception)
            {
                var message = exception;
            }
            
            return result;
        }

        /// <summary>更新redis </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <returns>结果</returns>
        public bool UpdateRedis(string key, string value)
        {
            bool result = false;
            try
            {
                result = RedisContext.Instance.UpdateRedis(key, value);
            }
            catch (Exception exception)
            {
                var message = exception;
            }

            return result;
        }

        /// <summary>获取所有key </summary>
        /// <returns>结果</returns>
        public ContentResult GetAllKey()
        {
            List<string> result = new List<string>();
            try
            {
                result = RedisContext.Instance.GetAllKey();
            }
            catch (Exception exception)
            {
                var message = exception;
            }
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var json = jsonSerializer.Serialize(result);
            return Content(json, "text/html");
        }
    }
}
