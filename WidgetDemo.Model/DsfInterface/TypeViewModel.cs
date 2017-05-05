using System;
using System.Collections.Generic;

namespace TC.Vacations.Entity.DsfInterface

{
    /// <summary>
    /// 参数类型
    /// </summary>
    [Serializable]
    public class TypeViewModel
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型全名
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 文档注释
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 类型程序集
        /// </summary>
        public string AssemblyFile { get; set; }

        /// <summary>
        /// 类型程序集名
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// 类型程序集路径
        /// </summary>
        public string AssemblyPath { get; set; }

        /// <summary>
        /// 父级类型链
        /// </summary>
        public string ParentChain { get; set; }

        /// <summary>
        /// 类型字段list
        /// </summary>
        public List<PropertyViewModel> Properties { get; set; }
    }
}