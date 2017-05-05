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
    public class BookingPrice
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Currency { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Gross { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Commission { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Nett { get; set; }
    }
}
