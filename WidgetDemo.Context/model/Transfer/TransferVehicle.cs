
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 接送工具
    /// </summary>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class TransferVehicle
    {
        /// <summary>
        /// 工具
        /// </summary>
        public Vehicle Vehicle { get; set; }

        /// <summary>
        /// 旅客数
        /// </summary>
        public string Passengers { get; set; }

        /// <summary>
        /// 旅客负责人
        /// </summary>
        public string LeadPaxId { get; set; }
    }
}
