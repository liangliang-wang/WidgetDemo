using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 接明细
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class PickUpDetails
    {
        /// <summary>
        /// 城市
        /// </summary>
        public CodeName City { get; set; }

        /// <summary>
        /// 接-食宿
        /// </summary>
        public PickUpAccommodation PickUpAccommodation { get; set; }

        /// <summary>
        /// 接-机场
        /// </summary>
        public PickUpAirport PickUpAirport { get; set; }

        /// <summary>
        /// 接-火车站
        /// </summary>
        public PickUpStation PickUpStation { get; set; }

        /// <summary>
        /// 接-码头
        /// </summary>
        public PickUpPort PickUpPort { get; set; }

        /// <summary>
        /// 接-其他
        /// </summary>
        public PickUpAccommodation PickUpOther { get; set; }
    }
}
