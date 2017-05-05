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
    public class BookingItemRequest
    {
        /// <remarks/>
        public string ItemReference { get; set; }

        /// <remarks/>
        public CodeName ItemCity { get; set; }

        /// <remarks/>
        public CodeName Item { get; set; }

        /// <remarks/>
        [XmlArrayItem("ItemRemark")]
        public List<CodeName> ItemRemarks { get; set; }

        /// <remarks/>
        public HotelItem HotelItem { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string ItemType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ExpectedPrice { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public string ExpectedPriceSpecified { get; set; }
    }

}
