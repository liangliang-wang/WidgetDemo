using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 接-机场
    /// </summary>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class PickUpAirport
    {
        /// <summary>
        /// 出发地
        /// </summary>
        public ArrivingFrom ArrivingFrom { get; set; }

        /// <summary>
        /// 航班
        /// </summary>
        public string FlightNumber { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        public string EstimatedArrival { get; set; }
    }
}
