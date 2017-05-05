using System.Web.Mvc;

namespace WidgetDemo.Web.Controllers
{
    /// <summary>云适应</summary>
    public class AmazeController : AdminControllerBase
    {
        /// <summary>index页 </summary>
        /// <returns>view视图</returns>
        public ActionResult Index()
        {
            return View();
        }

    }
}
