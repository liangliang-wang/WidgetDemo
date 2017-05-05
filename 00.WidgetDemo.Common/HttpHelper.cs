using System.IO;
using System.Net;
using System.Text;

namespace WidgetDemo.Common
{
    /// <summary>http帮助类 </summary>
    public class HttpHelper
    {
        /// <summary>发起HTTP请求 </summary>
        /// <param name="remoteUrl">接口地址</param>
        /// <param name="postData">请求参数</param>
        /// <param name="timeOut">超时时间</param>
        /// <param name="encode">编码方式</param>
        /// <param name="contentType">内容类型</param>
        /// <returns>结果</returns>
        public static string PostRequest(string remoteUrl, string postData, int timeOut = 30000, string encode = "UTF-8", string contentType = "application/x-www-form-urlencoded")
        {
            var result = string.Empty;

            var mRequest = (HttpWebRequest)WebRequest.Create(remoteUrl);
            //相应请求的参数
            byte[] data = Encoding.GetEncoding(encode).GetBytes(postData);
            mRequest.Method = "Post";
            mRequest.ContentType = contentType;
            mRequest.ContentLength = data.Length;
            mRequest.Timeout = timeOut;
            //请求流
            Stream requestStream = mRequest.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();
            //响应流
            var mResponse = (HttpWebResponse)mRequest.GetResponse();
            var responseStream = mResponse.GetResponseStream();
            if (responseStream != null)
            {
                var streamReader = new StreamReader(responseStream, Encoding.GetEncoding(encode));
                //获取返回的信息
                result = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();
            }
            return result;
        }

        /// <summary>Get请求</summary>
        /// <param name="remoteUrl">接口地址</param>
        /// <param name="timeOut">超时时间</param>
        /// <param name="encode">编码方式</param>
        /// <returns>结果</returns>
        public static string GetRequest(string remoteUrl, int timeOut = 30000, string encode = "UTF-8")
        {
            var result = string.Empty;

            var mRequest = (HttpWebRequest)WebRequest.Create(remoteUrl);
            mRequest.Timeout = timeOut;
            var mResponse = (HttpWebResponse)mRequest.GetResponse();
            Stream responseStream = mResponse.GetResponseStream();
            if (responseStream != null)
            {
                StreamReader myStreamReader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                result = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                responseStream.Close();
            }
            return result;
        }
    }
}
