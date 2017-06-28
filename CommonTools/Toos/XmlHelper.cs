using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CommonTools.Tools
{
    public static class XmlHelper
    {
        /// <summary>
        /// 获取xml结点的属性值
        /// </summary>
        /// <param name="element">结点</param>
        /// <param name="attrName">属性名称</param>
        /// <returns>结果</returns>
        public static string GetAttrValue(this XElement element, string attrName)
        {
            string result = string.Empty;
            var nameAttr = element.Attribute(attrName);
            if (nameAttr != null)
            {
                result = nameAttr.Value;
            }
            return result;
        }

        /// <summary>
        /// 获取结点下的子节点的属性值
        /// </summary>
        /// <param name="element">当前节点</param>
        /// <param name="eleName">子节点值</param>
        /// <param name="attrName">属性值</param>
        /// <returns>结果</returns>
        public static string GetElementAttrValue(this XElement element, string eleName, string attrName)
        {
            string result = string.Empty;
            var subEle = element.Element(eleName);
            if (subEle != null)
            {
                var nameAttr = subEle.Attribute(attrName);
                if (nameAttr != null)
                {
                    result = nameAttr.Value;
                }
            }
            return result;
        }
    }
}
