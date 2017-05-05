using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 房间
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class HotelPaxRoom
    {
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 旅客Id
        /// </summary>
        [XmlArray()]
        [XmlArrayItem("PaxId", IsNullable = false)]
        public List<string> PaxIds { get; set; }

        /// <summary>
        /// 成人数
        /// </summary>
        [XmlAttribute()]
        public string Adults { get; set; }

        /// <summary>
        /// 儿童数
        /// </summary>
        [XmlAttribute()]
        public string Children { get; set; }

        /// <summary>
        /// 婴儿数
        /// </summary>
        [XmlAttribute()]
        public string Cots { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool SharingBedding { get; set; }
    }

}
