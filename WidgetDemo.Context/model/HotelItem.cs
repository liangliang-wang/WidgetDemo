using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class HotelItem
    {
        /// <remarks/>
        public string AlternativesAllowed { get; set; }

        /// <summary>
        /// 停留时间
        /// </summary>
        public PeriodOfStay PeriodOfStay { get; set; }

        /// <summary>
        /// 房间
        /// </summary>
        [XmlArrayItem(ElementName = "HotelRoom")]
        public List<HotelRoom> HotelRooms { get; set; }

        /// <remarks/>
        public HotelPaxRoom HotelPaxRoom { get; set; }
    }

}
