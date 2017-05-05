
using System.Web.Mvc;

namespace WidgetDemo.Web.Controllers
{
    public class EasyUiController : AdminControllerBase
    {
        /// <summary>index </summary>
        /// <returns>页面</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}