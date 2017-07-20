using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WidgetDemo.DAL.Persistence;

namespace WidgetDemo.Web.Controllers
{
    public class TestController : AdminControllerBase
    {
        /// <summary>添加redis </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <returns>结果</returns>
        public void Insert(string key, string value)
        {
            new EntityFrameWorkTest().Insert();
        }
    }
}