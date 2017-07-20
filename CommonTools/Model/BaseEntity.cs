using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Model
{
    public class BaseEntity
    {
        public string TableName { set; get; }

        public Tuple<string,Dictionary<string,object>> GetInsertSql()
        {
            string sql = string.Empty;
            List<string> values = new List<string>();
            List<string> param = new List<string>();
            var paramDic = new Dictionary<string,object>();
            var type = this.GetType();
            var propertise = type.GetProperties();
            foreach (var item in propertise)
            {
                var attrs = item.GetCustomAttributes(typeof(DBFieldAttribute), false);
                if (attrs.Count() > 0)
                {
                    var attr = attrs[0] as DBFieldAttribute;
                    var value = item.GetValue(this);
                    values.Add(attr.FieldName);
                    param.Add("@" + item.Name);
                    paramDic.Add("@" + item.Name, value);
                }
            }
            sql = string.Format("insert into {0} ({1}) values({2})", TableName, string.Join(",", values), string.Join(",", param));
            return new Tuple<string, Dictionary<string, object>>(sql, paramDic);
        }
    }
}
