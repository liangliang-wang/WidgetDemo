using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using WidgetDemo.Entity.Model;
using WidgetDemo.Entity.Persistence;
using WidgetDemo.Model;

namespace WidgetDemo.Context
{
    /// <summary>用户context</summary>
    public class FlightAlarmAddresseeContext
    {
        /// <summary>获取用户列表 </summary>
        /// <param name="nameValues">列表参数</param>
        /// <param name="page">分页信息</param>
        /// <returns>用户实体集合</returns>
        public List<FlightAlarmAddressee> GetList(NameValueCollection nameValues, DataPage page)
        {
            List<FlightAlarmAddressee> addresseeList = new List<FlightAlarmAddressee>();
            addresseeList = UserPersistence.GetList(nameValues, page);
            return addresseeList;
        }

        /// <summary>根据输入信息异步获取数据姓名+工号</summary>
        /// <param name="name">前台输入信息</param>
        /// <returns>搜索结果List</returns>
        public List<FlightAlarmAddressee> GetAjaxList(string name = null)
        {
            List<FlightAlarmAddressee> result = null;
            var allList = UserPersistence.GetAllList();
            const int SelectCount = 30;
            result = !string.IsNullOrEmpty(name)
                ? allList.Where(t => t.FAAName.Contains(name.Trim())).Take(SelectCount).ToList()
                : allList.Take(SelectCount).ToList();
            return result;
        }

        /// <summary>获取所有用户</summary>
        /// <returns>List数据</returns>
        public List<FlightAlarmAddressee> GetAllList()
        {
            return UserPersistence.GetAllList();
        }

    }
}
