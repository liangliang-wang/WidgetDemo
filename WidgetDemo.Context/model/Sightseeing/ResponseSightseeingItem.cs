using System.Collections.Generic;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 响应的观光项
    /// </summary>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class ResponseSightseeingItem
    {
        /// <summary>
        /// 日期
        /// </summary>
        public string TourDate{get; set; }

        /// <summary>
        /// 观光语言
        /// </summary>
        public TourLanguage TourLanguage{get; set; }

        /// <summary>
        /// 特殊项的代码
        /// </summary>
        public string SpecialCode{get; set; }

        /// <summary>
        /// 特殊项的描述
        /// </summary>
        public string SpecialItem{get; set; }

        /// <summary>
        /// 旅客
        /// </summary>
        [XmlArrayItem("PaxId")]
        public List<string> PaxIds{get; set; }

        /// <summary>
        /// 出发信息
        /// </summary>
        public TourDeparture TourDeparture{get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public CodeName TourSupplier { get;set;}

        /// <summary>
        /// 额外信息
        /// </summary>
        public string PleaseNote{get; set; }
    }
}
