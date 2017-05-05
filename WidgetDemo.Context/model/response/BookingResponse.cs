using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WidgetDemo.Context.model.edit;

namespace WidgetDemo.Context.model.response
{
    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class BookingResponse
    {
        /// <remarks/>
        [XmlArrayItem("BookingReference")]
        public List<BookingReference> BookingReferences { get; set; }

        /// <remarks/>
        public string BookingCreationDate { get; set; }

        /// <remarks/>
        public string BookingDepartureDate { get; set; }

        /// <remarks/>
        public string BookingName { get; set; }

        /// <remarks/>
        public string BookingFees { get; set; }

        /// <remarks/>
        public string PassengerEmail { get; set; }

        /// <remarks/>
        public BookingPrice BookingPrice { get; set; }

        /// <remarks/>
        public CodeName BookingStatus { get; set; }

        /// <remarks/>
        [XmlArrayItem("PaxName")]
        public List<PaxName> PaxNames { get; set; }

        /// <remarks/>
        [XmlArrayItem("BookingItem", IsNullable = false)]
        public List<BookingItemResponse> BookingItems { get; set; }
    }

    
}
