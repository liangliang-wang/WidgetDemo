using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 送明细
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class DropOffDetails
    {
        /// <summary>
        /// 城市
        /// </summary>
        public CodeName City { get; set; }

        /// <summary>
        /// 送-食宿
        /// </summary>
        public DropOffAccommodation DropOffAccommodation { get; set; }

        /// <summary>
        /// 送-机场
        /// </summary>
        public DropOffAirport DropOffAirport { get; set; }

        /// <summary>
        /// 送-火车站
        /// </summary>
        public DropOffStation PickUpStation { get; set; }

        /// <summary>
        /// 送-码头
        /// </summary>
        public DropOffPort PickUpPort { get; set; }

        /// <summary>
        /// 送-其他
        /// </summary>
        public DropOffAccommodation DropOffOther { get; set; }
    }
}
