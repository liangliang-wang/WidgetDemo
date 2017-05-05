namespace WidgetDemo.Entity.Model
{
    /// <summary>部门实体</summary>
    public class DepartmentModel
    {
        /// <summary>Id</summary>
        public int Id { set; get; }

        /// <summary>部门名称</summary>
        public string Name { set; get; }

        /// <summary>部门编号</summary>
        public int DepNumber { set; get; }

        /// <summary>父级部门Id</summary>
        public int FId { set; get; }
    }
}
