using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetDemo.Context.Crawler
{
    /// <summary>
    /// 爬虫启动事件
    /// </summary>
    public class OnStartEventArgs
    {
        /// <summary>
        /// 爬虫地址
        /// </summary>
        public Uri Uri { set; get; }

        public OnStartEventArgs(Uri uri)
        {
            this.Uri = uri;
        }

    }
}
