using System.Collections.Generic;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 旅游出发信息
    /// </summary>
    [XmlType(AnonymousType = true)]
    public partial class TourDeparture
    {
        /// <summary>
        /// 出发时间
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 出发地点Code
        /// </summary>
        public CodeName DeparturePoint { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [XmlArrayItem("AddressLine")]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Telephone { get; set; }
    }
}
