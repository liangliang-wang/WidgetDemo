using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 预定明细
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class AddBookingRequestDetail
    {
        /// <summary>
        /// 预定名
        /// </summary>
        public string BookingName { get; set; }

        /// <summary>
        /// 预定唯一标示，同程订单号
        /// </summary>
        public string BookingReference { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        public string AgentReference { get; set; }

        /// <summary>
        /// 预定出发时间
        /// </summary>
        public string BookingDepartureDate { get; set; }

        /// <summary>
        /// 旅客邮箱（op邮箱）
        /// </summary>
        public string PassengerEmail { get; set; }

        /// <summary>
        /// 旅客集合
        /// </summary>
        [XmlArray()]
        [XmlArrayItem("PaxName", IsNullable = false)]
        public List<PaxName> PaxNames { get; set; }

        /// <summary>
        /// 预定项
        /// </summary>
        [XmlArrayItem("BookingItem", IsNullable = false)]
        public List<BookingItemRequest> BookingItems { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlAttribute()]
        public string Currency { get; set; }
    }

}
