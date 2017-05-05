/* ***********************************************
 * Copyright (c) 同程旅游软件有限公司. All rights reserved.
 * Author :  alex
 * Project:  项目名称
 * Create:   2011-03-14 11:28:43 
 * ***********************************************/

using System.Collections.Generic;

namespace WidgetDemo.Context.MenuServices
{
    public class MenuResponseModel
    {
        public MenuResponseModel()
        {
            UserEntity = new MenuUserModel();
            MenuEntity = new List<MenuModel>();
            MenuUrl = new Dictionary<string, MenuModel>();
        }
        /// <summary>用户实体</summary>
        public MenuUserModel UserEntity { get; set; }
        /// <summary>菜单实体 </summary>
        public List<MenuModel> MenuEntity { get; set; }
        /// <summary>所有的菜单</summary>
        public Dictionary<string, MenuModel> MenuUrl { get; set; }
    }
}
