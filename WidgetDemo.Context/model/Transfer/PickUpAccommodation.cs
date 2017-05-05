using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 接-食宿
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class PickUpAccommodation
    {
        /// <remarks/>
        public Place PickUpFrom { get; set; }

        /// <remarks/>
        public string PickUpTime { get; set; }
    }

}
