using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 停留时间
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class PeriodOfStay
    {
        /// <summary>
        /// 入住时间
        /// </summary>
        public string CheckInDate { get; set; }

        /// <summary>
        /// 退住时间
        /// </summary>
        public string CheckOutDate { get; set; }

        /// <summary>
        /// 停留时间
        /// </summary>
        public string Duration { get; set; }
    }
}
