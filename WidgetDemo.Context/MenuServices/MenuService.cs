/* ***********************************************
 * Copyright (c) 同程旅游软件有限公司. All rights reserved.
 * Author :  alex
 * Project:  项目名称
 * Create:   2011-08-16 13:24:43 
 * Modeify: 2013/8/27周二 @乐章
 * ***********************************************/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Xml;
using WidgetDemo.Common;

namespace WidgetDemo.Context.MenuServices
{
    public class MenuService
    {
        /// <summary>项目代码</summary>
        public static string Projcode;//任务调度
        public static string ServiceUrl;
        static MenuService()
        {
            ServiceUrl = ConfigurationManager.AppSettings["AuthorityServiceUrl"];
            Projcode = ConfigurationManager.AppSettings["AuthorityProjectCode"];
        }
        public ErrorMessage Login(string loginName, string password)
        {
            ErrorMessage message;
            MenuRequest request = new MenuRequest
            {
                Service = "login",
                ProjCode = Projcode,
                JobNumber = loginName,
                Pwd = password,
                ServiceUrl = ServiceUrl
            };
            ChangePwd(request, out message);
            return message;
        }
        public MenuResponseModel GetMenuAndUserInfo(string loginName, string password)
        {
            ErrorMessage message;
            MenuRequest request = new MenuRequest
            {
                Service = "getmenus",
                ProjCode = Projcode,
                JobNumber = loginName,
                Pwd = password,
                ServiceUrl = ServiceUrl
            };
            return GetMenuAndUserInfo(request, out message);
        }
        static readonly Regex ParameterRegex = new Regex(@"/\d+$", RegexOptions.Compiled);//sql语句里的参数
        /// <summary> 得到菜单需要判断权限的url</summary>
        /// <param name="rawUrl">Request.RawUrl,不包含域名的url</param>
        /// <returns>需要判断权限的url</returns>
        public static string GetMenuUrl(string rawUrl)
        {
            //以后复杂权限,可能会有一些if
            return ParameterRegex.Replace(rawUrl.Split('?')[0].Trim().ToLower(), "");
        }
        /// <summary>获取用户和菜单信息</summary>
        /// <param name="request">请求字段</param>
        /// <param name="message">错误信息</param>
        /// <returns>响应信息</returns>
        public MenuResponseModel GetMenuAndUserInfo(MenuRequest request, out ErrorMessage message)
        {

            //var item = HttpUtil.PostResponse(request.ServiceUrl, request.PostData, "gb2312", "application/x-www-form-urlencoded");
            var item = HttpHelper.PostRequest(request.ServiceUrl, request.PostData, 3000, "gb2312");
            XmlNodeList menuNodes;
            XmlNodeList userNodes;
            var root = Check(item, out menuNodes, out message, out userNodes);//检查数据
            if (null == root) return null;
            var menuResponse = new MenuResponseModel();
            var userInfo = new MenuUserModel();
            for (var i = 0; i < userNodes.Count; i++)
            {
                var result = (XmlElement)userNodes[i];
                if (result == null) continue;
                userInfo.UserId = Convert.ToInt32(result["userId"].InnerText);
                userInfo.Name = result["name"].InnerText;
                userInfo.JobNumber = result["jobNumber"].InnerText;
                userInfo.Gender = result["gender"].InnerText;
                userInfo.IdCard = result["IdCard"].InnerText;
                userInfo.DepartName = result["departName"].InnerText;
                userInfo.DeptId = result["dptid"].InnerText;
            }
            var menulist = new List<MenuModel>();
            for (var i = 0; i < menuNodes.Count; i++)
            {
                var result = (XmlElement)menuNodes[i];
                if (result == null) continue;
                XmlNodeList xmlNodeList = result.SelectNodes("menu");
                for (var j = 0; j < xmlNodeList.Count; j++)
                {
                    var menu = new MenuModel();
                    var menunode = (XmlElement)xmlNodeList[j];
                    if (menunode == null) continue;
                    menu.id = menunode.GetAttribute("id");
                    menu.Name = menunode.GetAttribute("name");
                    menu.Title = menunode.GetAttribute("title");
                    menu.Url = menunode.GetAttribute("url");
                    menu.OrderNo = Convert.ToInt32(menunode.GetAttribute("orderNo"));
                    menu.children = GetMenu(menunode, menuResponse);
                    menulist.Add(menu);
                    string url = GetMenuUrl(menu.Url);
                    if (!string.IsNullOrWhiteSpace(url) && !menuResponse.MenuUrl.ContainsKey(url))
                        menuResponse.MenuUrl.Add(url, menu);
                }
            }
            message = null;
            menuResponse.MenuEntity = menulist;
            menuResponse.UserEntity = userInfo;
            return menuResponse;
        }
        /// <summary> 获取用户信息</summary>
        /// <param name="request">请求字段</param>
        /// <param name="message">错误信息</param>
        /// <returns>响应信息</returns>
        public MenuResponseModel GetUserInfo(MenuRequest request, out ErrorMessage message)
        {
            //var item = HttpUtil.PostResponse(request.ServiceUrl, request.PostUserIdData, "gb2312", "application/x-www-form-urlencoded");
            var item = HttpHelper.PostRequest(request.ServiceUrl, request.PostData, 3000, "gb2312");
            XmlNodeList userNodes;
            var root = CheckUserInfo(item, out userNodes, out message);//检查用户数据
            if (null == root) return null;
            var menuResponse = new MenuResponseModel();
            var userInfo = new MenuUserModel();
            for (var i = 0; i < userNodes.Count; i++)
            {
                var result = (XmlElement)userNodes[i];
                if (result == null) continue;
                // ReSharper disable PossibleNullReferenceException
                userInfo.Name = result["userId"].InnerText;
                userInfo.Name = result["name"].InnerText;
                userInfo.JobNumber = result["jobNumber"].InnerText;
                userInfo.Gender = result["gender"].InnerText;
                userInfo.IdCard = result["IdCard"].InnerText;
                userInfo.DepartName = result["departName"].InnerText;
                userInfo.CrtTime = result["crtTime"].InnerText;
                userInfo.MdfTime = result["mdfTime"].InnerText;
                userInfo.Enable = result["enable"].InnerText;
                userInfo.Remark = result["remark"].InnerText;
                userInfo.DptName = result["dptName"].InnerText;
                // ReSharper restore PossibleNullReferenceException
            }
            return menuResponse;
        }
        public bool ChangePwd(MenuRequest request, out ErrorMessage message)
        {
            //var item = HttpUtil.PostResponse(request.ServiceUrl, request.PostData, "gb2312", "application/x-www-form-urlencoded");
            var item = HttpHelper.PostRequest(request.ServiceUrl, request.PostData, 3000, "gb2312");
            var root = CheckResult(item, out message);//检查数据
            message.Result = (root != null && root["st"] != null && root["st"].InnerText.Equals("1"));
            if (!message.Result) message.Message = root == null ? "" : root.InnerText;
            return message.Result;
        }
        /// <summary> 解析menu字段</summary>
        /// <param name="nodeList">xml节点</param>
        /// <returns>Menu实体列表</returns>
        private static List<MenuModel> GetMenu(XmlElement nodeList, MenuResponseModel menuResponse)
        {
            var menuList = new List<MenuModel>();
            XmlNodeList xmlNodeList = nodeList.SelectNodes("menu");
            if (xmlNodeList != null)
                for (var j = 0; j < xmlNodeList.Count; j++)
                {
                    var menu = new MenuModel();
                    var menunode = (XmlElement)xmlNodeList[j];
                    if (menunode == null) continue;
                    menu.id = menunode.GetAttribute("id");
                    menu.Name = menunode.GetAttribute("name");
                    menu.Title = menunode.GetAttribute("title");
                    menu.Url = menunode.GetAttribute("url");
                    menu.OrderNo = Convert.ToInt32(menunode.GetAttribute("orderNo"));
                    menu.Mtype = Convert.ToInt32(menunode.GetAttribute("mtype"));
                    menu.children = GetMenu(menunode, menuResponse);
                    if (menu.Mtype > 0) menuList.Add(menu);
                    string url = GetMenuUrl(menu.Url);
                    if (!string.IsNullOrWhiteSpace(url) && !menuResponse.MenuUrl.ContainsKey(url))
                        menuResponse.MenuUrl.Add(url, menu);
                }
            return menuList;
        }
        /// <summary> 检查用户数据的正确性</summary>
        /// <param name="item">查询字符</param>
        /// <param name="message">错误的消息</param>
        /// <param name="userList">用户信息</param>
        /// <returns>数据元素树</returns>
        private static XmlElement CheckUserInfo(string item, out XmlNodeList userList, out ErrorMessage message)
        {
            message = new ErrorMessage();
            userList = null;
            if (string.IsNullOrEmpty(item))
            {
                message.No = "000";
                return null;
            }
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(item);
            var root = xmlDocument.DocumentElement;
            if (null == root)
            {
                message.No = "000";
                return null;
            }
            userList = root.SelectNodes("userInfo");
            if (userList == null)
            {
                message.No = "000";
                return null;
            }
            if (userList.Count.Equals(0))
            {
                message.No = root.SelectNodes("st")[0x0].InnerText;
                return null;
            }
            return root;
        }
        /// <summary> 检查用户数据的正确性</summary>
        /// <param name="item">查询字符</param>
        /// <param name="message">错误的消息</param>
        /// <returns>数据元素树</returns>
        public static XmlElement CheckResult(string item, out ErrorMessage message)
        {
            message = new ErrorMessage();
            if (string.IsNullOrEmpty(item))
            {
                message.No = "000";
                return null;
            }
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(item);
            var root = xmlDocument.DocumentElement;
            if (null == root)
            {
                message.No = "000";
                return null;
            }
            return root;
        }
        /// <summary> 检查数据的正确性</summary>
        /// <param name="item">查询字符</param>
        /// <param name="message">错误的消息</param>
        /// <param name="menuList">元素列表</param>
        /// <param name="userList"></param>
        /// <returns>数据元素树</returns>
        private static XmlElement Check(string item, out XmlNodeList menuList, out ErrorMessage message, out XmlNodeList userList)
        {
            message = new ErrorMessage();
            menuList = null;
            userList = null;
            if (string.IsNullOrEmpty(item))
            {
                message.No = "000";
                return null;
            }
            //if (item.IndexOf("获取") == 0) return null;
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(item);
            var root = xmlDocument.DocumentElement;
            if (null == root)
            {
                message.No = "000";
                return null;
            }
            // ReSharper disable PossibleNullReferenceException
            var detailInfo = (XmlElement)root.SelectNodes("detailInfo")[0];
            if (null==detailInfo)
            {
                message.No = "000";
                return null;
            }
            // ReSharper restore PossibleNullReferenceException
            userList = detailInfo.SelectNodes("userInfo");
            if (userList == null)
            {
                message.No = "000";
                return null;
            }
            menuList = detailInfo.SelectNodes("menuList");
            if (menuList == null)
            {
                message.No = "000";
                return null;
            }
            if (menuList.Count.Equals(0))
            {
                // ReSharper disable PossibleNullReferenceException
                message.No = root.SelectNodes("st")[0x0].InnerText;
                // ReSharper restore PossibleNullReferenceException
                return null;
            }
            return root;
        }
    }
}
