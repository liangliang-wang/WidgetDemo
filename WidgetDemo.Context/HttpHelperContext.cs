using System;
using WidgetDemo.Common;

namespace WidgetDemo.Context
{
    /// <summary>http帮助类 </summary>
    public class HttpHelperContext
    {
        
        /// <summary>http操作</summary>
        /// <param name="url">the url</param>
        /// <param name="type">the type</param>
        /// <param name="data">the data</param>
        /// <returns>结果</returns>
        public string Operator(string url,string type,string data)
        {
            string result;
            try
            {
                if (Convert.ToInt32(type) == (int)HttpRequestType.Get)
                {
                    result = HttpHelper.GetRequest(url);
                }
                else if (Convert.ToInt32(type) == (int)HttpRequestType.Post)
                {
                    result = HttpHelper.PostRequest(url, data);
                }
                else
                {
                    result = "请求类型错误！";
                }
            }
            catch (Exception exception)
            {
                result = exception.Message;
            }
            return result;
        }
    }
}
