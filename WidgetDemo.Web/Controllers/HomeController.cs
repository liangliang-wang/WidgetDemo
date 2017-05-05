using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WidgetDemo.Context;
using WidgetDemo.Entity.Model;

namespace WidgetDemo.Web.Controllers
{
    /// <summary>主Controller</summary>
    public class HomeController : AdminControllerBase
    {
        /// <summary>业务逻辑</summary>
        private readonly FlightAlarmAddresseeContext flightAlarmAddresseeContext = new FlightAlarmAddresseeContext();

        /// <summary>index </summary>
        /// <returns>页面</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>List</summary>
        /// <returns>json</returns>
        public ContentResult List()
        {
            string json = string.Empty;
            //分页,当前页数已经在基类 AdminControllerBase 获取好了
            var page = Pager;
            //调用业务逻辑层，根据Request.Form中的条件检索数据
            List<FlightAlarmAddressee> addresseeModelList = flightAlarmAddresseeContext.GetList(Request.Form, page);
            Pager = page;
            //把List<AlarmAddresseeModel>转换成EasyUI datagrid需要的分页Json格式;
            json = ToJson<FlightAlarmAddressee>(addresseeModelList, Int32.Parse(page.RowCount.ToString()));

            return Content(json, "text/html");
        }

        /// <summary>根据输入信息异步获取数据</summary>
        /// <returns>JSON数据</returns>
        public ActionResult AjaxListForCombogrid()
        {
            string json = string.Empty;

            List<FlightAlarmAddressee> addresseeModelList = flightAlarmAddresseeContext.GetAjaxList(Request.Form["q"]);
            json = ToJson<FlightAlarmAddressee>(addresseeModelList, 0);

            return Content(json);
        }

        /// <summary> 获取所有的用户信息</summary>
        /// <returns>所有的用户信息</returns>
        public ContentResult ListAllAlarmName()
        {
            int rowCount = 0;
            List<FlightAlarmAddressee> list = flightAlarmAddresseeContext.GetAllList();
            string json = ToJson<FlightAlarmAddressee>(list, rowCount);
            return Content(json, "text/html");
        }
    }
}
