using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    /// <summary>用linq创建、查询xml </summary>
    public class XmlCreateAndReadForLinq
    {
        /// <summary>构建XML </summary>
        /// <returns>xml</returns>
        public static string CreatXML()
        {
            XDocument xdoc = new XDocument(
                   new XElement("configuration"
                       , new XElement("ImgButtonSettings"
                           , new XElement("button", new XElement("name", "close", new XAttribute("id", "EFS"))
                                                , new XElement("size-w", 61)
                                                , new XElement("size-h", 56, new XAttribute("ff", 564))
                                                , new XElement("localtion-x", 970)
                                                , new XElement("localtion-y", 3)
                                                , new XElement("openurl", string.Empty)
                                                , new XElement("visable", "true")
                                       )
                           , new XElement("button", new XElement("name", "back", new XAttribute("id", "EFS"))
                                                , new XElement("size-w", 61)
                                                , new XElement("size-h", 56, new XAttribute("ff", 564))
                                                , new XElement("localtion-x", 990)
                                                , new XElement("localtion-y", 3)
                                                , new XElement("openurl", string.Empty)
                                                , new XElement("visable", "true")
                                       )
                                    )
                                )
                            );
            return xdoc.ToString();
        }

        /// <summary>查询XML</summary>
        /// <returns>结果</returns>
        public static string SearchXML()
        {
            string xmlFileName = @"f:\\testxml.xml";
            XDocument customers = XDocument.Load(xmlFileName);

            //获取所有子级别的属性及变种
            var queryResult = from c in customers.Descendants("localtion-x") select c;

            List<string> result = queryResult.Select(item => item.Value).ToList();

            return result.Count>0?result[0]:string.Empty;
        }
    }
}
