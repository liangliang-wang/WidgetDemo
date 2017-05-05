using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemo.Model
{
    public  class DataPage
    {
        public const string PageSizeField = "PageSize";
        public const string PageIndexField = "PageIndex";
        public const string RowCountField = "RowCount";
        public const string PageCountField = "PageCount";
        public const string OrderFieldName = "OrderField";
        public static List<string> Columns { get; set; }
        public double ExeTime { get; set; }
        public string OrderField { get; set; }
        public int RowSkip { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string Msg { get; set; }
        public long RowCount { get; set; }
    }
}
