using System.Collections.Generic;
using System.Xml.Serialization;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 接送Item
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class TransferItem
    {

        /// <summary>
        /// 接明细
        /// </summary>
        public PickUpDetails PickUpDetails { get; set; }

        /// <summary>
        /// 送明细
        /// </summary>
        public DropOffDetails DropOffDetails { get; set; }

        /// <summary>
        /// 接送日期
        /// </summary>
        [XmlElement()]
        public string TransferDate { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        public string TransferLanguage { get; set; }

        /// <summary>
        /// 接送工具
        /// </summary>
        public TransferVehicle TransferVehicle { get; set; }

        /// <summary>
        /// 接送条件
        /// </summary>
        [XmlArrayItem("TransferCondition")]
        public List<string> TransferConditions { set; get; }
    }

}
