using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 旅游语言
    /// </summary>
    [XmlType(AnonymousType = true)]
    public partial class TourLanguage
    {
        /// <summary>
        /// 语言代码
        /// </summary>
        [XmlAttribute()]
        public string Code { get; set; }

        /// <summary>
        /// 语言列表代码-
        /// </summary>
        [XmlAttribute()]
        public string LanguageListCode { get; set; }
    }
}
