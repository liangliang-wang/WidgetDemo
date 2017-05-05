using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WidgetDemo.Entity.Model;
using WidgetDemo.Entity.Persistence;

namespace WidgetDemo.Context
{
    /// <summary>部门Context</summary>
    public class DepartmentContext
    {
        /// <summary>获取所有部门</summary>
        /// <returns>部门List</returns>
        public List<DepartmentModel> GetAllList()
        {
            List<DepartmentModel> depList = new List<DepartmentModel>();
            depList = DepartmentPersistence.GetAllList();
            return depList;
        }

        /// <summary>获取部门树</summary>
        /// <returns>部门树</returns>
        public List<ChildrenDep> GetTreeTable()
        {
            List<ChildrenDep> rootDepList = new List<ChildrenDep>();
            List<DepartmentModel> depList = GetAllList();
            if (depList.Count < 1)
            {
                return rootDepList;
            }
            List<DepartmentModel> rootList = depList.Where(d => d.FId == 0).ToList();
            foreach (DepartmentModel depModel in rootList)
            {
                ChildrenDep rootDep = new ChildrenDep();
                rootDep.id = depModel.Id;
                rootDep.text = depModel.Name;
                rootDep.children = new List<ChildrenDep>();
                getChildrenDeps(depList, rootDep);
                rootDepList.Add(rootDep);
            }
            return rootDepList;
        }
        /// <summary>获取子节点</summary>
        /// <param name="depList">所有部门信息</param>
        /// <param name="nodeDep">当前部门节点</param>
        private void getChildrenDeps(List<DepartmentModel> depList,ChildrenDep nodeDep)
        {

            List<DepartmentModel> rootList = depList.Where(d => d.FId == nodeDep.id).ToList();
            foreach (DepartmentModel depModel in rootList)
            {
                ChildrenDep rootDep = new ChildrenDep();
                rootDep.id = depModel.Id;
                rootDep.text = depModel.Name;
                rootDep.children = new List<ChildrenDep>();
                List<DepartmentModel> chindrenList = new List<DepartmentModel>();
                chindrenList = depList.Where(d => d.FId == rootDep.id).ToList();
                if (chindrenList.Count>0)
                {
                    getChildrenDeps(depList, rootDep);
                }
                nodeDep.children.Add(rootDep); 
            }
        }

        /// <summary>公司部门树 </summary>
        /// <returns>部门树</returns>
        public List<ChildrenDep> GetDepartmentMapping()
        {
            List<ChildrenDep> nodeList = new List<ChildrenDep>();
            var depList = GetAllList();
            //公司部门的根节点的父级节点ID473
            nodeList = GetTreeByList(depList, "473");
            return nodeList;
        }
        /// <summary>由List形成部门树 </summary>
        /// <param name="depList">部门List</param>
        /// <param name="fId">根节点的父节点</param>
        /// <returns>部门树</returns>
        public List<ChildrenDep> GetTreeByList(List<DepartmentModel> depList, string fId)
        {
            List<ChildrenDep> nodeList = new List<ChildrenDep>();
            var rootNode = depList.Where(t => t.FId == Convert.ToInt32(fId));
            foreach (var alarmAddressee in rootNode)
            {
                ChildrenDep node = new ChildrenDep();
                node.id = alarmAddressee.Id;
                node.text = alarmAddressee.Name;
                node.children = GetTreeByList(depList, alarmAddressee.Id.ToString(CultureInfo.InvariantCulture));
                nodeList.Add(node);
            }
            return nodeList;
        }
    }
}
