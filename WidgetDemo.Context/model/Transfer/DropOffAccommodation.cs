using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 送-食宿
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class DropOffAccommodation
    {
        /// <remarks/>
        public Place DropOffFrom { get; set; }
    }
}
