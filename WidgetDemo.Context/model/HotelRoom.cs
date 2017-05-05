using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 酒店房型
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class HotelRoom
    {
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 旅客Ids
        /// </summary>
        [XmlArrayItem("PaxId", IsNullable = false)]
        public List<string> PaxIds { get; set; }

        /// <summary>
        /// 房型Code
        /// </summary>
        [XmlAttribute()]
        public string Code { get; set; }

        /// <summary>
        /// 房型Id
        /// </summary>
        [XmlAttribute()]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool ExtraBed { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string NumberOfExtraBeds { get; set; }

        /// <summary>
        /// 分享床上用品
        /// </summary>
        [XmlAttribute()]
        public string SharingBedding { get; set; }

        /// <summary>
        /// 婴儿数
        /// </summary>
        [XmlAttribute()]
        public string NumberOfCots { get; set; }
    }

}
