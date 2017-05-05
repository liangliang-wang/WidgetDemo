using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetDemo.Context.Crawler
{
    /// <summary>
    /// 爬虫完成事件
    /// </summary>
    public class OnCompletedEventArgs
    {
        /// <summary>
        /// 爬虫Uri
        /// </summary>
        public Uri Uri { private set; get; }

        /// <summary>
        /// 线程Id
        /// </summary>
        public int ThreadId { private set; get; }

        /// <summary>
        /// 页面内容
        /// </summary>
        public string PageSource { private set; get; }

        /// <summary>
        /// 耗时
        /// </summary>
        public long MilliSeconds { private set; get; }

        public OnCompletedEventArgs(Uri uri, int threadId, string pageSource, long milliSeconds)
        {
            this.Uri = uri;
            this.ThreadId = threadId;
            this.PageSource = pageSource;
            this.MilliSeconds = milliSeconds;
        }
    }
}
