using System.Collections.Generic;
using WidgetDemo.Entity.Model;

namespace WidgetDemo.Models
{
    /// <summary>部门根节点</summary>
    public class RootDep
    {
        /// <summary>Id</summary>
        public int id { get; set; }
        /// <summary>名称</summary>
        public string text { get; set; }
        /// <summary>子节点</summary>
        public List<ChildrenDep> children { get; set; }
    }
}