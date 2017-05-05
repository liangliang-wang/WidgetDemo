using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WidgetDemo.Context.model.edit;

namespace WidgetDemo.Context.model
{
    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class ModifyBookingRequest
    {
        /// <remarks/>
        public BookingReference BookingReference { get; set; }

        /// <remarks/>
        public string AgentReference { get; set; }

        /// <remarks/>
        public string BookingDepartureDate { get; set; }

        /// <remarks/>
        public string PassengerEmail { get; set; }

        /// <remarks/>
        [XmlArrayItem("PaxName")]
        public List<PaxName> PaxNames { get; set; }

    }
}
