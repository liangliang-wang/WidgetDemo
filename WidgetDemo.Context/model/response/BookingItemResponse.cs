using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model.response
{
    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public partial class BookingItemResponse
    {
        /// <remarks/>
        public string ItemReference { get; set; }

        /// <remarks/>
        public CodeName ItemCity { get; set; }

        /// <remarks/>
        public CodeName Item { get; set; }

        /// <remarks/>
        public ItemPrice ItemPrice { get; set; }

        /// <remarks/>
        public CodeName Offer { get; set; }

        /// <remarks/>
        public CodeName ItemStatus { get; set; }

        /// <remarks/>
        [XmlArrayItem("ItemRemark")]
        public List<CodeName> ItemRemarks { get; set; }

        /// <remarks/>
        public string ItemPayableBy { get; set; }

        /// <remarks/>
        [XmlArrayItem("Information")]
        public EssentialInformation EssentialInformation { get; set; }

        /// <remarks/>
        public HotelItem HotelItem { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ItemType { get; set; }
    }
}