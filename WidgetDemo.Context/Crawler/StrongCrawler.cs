using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WidgetDemo.Context.Crawler;

namespace WidgetDemo.Context.Crawler
{
    public class StrongCrawler : ICrawler
    {
        /// <summary>
        /// 爬虫启动事件
        /// </summary>
        public event EventHandler<OnStartEventArgs> OnStart;

        /// <summary>
        /// 爬虫完成事件
        /// </summary>
        public event EventHandler<OnCompletedEventArgs> OnCompleted;

        /// <summary>
        /// 爬虫异常事件
        /// </summary>
        public event EventHandler<OnErrorEventArgs> OnError;

        /// <summary>
        /// 定义PhantomJS内核参数
        /// </summary>
        private PhantomJSOptions options = new PhantomJSOptions();

        private static string seleniumPath = @"G:\test\WidgetDemo\SolutionItems";

        /// <summary>
        /// 定义Selenium驱动配置
        /// </summary>
        private PhantomJSDriverService service = PhantomJSDriverService.CreateDefaultService(seleniumPath);

        /// <summary>
        /// 启动爬虫进程
        /// </summary>
        /// <param name="uri">uri</param>
        /// <returns>任务</returns>
        public async Task Start(Uri uri)
        {
            await Task.Run(() =>
            {
                if (OnStart != null) this.OnStart(this, new OnStartEventArgs(uri));
                var driver = new PhantomJSDriver(service, options);//实例化PhantomJS的WebDriver
                try
                {
                    var watch = DateTime.Now;
                    driver.Navigate().GoToUrl(uri.ToString());
                    // if(script != null)driver.ExecuteScript(script.Code,script.Args)    //执行JavaScript代码
                    var driverWait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
                    var threadId = Thread.CurrentThread.ManagedThreadId;//当前线程ID
                    var milliseconds = DateTime.Now.Subtract(watch).Milliseconds;
                    var pageSource = driver.PageSource;
                    if (this.OnCompleted != null)
                    {
                        this.OnCompleted(this, new OnCompletedEventArgs(uri, threadId, pageSource, milliseconds));
                    }
                }
                catch (Exception ex)
                {
                    if (this.OnError != null)
                    {
                        this.OnError(this, new OnErrorEventArgs(uri, ex));
                    }
                }
                finally
                {
                    driver.Close();
                    driver.Quit();
                }
            });
        }
    }
}
