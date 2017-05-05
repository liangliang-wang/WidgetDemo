
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 交通工具
    /// </summary>
    [XmlType(AnonymousType = true)]
    public partial class Vehicle
    {
        /// <summary>
        /// 工具代码
        /// </summary>
        [XmlAttribute()]
        public string Code { get; set; }

        /// <summary>
        /// 最大乘客数
        /// </summary>
        [XmlAttribute()]
        public string MaximumPassengers { get; set; }
    }
}
