using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Routing;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WidgetDemo.Model;

namespace WidgetDemo.Web.Controllers
{
    public class AdminControllerBase : Controller
    {
        #region 分页
        private DataPage _pager;
        /// <summary>翻页DataPage</summary>
        public DataPage Pager
        {
            get
            {
                _pager = new DataPage { PageSize = 10, PageIndex = 1, PageCount = 1, RowCount = 0 };
                if (Request != null)
                {
                    if (Request[DataPage.PageIndexField] != null)
                        _pager.PageIndex = Request[DataPage.PageIndexField] == null ? 0 : int.Parse(Request[DataPage.PageIndexField]);
                    if (Request[DataPage.PageSizeField] != null)
                        _pager.PageSize = Request[DataPage.PageSizeField] == null ? 0 : int.Parse(Request[DataPage.PageSizeField]);
                }
                //Easyui 中的分页参数
                if (Request.Params["page"] != null)
                    _pager.PageIndex = Request.Params["page"] == null ? 0 : int.Parse(Request.Params["page"]);
                if (Request.Params["rows"] != null)
                    _pager.PageSize = Request.Params["rows"] == null ? 0 : int.Parse(Request.Params["rows"]);
                return _pager;
            }
            set
            {
                _pager = value;
                ViewData["DataPage"] = _pager;
            }
        }
        #endregion

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
        }
        protected new JsonResult Json(object data)
        {
            return base.Json(data, "text/plain", JsonRequestBehavior.AllowGet);
        }
        /// <summary>得到网站基础url</summary>
        public string BasePath
        {
            get
            {
                string basePath = Url.Content("~");
                //return basePath.Contains("/train/") ? "/train/" : basePath;
                return basePath;
            }
        }
        public void MessageBox(string message)
        {
            AddJs("alert('" + message.Trim() + "');");
        }
        /// <summary>显示ui信息</summary>
        /// <param name="con">ui信息,如$('#delMsg')</param>
        public void ShowUi(string con)
        {
            AddJs("$.blockUI({ message: " + con + ", showOverlay: true, border: 'none' });");
        }
        public void CloseFancybox()
        {
            AddJs("parent.$.fancybox.close();");
        }
        public void AddJs(string js)
        {
            if (ViewBag.script == null)
                ViewBag.script = js;
            else
                ViewBag.script += js;
        }
        #region ToJSON
        /// <summary>
        /// 把DataTable转换成EasyUI datagrid 分页需要的格式
        /// </summary>
        /// <param name="dt">表格</param>
        /// <param name="rowsCount">总共数据</param>
        /// <returns></returns>
        public string ToPageJson(DataTable dt, long rowsCount)
        {
            //if (dt == null || dt.Rows.Count == 0) return "";
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName.Trim());
                    jsonBuilder.Append("\":\"");
                    jsonBuilder.Append(Regex.Replace(dt.Rows[i][j].ToString().Trim(), @"[\a\b\f\n\r\t\v]+", " "));
                    jsonBuilder.Append("\",");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("},");
            }
            if (jsonBuilder.Length > 1)
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("]");

            if (rowsCount > 0)
                return string.Format("{0}\"total\":{3},\"rows\":{1}{2}", "{", jsonBuilder.ToString(), "}", rowsCount);
            else
                return jsonBuilder.ToString();
        }

        public string ToJson(DataTable dt, long rowsCount, string dateFormate = "yyyy-MM-dd HH:mm:ss")
        {
            IsoDateTimeConverter timeConverter = new IsoDateTimeConverter();
            timeConverter.DateTimeFormat = dateFormate;
            string json = JsonConvert.SerializeObject(dt, timeConverter);
            return string.Format("{0}\"total\":{3},\"rows\":{1}{2}", "{", json, "}", rowsCount);
        }


        /// <summary>
        /// 换行换成空格
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private static string StriptEnter(string source)
        {
            return System.Text.RegularExpressions.Regex.Replace(source, @"\s{1,}", " ");
        }

        /// <summary>
        /// 转换成JS escape，值需要js unescape
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="rowsCount"></param>
        /// <returns></returns>
        public string ToJsJson(DataTable dt, long rowsCount)
        {
            //if (dt == null || dt.Rows.Count == 0) return "";
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName.Trim());
                    jsonBuilder.Append("\":\"");
                    jsonBuilder.Append(Microsoft.JScript.GlobalObject.escape(ConvertTag(dt.Rows[i][j].ToString().Trim())));
                    jsonBuilder.Append("\",");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("},");
            }
            if (jsonBuilder.Length > 1)
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("]");

            if (rowsCount > 0)
                return string.Format("{0}\"total\":{3},\"rows\":{1}{2}", "{", jsonBuilder.ToString(), "}", rowsCount);
            else
                return jsonBuilder.ToString();
        }
        /// <summary>
        /// 对象转换为JSON字符串,用法: ToJson&lt;TestModel&gt;(model);
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="t">对象</param>
        /// <returns></returns>
        public string ToJson<T>(T t)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(t.GetType());
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, t);
            byte[] dataBytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(dataBytes, 0, (int)stream.Length);
            string json = Encoding.UTF8.GetString(dataBytes);
            //\/Date(1402934400000+0800)\/  转换为2014-06-17 17:18:11
            string regDate = @"\\/Date\((-?\d+)\+(\d+)\)\\/";
            MatchEvaluator matchEvaluator = new MatchEvaluator(ConvertJsonDateToDateString);
            Regex reg = new Regex(regDate);
            json = reg.Replace(json, matchEvaluator);
            return json;
        }
        /// <summary>
        /// List&lt;T&gt;转换为JSON字符串,用法: ToJson&lt;TestModel&gt;(lists);
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="t">对象</param>
        /// <returns></returns>
        public string ToJson<T>(List<T> t)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(t.GetType());
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, t);
            byte[] dataBytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(dataBytes, 0, (int)stream.Length);
            string json = Encoding.UTF8.GetString(dataBytes);
            //\/Date(1402934400000+0800)\/  转换为2014-06-17 17:18:11
            string regDate = @"\\/Date\((-?\d+)\+(\d+)\)\\/";
            MatchEvaluator matchEvaluator = new MatchEvaluator(ConvertJsonDateToDateString);
            Regex reg = new Regex(regDate);
            json = reg.Replace(json, matchEvaluator);
            
            return json;
        }
        /// <summary>
        /// List&lt;T&gt;转换为JSON字符串,用法: ToJson&lt;TestModel&gt;(lists);
        /// </summary>
        /// <typeparam name="T">对象</typeparam>
        /// <param name="t">对象</param>
        /// <param name="RowCount">总行数，如果大于0会返回EasyUI分页</param>
        /// <returns></returns>
        public string ToJson<T>(List<T> t, int RowCount = 0)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(t.GetType());
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, t);
            byte[] dataBytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(dataBytes, 0, (int)stream.Length);
            string json = Encoding.UTF8.GetString(dataBytes);
            //\/Date(1402934400000+0800)\/  转换为2014-06-17 17:18:11
            string regDate = @"\\/Date\((-?\d+)\+(\d+)\)\\/";
            MatchEvaluator matchEvaluator = new MatchEvaluator(ConvertJsonDateToDateString);
            Regex reg = new Regex(regDate);
            json = reg.Replace(json, matchEvaluator);
            if (RowCount > 0)
                json = string.Format("{0}\"total\":{3},\"rows\":{1}{2}", "{", json, "}", RowCount);
            return json;
        }
        /// <summary>    
        /// 将Json序列化的时间由/Date(1294499956278+0800)转为字符串    
        /// </summary>    
        private string ConvertJsonDateToDateString(Match m)
        {
            string result = string.Empty;
            DateTime dt = new DateTime(1970, 1, 1);
            dt = dt.AddMilliseconds(long.Parse(m.Groups[1].Value));
            dt = dt.ToLocalTime();
            result = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return result;
        }
        private string ConvertTag(string str)
        {
            str = Regex.Replace(str, "<", "&lt;");
            str = Regex.Replace(str, ">", "&gt;");
            return str;
        }
        #endregion

        #region 获取Form 中的参数
        /// <summary>
        /// 从Request中的Form中根据参数获取值
        /// </summary>
        /// <param name="name">参数名</param>
        /// <returns>返回值，为空返回 ""</returns>
        public string FormString(string name)
        {
            if (Request.Form[name] != null)
                return Request.Form[name].Trim();
            return "";
        }
        /// <summary>
        /// 从Request中的Form中根据参数获取值
        /// </summary>
        /// <param name="name">参数名</param>
        /// <returns>返回值，为空返回 0</returns>
        public int FormInt32(string name)
        {
            Int32 value = 0;
            Int32.TryParse(FormString(name), out value);
            return value;
        }
        /// <summary>
        /// 从Request中的Form中根据参数获取值
        /// </summary>
        /// <param name="name">参数名</param>
        /// <returns>返回值，为空返回 0</returns>
        public Int64 FormInt64(string name)
        {
            Int64 value = 0;
            Int64.TryParse(FormString(name), out value);
            return value;
        }
        /// <summary>
        /// 从Request中的Form中根据参数获取值
        /// </summary>
        /// <param name="name">参数名</param>
        /// <returns>返回值，为空返回 false</returns>
        public bool FormBool(string name)
        {
            bool value = false;
            bool.TryParse(FormString(name), out value);
            return value;
        }
        /// <summary>
        /// 从Request中的Form中根据参数获取值
        /// </summary>
        /// <param name="name">参数名</param>
        /// <returns>返回值，为空返回 0</returns>
        public float FormFloat(string name)
        {
            float value = 0;
            float.TryParse(FormString(name), out value);
            return value;
        }
        /// <summary>
        /// 从Request中的Form中根据参数获取值
        /// </summary>
        /// <param name="name">参数名</param>
        /// <returns>返回值，为空返回 0</returns>
        public decimal FormDecimal(string name)
        {
            decimal value = 0;
            decimal.TryParse(FormString(name), out value);
            return value;
        }
        /// <summary>
        /// 从Request中的Form中根据参数获取值
        /// </summary>
        /// <param name="name">参数名</param>
        /// <returns>返回值，为空返回 new DateTime()</returns>
        public DateTime FormDate(string name)
        {
            DateTime value = new DateTime();
            DateTime.TryParse(FormString(name), out value);
            return value;
        }
        /// <summary>
        /// 从Request中的Form中根据参数获取值
        /// </summary>
        /// <param name="name">参数名</param>
        /// <returns>返回值，为空返回 0</returns>
        public byte FormByte(string name)
        {
            Byte value = 0;
            Byte.TryParse(FormString(name), out value);
            return value;
        }
        #endregion

    }
}
