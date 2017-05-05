using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetDemo.Context.model.edit;

namespace WidgetDemo.Context.model.Cancel
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CancelBookingRequest
    {
        /// <remarks/>
        public BookingReference BookingReference { get; set; }
    }

}
