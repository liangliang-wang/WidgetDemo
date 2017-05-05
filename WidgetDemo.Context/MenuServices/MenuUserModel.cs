//======================================================================
// Copyright (c) 苏州同程旅游网络科技有限公司. All rights reserved.
// 所属项目：TCWeb.Core.MenuServices
// 创 建 人：tc01241
// 创建日期：3/14/2011 2:36:05 PM
// 用    途：请一定在此描述类用途
//====================================================================== 
namespace WidgetDemo.Context.MenuServices
{
    public class MenuUserModel
    {
        /// <summary> 用户Id</summary>
        public int UserId { get; set; }
        /// <summary> 用户名称</summary>
        public string Name { get; set; }
        /// <summary> 工号</summary>
        public string JobNumber { get; set; }
        /// <summary> 密码</summary>
        public string Pwd { get; set; }
        /// <summary> 性别</summary>
        public string Gender { get; set; }
        /// <summary> 身份证号</summary>
        public string IdCard { get; set; }
        /// <summary> 部门名称</summary>
        public string DepartName { get; set; }
        /// <summary> 创建时间</summary>
        public string CrtTime { get; set; }
        /// <summary> 修改时间</summary>
        public string MdfTime { get; set; }
        /// <summary> 是否有效</summary>
        public string Enable { get; set; }
        /// <summary> 备注</summary>
        public string Remark { get; set; }
        /// <summary> 部门名称</summary>
        public string DptName { get; set; }
        /// <summary>
        /// 部门Id
        /// </summary>
        public string DeptId { get; set; }
    }
}
