using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 接-机场
    /// </summary>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DropOffAirport
    {
        /// <summary>
        /// 出发地
        /// </summary>
        public ArrivingFrom DepartingTo { get; set; }

        /// <summary>
        /// 航班
        /// </summary>
        public string FlightNumber { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        public DepartureTime DepartureTime { get; set; }
    }
}
