﻿using System.Collections.Generic;

namespace CommonTools.FrameWork
{
    public class FrameWorkItem
    {
        public FrameWorkItem()
        {
            SqlParam = new Dictionary<string, object>();
        }

        /// <summary>
        /// sql语句
        /// </summary>
        public string Sql { get; set; }

        /// <summary>
        /// SQL参数
        /// </summary>
        public Dictionary<string,object> SqlParam { set; get; }
    }
}
