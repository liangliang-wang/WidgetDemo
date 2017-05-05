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
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Place
    {
        /// <summary>
        /// Meetingpoint
        /// </summary>
        public CodeName Meetingpoint { set; get; }

        /// <summary>
        /// Hotel
        /// </summary>
        public CodeName Hotel { get; set; }


        /// <summary>
        /// Address
        /// </summary>
        public Address Address { get; set; }

    }


}
