using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 接-站点
    /// </summary>
    [XmlType(AnonymousType = true)]
    public partial class PickUpStation
    {
        /// <summary>
        /// 车站
        /// </summary>
        public CodeName Station { get; set; }

        /// <summary>
        /// 地点
        /// </summary>
        public TransferPlace ArrivingFrom { get; set; }

        /// <summary>
        /// 列车名
        /// </summary>
        public string TrainName { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        public string EstimateArrival { get; set; }
    }
}
