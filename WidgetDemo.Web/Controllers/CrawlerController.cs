using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WidgetDemo.Context.Crawler;

namespace WidgetDemo.Web.Controllers
{
    public class CrawlerController : AdminControllerBase
    {
        public ContentResult Spider(string url)
        {
            var message = string.Empty;
            try
            {
                var uri = new Uri(url);
                ICrawler crawler = new StrongCrawler();
                crawler.OnStart += (s, e) =>
                {
                    message += "开始抓取#";
                };
                crawler.OnCompleted += (s, e) =>
                {
                    message += string.Format("抓取完成,耗时:{0},线程Id：{1},内容：{2}", e.MilliSeconds, e.ThreadId, e.PageSource);
                    Write(message, @"G:\test\WidgetDemo\WidgetDemo.Web\App_Data\123.txt");
                };
                crawler.OnError += (s, e) =>
                {
                    message += string.Format("抓取异常,异常信息:{0}", e.Exception.Message);
                    Write(message, @"G:\test\WidgetDemo\WidgetDemo.Web\App_Data\123.txt");
                };
                var task = crawler.Start(uri);
                //var response = crawler.Start(uri);
                //while (response.IsCompleted != true) {
                //    Thread.Sleep(100);
                //}
                //var p = Task.WaitAny();
                //var result = response.Wait(20000);
                //message += string.Format("是否执行完成：{0}", result) ;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return Content(message);
        }

        private void Write(string message, string path)
        {
            using (var write = new StreamWriter(path))
            {
                write.WriteLine(message);
            }
        }
    }
}