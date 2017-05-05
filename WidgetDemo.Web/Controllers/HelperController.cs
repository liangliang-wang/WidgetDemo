using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TC.Flight.CommonToolsLibrary.Tools;
using WidgetDemo.Context;

namespace WidgetDemo.Web.Controllers
{
    /// <summary>帮助类</summary>
    public class HelperController : AdminControllerBase
    {
        /// <summary>页面视图</summary>
        /// <returns>视图</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>json格式化</summary>
        /// <returns>视图</returns>
        public ActionResult JsonHelper()
        {
            return View();
        }

        /// <summary>将Java的毫秒数转化为时间 </summary>
        /// <param name="milliseconds">毫秒数</param>
        /// <returns>结果</returns>
        public ContentResult GetTimeByJava(string milliseconds)
        {
            var ss = StringPlus.StrToInt64(milliseconds, 0);
            DateTime time = HelperContext.GetTimeByJavaMilliseconds(ss);
            return Content(time.ToString());
        }

        public ContentResult GetTimeByStamp(string milliseconds)
        {
            var ss = StringPlus.StrToInt64(milliseconds, 0);
            DateTime time = HelperContext.ConvertTimestamp(ss);
            return Content(time.ToString());
        }

        public ContentResult GetStampByTime(string milliseconds)
        {
            double stamp = HelperContext.ToTimestamp(milliseconds);
            return Content(stamp.ToString());
        }

        /// <summary>httphelper</summary>
        /// <returns>视图</returns>
        public ActionResult HttpHelper()
        {
            return View();
        }

        /// <summary>日志记录</summary>
        /// <returns>日志类型</returns>
        public ContentResult WriteLog()
        {
            string type = string.Empty;
            var count = Request["count"];
            //LogRecordEntity entity = new LogRecordEntity();
            //entity.CatType = LogCatType.Common;
            //entity.SubCatType = LogSubCatType.ChuJingYou;
            //entity.RequestTime = DateTime.Now;
            //entity.Ext = "wl测试";
            try
            {
                int num = String2Int(count);
                for (int i = 0; i < num; i++)
                {
                    Log2(i.ToString());
                }
                type = "正常 + " + count;
            }
            catch (Exception exception)
            {
                type = "异常";
                LogExc2(exception);

            }
            return Content(type);
        }

        private void Log2(string reId)
        {
            Log(reId);
        }

        private void LogExc2(Exception exception)
        {
            LogExc(exception);
        }


        /// <summary>记录日志</summary>
        /// <param name="reId">次数</param>
        public void Log(string reId)
        {
           
        }

        /// <summary>记录异常日志 </summary>
        /// <param name="exception">异常信息</param>
        public void LogExc(Exception exception)
        {
          
        }

        /// <summary>int a </summary>
        /// <param name="count"> count</param>
        /// <returns>int</returns>
        private int String2Int(string count)
        {
            int num = 0;
            try
            {
                num = StringToInt(count);
            }
            catch (Exception exception)
            {
                throw new Exception("String2Int错误", exception);
            }
            return num;
        }

        /// <summary>字符串装换数字</summary>
        /// <param name="count">字符串</param>
        /// <returns>数字</returns>
        public int StringToInt(string count)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(count);
            }
            catch (Exception exception)
            {
                throw new Exception("StringToInt错误", exception);
            }
            return num;
        }


        private string buildUrl = "";


        public string Build(string projectId, string branch)
        {
            Log();
            var url = string.Format(buildUrl, projectId, branch);
            var result = new HttpHelperContext().Operator(url, "1", string.Empty);
            return result;
        }


        private string logUrl = "";
        private void Log()
        {
            var result = PostRequest(logUrl, "{ 'userName': '','password': ''}");
        }



        private string cookie =
            "__xsptplus352=352.2.1431762389.1431762460.2%234%7C%7C%7C%7C%7C%23%234f_pR-e_BWVZ3JxTelEnc9QqryfzIrIx%23;" +
            " _ga=GA1.2.1127061051.1432866698; _bfa=1.1428572653568.38icxh.1.1432866698064.1433754600227.7.11;" +
            " __zpspc=9.10.1433754600.1433754632.3%234%7C%7C%7C%7C%7C%23; " +
            "_jzqco=%7C%7C%7C%7C1433754600472%7C1.1705716010.1426749337946.1433754609154.1433754632591.1433754609154.1433754632591.undefined.0.0.26.26;" +
            " _bfi=p1%3D0%26p2%3D0%26v1%3D11%26v2%3D10";
        private string PostRequest(string remoteUrl, string postData, int timeOut = 30000, string encode = "UTF-8", string contentType = "application/x-www-form-urlencoded")
        {
            var result = string.Empty;

            var mRequest = (HttpWebRequest)WebRequest.Create(remoteUrl);
            //相应请求的参数
            byte[] data = Encoding.GetEncoding(encode).GetBytes(postData);
            mRequest.Method = "Post";
            mRequest.ContentType = contentType;
            mRequest.ContentLength = data.Length;
            mRequest.Timeout = timeOut;
            mRequest.Referer = "";
            mRequest.Host = "";
            mRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.95 Safari/537.36";

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

        /// <summary>
        /// 设置cookie
        /// </summary>
        public void SetCookie()
        {
            string name = Request["name"];
            string value = Request["value"];
            HttpCookie cookie = new HttpCookie(name);//初使化并设置Cookie的名称
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(1, 0, 0, 0, 0);//过期时间为1天
            cookie.Expires = dt.Add(ts);//设置过期时间
            cookie.Value = value;
            Response.Cookies.Add(cookie);
        }

        public void ClearCookie()
        {
            string name = Request["name"];
            HttpCookie cookie = new HttpCookie(name);//初使化并设置Cookie的名称
            DateTime dt = DateTime.Now.AddDays(-1);
            cookie.Expires = dt;//设置过期时间
            cookie.Value = "";
            Response.Cookies.Add(cookie);
        }
    }
}
