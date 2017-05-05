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
    public class PaxName
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlAttribute()]
        public string PaxId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlAttribute()]
        public string PaxType { get; set; }

        /// <summary>
        /// 儿童年龄
        /// </summary>
        [XmlAttribute()]
        public string ChildAge { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ChildAgeSpecified { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

}
