using System.Collections.Generic;

namespace WidgetDemo.Entity.Model
{
    /// <summary>部门树子节点</summary>
    public class ChildrenDep
    {
        /// <summary>id </summary>
        public int id { get; set; }

        /// <summary>名称</summary>
        public string text { get; set; }

        /// <summary>子节点 </summary>
        public List<ChildrenDep> children { get; set; }

        /// <summary>公司部门ID</summary>
        public int CompanyId { get; set; }
    }
}