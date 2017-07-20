using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetDemo.Model.EntityFrameWorkModel;
using CommonTools.FrameWork;
using CommonTools.Enums;

namespace WidgetDemo.DAL.Persistence
{
    public class EntityFrameWorkTest
    {
        public void Insert()
        {
            TestEntity t = new TestEntity { Name = "wl"};
            var s = t.GetInsertSql();
            var en = new EntityFrameWork<TestEntity>(DBType.MYSQL);
            var s1 = en.Add<TestEntity>(t,"");
        }
    }
}
