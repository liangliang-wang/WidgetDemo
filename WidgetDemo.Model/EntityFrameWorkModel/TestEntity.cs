using CommonTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemo.Model.EntityFrameWorkModel
{
    public class TestEntity : BaseEntity
    {
        public string TableName = "TableName";

        [DBField(FieldName = "name")]
        public string Name { set; get; }
    }
}
