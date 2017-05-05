using System;
using System.Threading.Tasks;

namespace WidgetDemo.Context.Crawler
{
    public interface ICrawler
    {
        /// <summary>
        /// 开始事件
        /// </summary>
        event EventHandler<OnStartEventArgs> OnStart;

        /// <summary>
        /// 完成事件
        /// </summary>
        event EventHandler<OnCompletedEventArgs> OnCompleted;

        /// <summary>
        /// 爬虫异常事件
        /// </summary>
        event EventHandler<OnErrorEventArgs> OnError;

        /// <summary>
        /// 启动爬虫进程
        /// </summary>
        /// <param name="uri">uri</param>
        /// <returns>任务</returns>
        Task Start(Uri uri);
    }
}
