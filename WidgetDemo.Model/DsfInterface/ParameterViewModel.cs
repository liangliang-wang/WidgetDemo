using System;

namespace TC.Vacations.Entity.DsfInterface
{
    /// <summary>
    /// 参数类型
    /// </summary>
    [Serializable]
    public class ParameterViewModel
    {
        /// <summary>
        /// 参数名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 文档注释
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        public TypeViewModel Type { get; set; }

        /// <summary>
        /// 是否应用类型
        /// </summary>
        public bool IsClass { get; set; }
    }
}