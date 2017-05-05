using System.IO;
using System.Web.Mvc;
using Newtonsoft.Json;
using TC.Vacations.Entity.DsfInterface;

namespace WidgetDemo.Web.Controllers.DSFInterface
{
    public class DsfInterfaceController : AdminControllerBase
    {
        public ActionResult Index()
        {
            string json = string.Empty;
            using (var reader = new StreamReader(Request.InputStream))
            {
                json = reader.ReadToEnd();
            }
            var entity = JsonConvert.DeserializeObject<DSFGroupViewModel>(json);
            return View("~/Views/DSFInterface.cshtml", entity);
        }
    }
}