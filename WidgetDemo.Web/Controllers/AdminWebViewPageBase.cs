using System;
using System.Configuration;
using System.Web.Mvc;

namespace WidgetDemo.Web.Controllers
{
    public abstract class AdminWebViewPageBase<TModel> : WebViewPage<TModel>
    {
        protected override void InitializePage()
        {
            base.InitializePage();
        }
        /// <summary>得到网站基础url</summary>
        public string BasePath
        {
            get
            {
                return Url.Content("~");
            }
        }

        /// <summary>
        /// 得到主机
        /// </summary>
        public string Host
        {
            get
            {
                return Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.IndexOf(Request.RawUrl)) + BasePath;
            }
        }

        /// <summary>
        /// 图片组件JS路径
        /// </summary>
        public string TcImageJsUrl
        {
            get { return ConfigurationManager.AppSettings["TCImageJsUrl"].ToString(); }
        }

        /// <summary>
        /// CDN文件版本
        /// </summary>
        public string Version
        {
            get
            {
                return DateTime.Now.ToString("yyyyMMddHHmm");
            }
        }
    }
}
