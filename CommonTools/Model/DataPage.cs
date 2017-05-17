using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Model
{
    /// <summary>
    /// 分页信息
    /// </summary>
    public class DataPage
    {
        public const string PageIndexField = "PageIndex";
        public const string PageSizeField = "PageSize";


        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 页面大小
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 排序字段
        /// </summary>
        public string OrderField { get; set; }
        
        /// <summary>
        /// 数据总条数
        /// </summary>
        public long RowCount { get; set; }
    }
}
