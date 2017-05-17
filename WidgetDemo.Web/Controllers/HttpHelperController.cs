using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Newtonsoft.Json;
using WidgetDemo.Context.MenuServices;
using WidgetDemo.Model.HttpHelper;
using WidgetDemo.Common;

namespace WidgetDemo.Web.Controllers
{
    /// <summary>HttpHelperController </summary>
    public class HttpHelperController : AdminControllerBase
    {
        /// <summary>首页 </summary>
        /// <returns>视图</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>处理类 </summary>
        /// <returns>结果</returns>
        [ValidateInput(false)]
        public string Operator(HttpRequestModel model)
        {
            HttpHelperModel result = new HttpHelperModel();
            Stopwatch watch = new Stopwatch();
            watch.Restart();
            try
            {
                result.Result = SentRequest(model);
                watch.Stop();
                result.SpanTime = watch.ElapsedMilliseconds + "ms";
            }
            catch (Exception exception)
            {
                result.Result = exception.Message;
                watch.Stop();
                result.SpanTime = watch.ElapsedMilliseconds + "ms";
            }
            var s = ToJson(result);
            s = HttpUtility.HtmlEncode(s);
            return s;
        }

        public string Post(string url, string encode = "UTF-8")
        {
            string proxyAddress = "10.14.60.30:6666";
            string result = string.Empty;

            var mRequest = (HttpWebRequest)WebRequest.Create(url);

            mRequest.Method = "Get";
            mRequest.ContentType = "application/json";
            mRequest.Timeout = 30000;
            IWebProxy proxy = new WebProxy(proxyAddress);
            mRequest.Proxy = proxy;

            //string cookie = "_abtest_userid=0648bb9f-64ae-420c-98b5-7fb0a069419f; IntHotelCityID=228split%E4%B8%9C%E4%BA%AC%EF%BC%8C%E4%B8%9C%E4%BA%AC%E9%83%BD%EF%BC%8C%E6%97%A5%E6%9C%ACsplittokyosplit2015-12-30split2015-12-31split2015-12-29%2007%3A56%3A20split32400; DestinationType=1; __utma=13090024.876372743.1451375759.1451375762.1451375762.1; __utmz=13090024.1451375762.1.1.utmcsr=ctrip.com|utmccn=(referral)|utmcmd=referral|utmcct=/; adscityen=Suzhou; ASP.NET_SessionSvc=MTAuOC45Mi4yNDF8OTA5MHxqaW5xaWFvfGRlZmF1bHR8MTQ0OTEzNzU1MjQ4Mg; ASP.NET_SessionId=q44sdwsreoahnryqgihjdcou; Visitor=1; appFloatCnt=9; manualclose=1; LatelySearch=c=D%7c%e5%ad%9f%e5%8a%a0%e6%8b%89%7c%e5%ad%9f%e5%8a%a0%e6%8b%89%7c0%24D%7c%e5%ad%9f%e5%8a%a0%7c%e5%ad%9f%e5%8a%a0%7c0%24D%7c%e8%8b%8f%e4%b8%b9%7c%e8%8b%8f%e4%b8%b9%7c0%24D%7c%e5%b8%8c%e8%85%8a%7c%e5%b8%8c%e8%85%8a%7c0%24D%7c%e7%be%8e%e5%9b%bd%7c%e7%be%8e%e5%9b%bd%7c0; StartCity_Pkg=PkgStartCity=2; SaleCity_Pkg=PkgSaleCity=0; _gat=1; _bfi=p1%3D10300306%26p2%3D10300306%26v1%3D44%26v2%3D43; __zpspc=9.4.1451972031.1451972045.2%234%7C%7C%7C%7C%7C%23; _ga=GA1.2.876372743.1451375759; _jzqco=%7C%7C%7C%7C1451962028354%7C1.2020949242.1451375759468.1451972031044.1451972045403.1451972031044.1451972045403.0.0.0.33.33; Hm_lvt_859112bb3c1c4be58e7e0e59a966879f=1451972028; Hm_lpvt_859112bb3c1c4be58e7e0e59a966879f=1451972053; _bfa=1.1451375755996.k61vk.1.1451965984229.1451972026756.4.45; _bfs=1.3";
            //CookieContainer cookieContainer = new CookieContainer();
            //cookieContainer.SetCookies(new Uri("http://www.tuniu.com"), cookie);
            //mRequest.CookieContainer = cookieContainer;
            //mRequest.Headers.Add("Origin", "http://vacations.ctrip.com");
            //mRequest.Referer = "http://vacations.ctrip.com/visa/p83313s14.html";
            //mRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
            //mRequest.Host = "vacations.ctrip.com";

            //响应流
            var mResponse = (HttpWebResponse)mRequest.GetResponse();
            using (var reader = new StreamReader(mResponse.GetResponseStream(), Encoding.GetEncoding(encode)))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        private string Post(string remoteUrl, string postData, string encode = "UTF-8")
        {
            string proxyAddress = "10.14.60.30:6666";
            string result = string.Empty;

            var mRequest = (HttpWebRequest)WebRequest.Create(remoteUrl);
            //相应请求的参数
            byte[] data = Encoding.GetEncoding(encode).GetBytes(postData);
            mRequest.Method = "Post";
            mRequest.ContentType = "application/json";
            mRequest.ContentLength = data.Length;
            mRequest.Timeout = 30000;
            //IWebProxy proxy = new WebProxy(proxyAddress);
            //mRequest.Proxy = proxy;

            //string cookie = "_abtest_userid=0648bb9f-64ae-420c-98b5-7fb0a069419f; IntHotelCityID=228split%E4%B8%9C%E4%BA%AC%EF%BC%8C%E4%B8%9C%E4%BA%AC%E9%83%BD%EF%BC%8C%E6%97%A5%E6%9C%ACsplittokyosplit2015-12-30split2015-12-31split2015-12-29%2007%3A56%3A20split32400; DestinationType=1; __utma=13090024.876372743.1451375759.1451375762.1451375762.1; __utmz=13090024.1451375762.1.1.utmcsr=ctrip.com|utmccn=(referral)|utmcmd=referral|utmcct=/; adscityen=Suzhou; ASP.NET_SessionSvc=MTAuOC45Mi4yNDF8OTA5MHxqaW5xaWFvfGRlZmF1bHR8MTQ0OTEzNzU1MjQ4Mg; ASP.NET_SessionId=q44sdwsreoahnryqgihjdcou; Visitor=1; appFloatCnt=9; manualclose=1; LatelySearch=c=D%7c%e5%ad%9f%e5%8a%a0%e6%8b%89%7c%e5%ad%9f%e5%8a%a0%e6%8b%89%7c0%24D%7c%e5%ad%9f%e5%8a%a0%7c%e5%ad%9f%e5%8a%a0%7c0%24D%7c%e8%8b%8f%e4%b8%b9%7c%e8%8b%8f%e4%b8%b9%7c0%24D%7c%e5%b8%8c%e8%85%8a%7c%e5%b8%8c%e8%85%8a%7c0%24D%7c%e7%be%8e%e5%9b%bd%7c%e7%be%8e%e5%9b%bd%7c0; StartCity_Pkg=PkgStartCity=2; SaleCity_Pkg=PkgSaleCity=0; _gat=1; _bfi=p1%3D10300306%26p2%3D10300306%26v1%3D44%26v2%3D43; __zpspc=9.4.1451972031.1451972045.2%234%7C%7C%7C%7C%7C%23; _ga=GA1.2.876372743.1451375759; _jzqco=%7C%7C%7C%7C1451962028354%7C1.2020949242.1451375759468.1451972031044.1451972045403.1451972031044.1451972045403.0.0.0.33.33; Hm_lvt_859112bb3c1c4be58e7e0e59a966879f=1451972028; Hm_lpvt_859112bb3c1c4be58e7e0e59a966879f=1451972053; _bfa=1.1451375755996.k61vk.1.1451965984229.1451972026756.4.45; _bfs=1.3";
            //CookieContainer cookieContainer = new CookieContainer();
            //cookieContainer.SetCookies(new Uri("http://www.ctrip.com/"), cookie);
            //mRequest.CookieContainer = cookieContainer;
            //mRequest.Headers.Add("Origin", "http://vacations.ctrip.com");
            //mRequest.Referer = "http://vacations.ctrip.com/visa/p83313s14.html";
            //mRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
            //mRequest.Host = "vacations.ctrip.com";
            //请求流
            using (Stream myRequestStream = mRequest.GetRequestStream())
            {
                myRequestStream.Write(data, 0, data.Length);
            }
            //响应流
            var mResponse = (HttpWebResponse)mRequest.GetResponse();
            using (var reader = new StreamReader(mResponse.GetResponseStream(), Encoding.GetEncoding(encode)))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        /// <summary>
        /// .key
        /// </summary>
        protected string ApiKey = "bcb2p5z459kzbmavccm7kv3s";

        /// <summary>
        /// .secret
        /// </summary>
        protected string SharedSecret = "eG4ybJczBB";

        /// <summary>
        /// 交易
        /// </summary>
        /// <returns>响应数据</returns>
        public string Transact()
        {
            string url = "https://api.test.hotelbeds.com/hotel-content-api/1.0/types/accommodations?fields=all&language=ENG&from=1&to=100&useSecondaryLanguage=false";

            return Transact(url);

        }

        private string Transact(string url)
        {
            string signature = GetSignature();
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.Timeout = 600000;
            request.Accept = "application/json";
            request.Headers.Add("X-Signature", signature);
            //request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Api-Key", ApiKey);
            var response = request.GetResponse() as HttpWebResponse;
            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// 获取签名
        /// </summary>
        /// <returns>签名结果</returns>
        private string GetSignature()
        {
            // Compute the signature to be used in the API call (combined key + secret + timestamp in seconds)
            string signature;
            using (var sha = SHA256.Create())
            {
                long ts = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds / 1000;
                var computedHash = sha.ComputeHash(Encoding.UTF8.GetBytes(ApiKey + SharedSecret + ts));
                signature = BitConverter.ToString(computedHash).Replace("-", "");
            }
            return signature;
        }

        public void Main()
        {

            const string apiKey = "pdbr28mfkas43ww8rqjm49qj";
            const string sharedSecret = "qYaQDjTJzf";

            const string endpoint = "https://api.test.hotelbeds.com/hotel-api/1.0/status";

            // Compute the signature to be used in the API call (combined key + secret + timestamp in seconds)
            string signature;
            using (var sha = SHA256.Create())
            {
                long ts = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds / 1000;
                Console.WriteLine("Timestamp: " + ts);
                var computedHash = sha.ComputeHash(Encoding.UTF8.GetBytes(apiKey + sharedSecret + ts));
                signature = BitConverter.ToString(computedHash).Replace("-", "");
            }

            Console.WriteLine("Signature: " + signature);

            using (var client = new WebClient())
            {
                // Request configuration            
                client.Headers.Add("X-Signature", signature);
                client.Headers.Add("Api-Key", apiKey);
                client.Headers.Add("Accept", "application/xml");
                client.Proxy = new WebProxy("http://pacserver.tcent.cn/?20151230133704");
                client.Proxy.Credentials = new NetworkCredential("wl6491", "Wl123456", "tcent");
                // Request execution
                string response = client.DownloadString(endpoint);
                Debug.WriteLine(response);
            }

        }

        /// <summary>
        /// 发送请求
        /// </summary>
        /// <param name="model">参数</param>
        /// <returns>结果</returns>
        private string SentRequest(HttpRequestModel model)
        {
            string result = string.Empty;
            var mRequest = (HttpWebRequest)WebRequest.Create(model.Urlstr);

            Dictionary<string, string> dic = null;
            try
            {
                if (string.IsNullOrWhiteSpace(model.Header) == false)
                {
                    dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(model.Header);
                }
            }
            catch (Exception)
            {
                throw new Exception("header格式不正确");
            }
            if (dic != null)
            {
                foreach (var d in dic)
                {
                    if (d.Key.ToLower().Equals("host"))
                    {
                        mRequest.Host = d.Value;
                    }
                    else if (d.Key.ToLower().Equals("user-agent"))
                    {
                        mRequest.UserAgent = d.Value;
                    }
                    else if (d.Key.ToLower().Equals("accept"))
                    {
                        mRequest.Accept = d.Value;
                    }
                    else if (d.Key.ToLower().Equals("referer"))
                    {
                        mRequest.Referer = d.Value;
                    }
                    else if (d.Key.ToLower().Equals("connection"))
                    {
                        mRequest.Connection = d.Value;
                    }
                    else
                    {
                        mRequest.Headers.Add(d.Key, d.Value);
                    }

                }
            }
            if (model.IsBo == "1")
            {
                string signature = GetSignature();
                mRequest.Accept = "application/json";
                mRequest.Headers.Add("X-Signature", signature);
                mRequest.Headers.Add("Api-Key", ApiKey);
            }
            if (string.IsNullOrWhiteSpace(model.Cookie) == false)
            {
                var cookies = JsonConvert.DeserializeObject<Dictionary<string, string>>(model.Cookie);
                mRequest.CookieContainer = new CookieContainer();
                foreach (var cookie in cookies)
                {
                    mRequest.CookieContainer.SetCookies(new Uri(cookie.Key), cookie.Value);
                }
            }
            //相应请求的参数
            if (model.Type.ToLower().Equals("post") || model.Type.ToLower().Equals("put"))
            {
                GetPostRequest(mRequest, model);
            }
            else
            {
                GetGetRequest(mRequest, model);
            }
            //响应流
            var mResponse = (HttpWebResponse)mRequest.GetResponse();
            using (var reader = new StreamReader(mResponse.GetResponseStream(), Encoding.GetEncoding(model.Encode)))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        private void GetGetRequest(HttpWebRequest mRequest, HttpRequestModel model)
        {
            mRequest.Method = model.Type;
            mRequest.ContentType = "text/html";
            mRequest.Timeout = 300000;
        }

        private void GetPostRequest(HttpWebRequest mRequest, HttpRequestModel model)
        {
            byte[] data = Encoding.GetEncoding(model.Encode).GetBytes(model.Data);
            mRequest.Method = model.Type;
            mRequest.ContentType = "application/x-www-form-urlencoded";
            mRequest.ContentLength = data.Length;
            mRequest.Timeout = 300000;
            using (Stream myRequestStream = mRequest.GetRequestStream())
            {
                myRequestStream.Write(data, 0, data.Length);
            }
        }

        private string Send(HttpRequestModel model)
        {
            string result = string.Empty;
            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");

            Dictionary<string, string> dic = null;
            try
            {
                dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(model.Header);
            }
            catch (Exception)
            {
                throw new Exception("header格式不正确");
            }
            if (dic != null)
            {
                foreach (var d in dic)
                {
                    client.Headers.Add(d.Key, d.Value);
                }
            }

            return result;
        }

        public string DownLoad()
        {
            string result = string.Empty;
            try
            {
                string url = "http://aif2.interface-xml.com/aif2-pub-ws/files/full";
                string url01 = "http://testaif2.interface-xml.com/aif2-pub-ws/files/full";
                string url03 = "http://testaif2.interface-xml.com/aif2-pub-ws/files/full";

                //WebClient webClient = new WebClient();

                //webClient.Headers.Add("X-Username", "TONGCHENGNCN160094");
                //webClient.Headers.Add("X-Password", "TONGCHENGNCN160094");

                //var s = webClient.OpenRead(url);

                var mRequest = (HttpWebRequest)WebRequest.Create(url03);
                mRequest.Method = "Get";
                mRequest.Headers.Add("X-Username", "TONGCHENGNCN160094");
                mRequest.Headers.Add("X-Password", "TONGCHENGNCN160094");
                var mResponse = (HttpWebResponse)mRequest.GetResponse();
            }
            catch (Exception exception)
            {
                result = JsonConvert.SerializeObject(exception);
            }
            return result;
        }


        public string GetJson()
        {
            string result = string.Empty;
            var mRequest = (HttpWebRequest)WebRequest.Create("http://www.lvyouquan.cn/Product/GetResultData");
            //string postData = "city=0&goDate=0&startDate=&endDate=&day=0&tagbrowseID=&productLevel=0&business=&cruiseshipcompany=&tagID=&hotelStandard=0&trafficType=0&scheduleType=0&linType=1&from=&currentPageIndex=1&isPublicBusiness=false&pageSize=20&cashCouponType=0&searchKey=%25e6%25b3%25b0%25e5%259b%25bd&keywordtype=1&BusinessID=bd4ff7030e36414fa99c5e83cc165980&BusinessName=%E5%90%8C%E7%A8%8B%E5%9B%BD%E9%99%85%E6%97%85%E8%A1%8C%E7%A4%BE%EF%BC%88%E8%8B%8F%E5%B7%9E%EF%BC%89%E6%9C%89%E9%99%90%E5%85%AC%E5%8F%B8&CSCompanyId=&CSNumberId=&StartPort=&CSThirdLevelAreaId=&CSGoDate=&IsPersonPurchasePrice=false&IsComfirmStockNow=false&IsPreSale=false&price=%2C&OrderField=&OrderType=&IsReMai=&IsTeJia=&IsLiRun=&IsWeight=&IsNewSearch=1&IsFromPC=1&IsUseNewRuleOrderBy=";
            string postData = "linType=1&from=&currentPageIndex=1&isPublicBusiness=false&pageSize=20&cashCouponType=0&searchKey=%25e6%25b3%25b0%25e5%259b%25bd&keywordtype=1&BusinessID=bd4ff7030e36414fa99c5e83cc165980&BusinessName=%E5%90%8C%E7%A8%8B%E5%9B%BD%E9%99%85%E6%97%85%E8%A1%8C%E7%A4%BE%EF%BC%88%E8%8B%8F%E5%B7%9E%EF%BC%89%E6%9C%89%E9%99%90%E5%85%AC%E5%8F%B8&CSCompanyId=&CSNumberId=&StartPort=&CSThirdLevelAreaId=&CSGoDate=&IsPersonPurchasePrice=false&IsComfirmStockNow=false&IsPreSale=false&price=%2C&OrderField=&OrderType=&IsReMai=&IsTeJia=&IsLiRun=&IsWeight=&IsNewSearch=1&IsFromPC=1&IsUseNewRuleOrderBy=";
            byte[] data = Encoding.GetEncoding("UTF-8").GetBytes(postData);
            mRequest.Method = "POST";
            mRequest.ContentType = "application/x-www-form-urlencoded;";
            mRequest.ContentLength = data.Length;
            mRequest.Timeout = 8000;
            mRequest.Accept = "application/json, text/javascript, */*; q=0.01";
            mRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.116 Safari/537.36";
            mRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
            //mRequest.Headers.Add("Originh", "http://www.lvyouquan.cn");
            //mRequest.Referer = "http://www.lvyouquan.cn/Product/SearchResult?key=%E6%B3%B0%E5%9B%BD";
            mRequest.CookieContainer = new CookieContainer();
            Cookie cookie = new Cookie("B2BLYQBusLoginID20150807", "{line}{line}2fwurYl0eM6{plus}pVhc47b1PV{line}tV6r1YOdlQA3VApu5OnxqRbVSOxQA{equel}{equel}");
            mRequest.CookieContainer.Add(new Uri("http://www.lvyouquan.cn"), cookie);
            //mRequest.CookieContainer.SetCookies(new Uri("http://www.lvyouquan.cn"), "B2BLYQBusLoginID20150807={line}{line}2fwurYl0eM6{plus}pVhc47b1PV{line}tV6r1YOdlQA3VApu5OnxqRbVSOxQA{equel}{equel}");
            //var logResponse = Post1();
            // mRequest.CookieContainer.Add(new Uri("http://www.lvyouquan.cn"), logResponse.Cookies);

            using (Stream myRequestStream = mRequest.GetRequestStream())
            {
                myRequestStream.Write(data, 0, data.Length);
            }
            //响应流
            var mResponse = (HttpWebResponse)mRequest.GetResponse();
            using (var reader = new StreamReader(mResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8")))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        public string Post1()
        {
            string result = string.Empty;
            var mRequest = (HttpWebRequest)WebRequest.Create("http://www.lvyouquan.cn/Index.aspx");
            string postData = "__VIEWSTATE=%2FwEPDwUKMTY0NDUxNzE0Mg9kFgICAw9kFgICAg8WAh4EVGV4dGVkZKJ87ehM7pmy3De5xL5gH3HCCJjt&__VIEWSTATEGENERATOR=90059987&BusinessesLogin1%24hid_callbackurl=http%3A%2F%2Fwww.lvyouquan.cn%2FMemberCenter%2FIndex&BusinessesLogin1%24hid_issub=&BusinessesLogin1%24txtUserName=zxf08656%40LY.com&BusinessesLogin1%24txtPassword=123qwe123&BusinessesLogin1%24Button1=%E7%99%BB%E5%BD%95&BusinessesLogin1%24hidMsg=";
            byte[] data = Encoding.GetEncoding("UTF-8").GetBytes(postData);
            mRequest.Method = "POST";
            mRequest.ContentType = "application/x-www-form-urlencoded";
            mRequest.ContentLength = data.Length;
            mRequest.Timeout = 300000;
            mRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            mRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.116 Safari/537.36";
            mRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
            mRequest.Referer = "http://www.lvyouquan.cn/Index.aspx";
            mRequest.CookieContainer = new CookieContainer();
            mRequest.CookieContainer.SetCookies(new Uri("http://www.lvyouquan.cn"), "SERVERID=web35; path=/");

            using (Stream myRequestStream = mRequest.GetRequestStream())
            {
                myRequestStream.Write(data, 0, data.Length);
            }
            //响应流
            var mResponse = (HttpWebResponse)mRequest.GetResponse();
            using (var reader = new StreamReader(mResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8")))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        private CookieCollection get01()
        {
            string result = string.Empty;
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create("http://www.lvyouquan.cn/Index.aspx");
            mRequest.Method = "Get";
            var mResponse = (HttpWebResponse)mRequest.GetResponse();
            using (var reader = new StreamReader(mResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8")))
            {
                result = reader.ReadToEnd();
            }
            var cookie = mResponse.Cookies;
            return cookie;
        }

        public ViewResult Login()
        {
            string result = "";
            string loginName = "";
            string password = "";
            string userData = loginName + "|" + password;
            ErrorMessage message = new MenuService().Login(loginName, password);

            DateTime time = DateTime.Parse("2016-04-18 18:00");
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, loginName, time, time.AddDays(100)
                , false, userData);
            string hashTicket = FormsAuthentication.Encrypt(ticket);

            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashTicket) { HttpOnly = true };
            //cookie.Domain = "";
            //Response.AddHeader("P3P", "CP=CAO PSA OUR");
            Response.Cookies.Add(cookie);

            //List<string> s= new List<string>(){"a","a","b","b","b"};
            //var sg =s.GroupBy(x => x).OrderBy(x=>x.Count());

            return View();
        }

        public void SendSMS()
        {

        }

        public void ImageToBase64()
        {
            var file = @"E:\微信图片.png";
            var base64 = ImageHelper.ImgToBase64String(file);
            var savePath =@"E:\";
            ImageHelper.Base64ToImg(base64, savePath, "123");
        }
    }
}
