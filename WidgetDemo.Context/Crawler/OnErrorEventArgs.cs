using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemo.Context.Crawler
{
    /// <summary>
    /// 异常事件
    /// </summary>
    public class OnErrorEventArgs
    {
        /// <summary>
        /// 爬虫Uri
        /// </summary>
        public Uri Uri { get; private set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        public Exception Exception { get; private set; }

        public OnErrorEventArgs(Uri uri, Exception ex)
        {
            this.Uri = uri;
            this.Exception = ex;
        }
    }
}
