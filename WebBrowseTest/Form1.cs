using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using TC.Vacations.WorkingPlatform.OutService.SpiderRuning;
using WidgetDemo.Common;

namespace WebBrowseTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            url = address.Text;
            ThreadMethod();
            CancelProxy();
        }

        /// <summary>请求url</summary>
        private string url = "http://www.tuniu.com/visa/visa_";

        /// <summary>是否加载下单页</summary>
        private bool isRun = false;

        /// <summary>是否进入下单成功返回页 </summary>
        private bool isOrder = false;

        /// <summary>订单id</summary>
        private string orderId;

        /// <summary>得到WebBrowser</summary>
        /// <param name="url">url</param>
        /// <returns>WebBrowser</returns>
        private WebBrowser GetPage(string url)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            webBrowser1.Navigate(url);
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
            stopwatch.Stop();
            richTextBox1.Text += "产品也加载：" + stopwatch.ElapsedMilliseconds;
            richTextBox1.Text = richTextBox1.Text.Replace("\n", "\r\n");
            return webBrowser1;
        }

        /// <summary>单线程单元方法</summary>
        public void ThreadMethod()
        {
            GetProxy();
            try
            {
                webBrowser1 = GetPage(url);
                webBrowser1.DocumentCompleted += web_DocumentCompleted;
                HtmlElement fromSubmit = webBrowser1.Document.GetElementById("order_now");
                if (fromSubmit == null)
                {
                   
                    return;
                }
                fromSubmit.InvokeMember("submit");
                Thread.Sleep(1000);
                Application.DoEvents();
                while (!isRun)
                {
                    Application.DoEvents();
                    if (string.IsNullOrWhiteSpace(webBrowser1.DocumentTitle))
                    {
                       
                        return;
                    }
                }
            }
            catch (Exception exception)
            {
                
            }
            finally
            {
                webBrowser1.Dispose();
            }
        }

        /// <summary>加载下单页 </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            WebBrowser orderWeb = sender as WebBrowser;
            if (orderWeb == null || orderWeb.DocumentTitle != "线路预订 - 途牛" || isRun)
            {
                return;
            }
            orderWeb.DocumentCompleted -= web_DocumentCompleted;
            orderWeb.DocumentCompleted += orderWeb_DocumentCompleted;
            Order(orderWeb);
            stopwatch.Stop();
            richTextBox1.Text += "加载下单页：" + stopwatch.ElapsedMilliseconds ;
            richTextBox1.Text = richTextBox1.Text.Replace("\n", "\r\n");
        }

        /// <summary>订单处理 </summary>
        /// <param name="orderWeb">订单</param>
        private void Order(WebBrowser orderWeb)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int count = 0;
            int maxCount = 120;
            bool isSetOrder = false;
            try
            {
                SetOrderValue(orderWeb, ref isSetOrder);
                if (!isSetOrder)
                {
                    ThreadMethod();
                    return;
                }
                isRun = true;
                var submitBtn = orderWeb.Document.GetElementById("frm_submit");
                submitBtn.InvokeMember("submit");
                //var submitBtn = orderWeb.Document.GetElementById("s_g_next");
                //submitBtn.InvokeMember("Click");
                while (!isOrder)
                {
                    Thread.Sleep(500);
                    Application.DoEvents();
                    count++;
                    if (count > maxCount)
                    {
                        count = 0;
                        ThreadMethod();
                    }
                }
            }
            catch (Exception exception)
            {
              
            }
            stopwatch.Stop();
            richTextBox1.Text += "订单处理：" + stopwatch.ElapsedMilliseconds;
            richTextBox1.Text = richTextBox1.Text.Replace("\n", "\r\n");
        }

        /// <summary>下单成功页</summary>
        /// <param name="sender">the sender</param>
        /// <param name="e">the e</param>
        private void orderWeb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (isOrder)
            {
                return;
            }
            WebBrowser orderWeb = sender as WebBrowser;
            orderId = string.Empty;
            string orderIndexUrl = orderWeb.Url.ToString();
            if (!string.IsNullOrWhiteSpace(orderIndexUrl))
            {
                Regex reg = new Regex(@"[0-9][0-9,.]*");
                orderId = reg.Match(orderIndexUrl).Value;
            }
            isOrder = true;
            stopwatch.Stop();
            richTextBox1.Text += "下单成功页：" + stopwatch.ElapsedMilliseconds;
            richTextBox1.Text = richTextBox1.Text.Replace("\n", "\r\n");
        }

        /// <summary>设置订单值</summary>
        /// <param name="web">WebBrowser</param>
        /// <param name="isSetOrder">是否设置完毕</param>
        private void SetOrderValue(WebBrowser web, ref bool isSetOrder)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var dayNum = web.Document.GetElementById("day_num");
            var contactsName = web.Document.GetElementById("tourist_name");
            var contactsTel = web.Document.GetElementById("tourist_tel");
            var contactsEmail = web.Document.GetElementById("tourist_email");
            var name1 = web.Document.GetElementById("name_1");
            var isAdult = web.Document.GetElementById("gx_g31");
            var newLogin = web.Document.GetElementById("new_login");

            if (isAdult == null || dayNum == null || contactsName == null || contactsTel == null || contactsEmail == null || name1 == null)
            {
                return;
            }
            isAdult.InvokeMember("Click");
            if (newLogin != null)
            {
                newLogin.InvokeMember("Click");
            }

            string day = "1";
            string name = GetName();
            string tel = GetTel();
            WriteValue(dayNum, day);
            WriteValue(contactsName, name);
            WriteValue(contactsTel, tel);
            WriteValue(contactsEmail, tel + "@qq.com");
            WriteValue(name1, name);
            isSetOrder = true;
            stopwatch.Stop();
            string s = richTextBox1.Text + "设置订单值：" + stopwatch.ElapsedMilliseconds;
            richTextBox1.Text = s.Replace("\n", "\r\n");
        }

        /// <summary>设置元素value属性的值 </summary>
        /// <param name="e">html节点</param>
        /// <param name="value">值</param>
        private void WriteValue(HtmlElement e, string value)
        {
            e.SetAttribute("value", value);
        }

        /// <summary>获取手机号</summary>
        /// <returns>手机号</returns>
        private string GetTel()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var tel = "18958652427";
            //if (CheckTel(tel))
            //{
            //    tel = GetTel();
            //}
            stopwatch.Stop();
            string s = richTextBox1.Text + "获取手机号：" + stopwatch.ElapsedMilliseconds ;
            richTextBox1.Text = s.Replace("\n", "\r\n");
            return tel;
        }

        /// <summary>验证手机号是否注册会员</summary>
        /// <param name="tel">手机号</param>
        /// <returns>是否注册</returns>
        private bool CheckTel(string tel)
        {
            string registed = "49";
            bool result = false;
            Random random = new Random();
            var rd = random.Next();
            string checkUrl = string.Format("http://www.xxxx.com/main.php?do=order_login_ajax&flag=check_login_tel&tel={0}&catch={1}", tel, rd);
            var checkResult = HttpHelper.GetRequest(checkUrl);
            if (checkResult.Equals(registed))
            {
                result = true;
            }
            return result;
        }

        /// <summary>随机产生6位字母字符串 </summary>
        /// <returns>6位字符串</returns>
        private string GetName()
        {
            int esultLength = 6;
            string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random r = new Random();
            string result = string.Empty;
            for (int i = 0; i < esultLength; i++)
            {
                int m = r.Next(0, str.Length);
                string s = str.Substring(m, 1);
                result += s;
            }
            return result;
        }

        /// <summary>查询XML</summary>
        /// <returns>结果</returns>
        private static string SearchtelByXml()
        {
            string result = string.Empty;
            string xmlFileName = AppDomain.CurrentDomain.BaseDirectory + "App_Data\\SpiderPlugins\\Tel.xml";
            XDocument customers = XDocument.Load(xmlFileName);

            var resultNode = customers.Element("tels").Element("tel");

            if (resultNode == null) return result;
            result = resultNode.Value;
            resultNode.Remove();
            customers.Save(xmlFileName);
            return result;
        }

        /// <summary>获取代理 </summary>
        private void GetProxy()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string testProxyType = "1";
            string testProxy = "172.16.58.188:9999";
            string productProxy = "222.92.187.51:9999";
            string proxytype = "1";
            IEProxy irProxy = new IEProxy(productProxy);
            if (proxytype.Equals(testProxyType))
            {
                irProxy = new IEProxy(testProxy);
            }
            var result = irProxy.RefreshIESettings();
            stopwatch.Stop();
            richTextBox1.Text += "获取代理：" + stopwatch.ElapsedMilliseconds ;
            richTextBox1.Text = richTextBox1.Text.Replace("\n", "\r\n");
        }

        /// <summary>取消代理</summary>
        private void CancelProxy()
        {
            IEProxy irProxy = new IEProxy(string.Empty);
            irProxy.DisableIEProxy();
        }

        #region 日志入口
        /// <summary>写正常日志</summary>
        /// <param name="log">日志实体</param>
        private void Log(object log)
        {
           
        }

        /// <summary>写异常日志</summary>
        /// <param name="log">日志实体</param>
        /// <param name="exception">异常</param>
        private void ExceptionLog(object log, Exception exception)
        {
           
        }
        #endregion
    }
}
