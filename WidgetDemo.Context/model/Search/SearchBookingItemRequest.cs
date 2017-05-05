using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetDemo.Context.model.edit;

namespace WidgetDemo.Context.model.Search
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SearchBookingItemRequest
    {
        /// <remarks/>
        public BookingReference BookingReference { get; set; }

        /// <remarks/>
        public string ItemStatusCode { get; set; }

        /// <remarks/>
        public string ItemReference { get; set; }
    }

}
