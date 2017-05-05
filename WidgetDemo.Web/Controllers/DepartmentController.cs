using System;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WidgetDemo.Context;

namespace WidgetDemo.Web.Controllers
{
    /// <summary>部门Controller</summary>
    public class DepartmentController : AdminControllerBase
    {
        /// <summary> 部门Context </summary>
        private DepartmentContext depContext = new DepartmentContext();
        /// <summary>
        /// 获取树形归属部门
        /// </summary>
        /// <returns>JSON数据</returns>
        public ContentResult TreeForCombobox()
        {
            string json = string.Empty;
            try
            {
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                json = jsonSerializer.Serialize(depContext.GetDepartmentMapping());
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return Content(json , "text/html");
        }

    }
}
