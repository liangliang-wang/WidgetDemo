using System.Collections.Generic;

namespace TC.Vacations.Entity.DsfInterface
{
    public class MethodDataViewMode
    {
        public string Name { set; get; }


        /// <summary>
        /// 摘要
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 方法定义
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// 名称空间
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// 参数集合
        /// </summary>
        public List<PropertyViewModel> Parameters { get; set; }

        /// <summary>
        /// 返回类型
        /// </summary>
        public TypeViewModel ReturnType { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 返回注释
        /// </summary>
        public string ReturnDocument { get; set; }

    }
}
