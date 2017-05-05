using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class DepartureTime
    {
        /// <remarks/>
        [XmlAttribute()]
        public bool NextDay { get; set; }

        /// <remarks/>
        [XmlText()]
        public decimal Value { get; set; }
    }


}
