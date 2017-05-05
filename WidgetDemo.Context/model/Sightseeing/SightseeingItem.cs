
using System.Collections.Generic;
using System.Xml.Serialization;
namespace WidgetDemo.Context.model
{

    /// <summary>
    /// 观光Item
    /// </summary>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class SightseeingItem
    {
        /// <summary>
        /// 旅游日期
        /// </summary>
        [XmlElement()]
        public string TourDate{get; set; }

        /// <summary>
        /// 旅游语言
        /// </summary>
        public TourLanguage TourLanguage { get; set; }

        /// <summary>
        /// 特殊项
        /// </summary>
        public CodeName SpecialItem{get; set; }

        /// <summary>
        /// 人员
        /// </summary>
        [XmlArrayItem("PaxId", IsNullable = false)]
        public List<string> PaxIds{get; set; }

        /// <summary>
        /// 旅游出发信息
        /// </summary>
        public TourDeparture TourDeparture{get; set; }
    }
}
