using System;

namespace TC.Vacations.Entity.DsfInterface
{
    /// <summary>
    /// 类型的属性
    /// </summary>
    [Serializable]
    public class PropertyViewModel
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 属性的值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 文档注释
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 属性类型
        /// </summary>
        public TypeViewModel Type { get; set; }

        /// <summary>
        /// 是否必传
        /// </summary>
        public bool IsClass { get; set; }
    }
}