using System;
using System.Collections.Generic;
using System.Xml;
using WidgetDemo.Entity.Model;

namespace WidgetDemo.Entity.Persistence
{
    /// <summary>部门Persistence</summary>
    public class DepartmentPersistence
    {
        /// <summary>Xml文件路径</summary>
        private static readonly string XMLPATH = "~/XML/Department.xml";

        /// <summary>获取所有用户</summary>
        /// <returns>List数据</returns>
        public static List<DepartmentModel> GetAllList()
        {
            List<DepartmentModel> userList = new List<DepartmentModel>();
            XmlDocument xmlDocumnet = new XmlDocument();
            string path = System.Web.HttpContext.Current.Server.MapPath(XMLPATH);
            xmlDocumnet.Load(path);
            XmlNodeList deptList = null;
            if (xmlDocumnet.DocumentElement != null)
            {
                deptList = xmlDocumnet.DocumentElement.SelectNodes("/rlt/deptList/dept");
            }
            userList = GetEntityByXml(deptList);
            return userList;
        }

        /// <summary>Xml转化为实体List</summary>
        /// <param name="depXmlList">xml节点</param>
        /// <returns>实体List</returns>
        private static List<DepartmentModel> GetEntityByXml(XmlNodeList depXmlList)
        {
            List<DepartmentModel> depList = new List<DepartmentModel>();
            foreach (XmlNode dpt in depXmlList)
            {
                DepartmentModel depModel = new DepartmentModel();
                if (dpt.Attributes != null && dpt.Attributes["enabled"].Value == "1")
                {

                    depModel.Id = Convert.ToInt32(dpt.Attributes["id"].Value);
                    depModel.Name = dpt.Attributes["name"].Value;
                    depModel.DepNumber = Convert.ToInt32(dpt.Attributes["id"].Value);

                    if (dpt.ParentNode != null && dpt.ParentNode.Attributes != null && dpt.ParentNode.Attributes.Count > 0)
                    {
                        depModel.FId = Convert.ToInt32(dpt.ParentNode.Attributes["id"].Value);
                    }
                    else
                    {
                        depModel.FId = 0;
                    }
                    depList.Add(depModel);
                    if (dpt.ChildNodes.Count > 0)
                    {
                        depList.AddRange(GetEntityByXml(dpt.ChildNodes));
                    }
                }
            }
            return depList;
        }


    }
}
