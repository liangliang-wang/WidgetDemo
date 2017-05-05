using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Xml;
using WidgetDemo.Entity.Model;
using WidgetDemo.Model;

namespace WidgetDemo.Entity.Persistence
{
    /// <summary>用户Persistence</summary>
    public class UserPersistence
    {
        /// <summary>Xml文件路径</summary>
        private static readonly string XMLPATH = "~/XML/User.xml";

        /// <summary>分页数据 </summary>
        /// <param name="nameValues">条件参数</param>
        /// <param name="page">分页信息</param>
        /// <returns>结果数据</returns>
        public static List<FlightAlarmAddressee> GetList(NameValueCollection nameValues, DataPage page)
        {
            List<FlightAlarmAddressee> allList = GetAllList();
            if (!string.IsNullOrEmpty(nameValues["FAAName"]))
            {
                allList = allList.Where(u => u.FAAName == nameValues["FAAName"]).ToList();
            }
            if (!string.IsNullOrEmpty(nameValues["FAAEmployeeId"]))
            {
                allList = allList.Where(u => u.FAAEmployeeId == Convert.ToInt32(nameValues["FAAEmployeeId"])).ToList();
            }
            page.RowCount = allList.Count;
            allList = allList.Skip((page.PageIndex - 1) * page.PageSize).Take(page.PageSize).ToList();
            
            return allList;
        }

        /// <summary>获取所有用户</summary>
        /// <returns>List数据</returns>
        public static List<FlightAlarmAddressee> GetAllList()
        {
            List<FlightAlarmAddressee> userList = new List<FlightAlarmAddressee>();
            XmlDocument xmlDocumnet = new XmlDocument();
            try
            {
                string path = System.Web.HttpContext.Current.Server.MapPath(XMLPATH);
                xmlDocumnet.Load(path);
                XmlNodeList userXmlList = null;
                if (xmlDocumnet.DocumentElement != null)
                {
                    userXmlList = xmlDocumnet.DocumentElement.SelectNodes("/userList/user");
                }
                userList = GetUserListByXml(userXmlList);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return userList;
        }

        /// <summary>Xml转化为实体List</summary>
        /// <param name="userXmlList">xml节点</param>
        /// <returns>实体List</returns>
        private static List<FlightAlarmAddressee> GetUserListByXml(XmlNodeList userXmlList)
        {
            List<FlightAlarmAddressee> userList = new List<FlightAlarmAddressee>();
            foreach (XmlNode dpt in userXmlList)
            {
                FlightAlarmAddressee entity = new FlightAlarmAddressee();
                if (dpt.Attributes != null)
                {
                    entity.FAAId = Convert.ToInt32(dpt.Attributes["FAAId"].Value);
                    entity.FAAName = dpt.Attributes["FAAName"].Value;
                    entity.FAAEmployeeId = Convert.ToInt32(dpt.Attributes["FAAEmployeeId"].Value);
                    userList.Add(entity);
                }
            }
            return userList;
        }


    }
}
