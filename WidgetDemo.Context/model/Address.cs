using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 地址
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class Address
    {
        /// <summary>
        /// 线路1
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// 线路2
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        ///城市
        /// </summary>
        public CodeName City { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Telephone { get; set; }
    }
}
