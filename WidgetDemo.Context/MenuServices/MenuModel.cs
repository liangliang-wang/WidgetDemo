/* ***********************************************
 * Copyright (c) 同程旅游软件有限公司. All rights reserved.
 * Author :  alex
 * Project:  项目名称
 * Create:   2011-08-16 16:00:06 
 * ***********************************************/

using System.Collections.Generic;

namespace WidgetDemo.Context.MenuServices
{
    /// <summary> 系统菜单实体</summary>
    public class MenuModel
    {
        /// <summary> 英文名称</summary>
        public string Name { get; set; }
        /// <summary> 标题</summary>
        public string Title { get; set; }
        /// <summary> Url地址</summary>
        public string Url { get; set; }
        /// <summary> 序号</summary>
        public int OrderNo { get; set; }
        /// <summary>类型</summary>
        public int Mtype { get; set; }
        #region 为菜单准备的
        public string id { get; set; }
        public string text
        {
            get { return string.IsNullOrWhiteSpace(Url) ? Title : "<a href='" + Url + "'>" + Title + "</a>"; }
        }
        /// <summary>状态</summary>
        public string state { get; set; }
        /// <summary>图标</summary>
        public string iconCls { get { return Mtype > 9 ? "icon" + Mtype : ""; } }
        /// <summary>子菜单实体</summary>
        public List<MenuModel> children { get; set; }
        #endregion
    }
}
