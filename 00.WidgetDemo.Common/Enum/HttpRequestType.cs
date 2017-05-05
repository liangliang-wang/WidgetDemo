using System.ComponentModel;

namespace WidgetDemo.Common.Enum
{
    /// <summary>http请求类型 </summary>
    public enum HttpRequestType
    {
        /// <summary>Get </summary>
        [Description("Get")]
        Get=1,
        /// <summary>Post </summary>
        [Description("Post")]
        Post=2
    }
}
