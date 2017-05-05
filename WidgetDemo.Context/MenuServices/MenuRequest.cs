/* ***********************************************
 * Copyright (c) 同程旅游软件有限公司. All rights reserved.
 * Author :  alex
 * Project:  项目名称
 * Create:   2011-08-16 11:17:42 
 * ***********************************************/
using System.Web;
using System.Text;

namespace WidgetDemo.Context.MenuServices
{
    public class MenuRequest : MenuRequestBase
    {
        public MenuRequest(string postData, string postUserIdData, string postChangePwdData)
            : base(postData, postUserIdData, postChangePwdData) { }
        public MenuRequest(string postUserIdData, string postChangePwdData)
            : base(postUserIdData, postChangePwdData) { }
        public MenuRequest()
        {
        }
        /// <summary> 提交参数集合</summary>
        public override string PostData
        {
            get
            {
                var parameters = new StringBuilder();
                parameters.AppendFormat(
                    "<?xml version=\"1.0\" encoding=\"gb2312\"?><meminfo><trasinf><service>{0}</service><projCode>{1}</projCode></trasinf>"
                    + "<ucom><jobNumber><![CDATA[{2}]]></jobNumber><numType>1</numType><pwd><![CDATA[{3}]]></pwd></ucom></meminfo>",
                    HttpUtility.UrlEncode(Service, Encoding.UTF8), HttpUtility.UrlEncode(ProjCode, Encoding.UTF8),
                     JobNumber, Pwd);
                return parameters.ToString();
            }
        }
        /// <summary> 提交参数集合</summary>
        public override string PostUserIdData
        {
            get
            {
                var parameters = new StringBuilder();
                parameters.AppendFormat(
                    "<?xml version=\"1.0\" encoding=\"gb2312\"?><meminfo><trasinf><service>{0}</service><projCode>{1}</projCode></trasinf>" +
                    "<ucom>{2}</ucom></meminfo>",
                    Service, ProjCode, Ucom);
                return parameters.ToString();
            }
        }
        /// <summary> 记住用户名和密码</summary>
        public bool IsRemember { get; set; }
    }
}
