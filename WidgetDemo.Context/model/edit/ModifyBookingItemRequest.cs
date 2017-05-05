using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model.edit
{
    /// <remarks/>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class ModifyBookingItemRequest
    {
        /// <remarks/>
        public BookingReference BookingReference { get; set; }

        /// <remarks/>
        [XmlArrayItem("BookingItem", IsNullable = false)]
        public List<BookingItemRequest> BookingItems { get; set; }
    }

}
