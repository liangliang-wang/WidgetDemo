using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 接-港口
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class PickUpPort
    {
        /// <summary>
        /// 来自
        /// </summary>
        public string ArrivingFrom { get; set; }

        /// <summary>
        /// 船名
        /// </summary>
        public string ShipName { get; set; }

        /// <summary>
        /// 运输公司
        /// </summary>
        public string ShippingCompany { get; set; }

        /// <summary>
        ///预计到达时间
        /// </summary>
        public string EstimateArrival { get; set; }
    }

}
