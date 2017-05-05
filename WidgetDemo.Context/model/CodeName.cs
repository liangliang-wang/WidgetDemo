using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    [XmlType(AnonymousType = true)]
    public class CodeName
    {
        [XmlAttribute]
        public string Code { get; set; }

        [XmlText]
        public string Name { get; set; }
    }
}
