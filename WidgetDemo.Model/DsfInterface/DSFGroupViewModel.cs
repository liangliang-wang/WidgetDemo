using System.Collections.Generic;

namespace TC.Vacations.Entity.DsfInterface
{
    public class DSFGroupViewModel
    {
        public DSFGroupViewModel()
        {
            Interfaces = new List<InterfaceDataViewModel>();
        }

        /// <summary>
        /// 服务组名
        /// </summary>
        public string GroupName { set; get; }

        /// <summary>
        /// 版本
        /// </summary>
        public string Version { set; get; }

        /// <summary>
        /// 环境
        /// </summary>
        public string Environment { set; get; }

        /// <summary>
        /// 接口集合
        /// </summary>
        public List<InterfaceDataViewModel> Interfaces { set; get; }
    }
}
