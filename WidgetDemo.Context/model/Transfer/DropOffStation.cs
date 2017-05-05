
namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 送达站点
    /// </summary>
    public class DropOffStation
    {
        /// <summary>
        /// 车站信息
        /// </summary>
        public CodeName Station { get; set; }

        /// <summary>
        /// 地点
        /// </summary>
        public TransferPlace DepartingTo { get; set; }

        /// <summary>
        /// 列车名
        /// </summary>
        public string TrainName { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string DepartureTime { get; set; }
    }
}
