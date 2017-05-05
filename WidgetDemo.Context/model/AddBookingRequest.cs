using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// GTA预定请求实体
    /// </summary>
    /// <remarks/>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AddBookingRequest
    {
        /// <remarks/>
        public RequestSource Source { get; set; }

        /// <remarks/>
        public RequestDetails RequestDetails { get; set; }

    }
}
