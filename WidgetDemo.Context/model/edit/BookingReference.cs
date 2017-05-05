using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model.edit
{
    /// <summary>
    /// 预定标识
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class BookingReference
    {
        /// <summary>
        /// 来源
        /// </summary>
        [XmlAttribute()]
        public string ReferenceSource { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [XmlText()]
        public string Value { get; set; }
    }

}
