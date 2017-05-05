/* ***********************************************
 * Copyright (c) 同程旅游软件有限公司. All rights reserved.
 * Author :  alex
 * Project:  项目名称
 * Create:   2011-08-16 11:28:43 
 * ***********************************************/

using System;
using System.Collections;

namespace WidgetDemo.Context.MenuServices
{
    /// <summary> 基类</summary>
    public abstract class MenuRequestBase
    {
        /// <summary> 服务地址</summary>
        public string ServiceUrl
        { get; set; }
        /// <summary> 服务名称</summary>
        public string Service { get; set; }
        /// <summary> 项目代码</summary>
        public string ProjCode { get; set; }
        /// <summary> 用户Id</summary>
        public string UserId { get; set; }
        /// <summary> 工号</summary>
        public string JobNumber { get; set; }
        /// <summary> 密码</summary>
        public string Pwd { get; set; }
        /// <summary> ucom节点</summary>
        public string Ucom { get; set; }
        private readonly string _postData;
        public virtual string PostData
        {
            get { return _postData; }
        }
        private readonly string _postUserIdData;
        public virtual string PostUserIdData
        {
            get { return _postUserIdData; }
        }
        private readonly string _postChangePwdData;
        public virtual string PostChangePwdData
        {
            get { return _postChangePwdData; }
        }
        protected MenuRequestBase(string postData, string postUserIdData, string postChangePwdData)
        {
            _postData = postData;
            _postChangePwdData = postChangePwdData;
            _postUserIdData = postUserIdData;
        }
        protected MenuRequestBase(string postUserIdData, string postChangePwdData)
        {
            _postUserIdData = postUserIdData;
            _postChangePwdData = postChangePwdData;
        }
        protected MenuRequestBase()
        {
        }
        /// <summary> 错误信息</summary>
        /// <param name="errorNo">错误代码</param>
        /// <returns>错误具体的信息</returns>
        public string ErrorMessage(string errorNo)
        {
            if (string.IsNullOrEmpty(errorNo)) throw new ArgumentNullException("errorNo");
            var errorMessage = new ErrorMessage
            {
                No = errorNo
            };
            return errorMessage.Message;
        }
    }
    /// 错误数据
    /// 
    public class ErrorMessage
    {
        /// <summary>结果</summary>
        public bool Result { get; set; }
        /// <summary>错误编号</summary>
        private string _no;
        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                _no = value;
                var messages = ErrorList();
                foreach (DictionaryEntry item in messages)
                {
                    if (!item.Key.ToString().Equals(No)) continue;
                    Message = item.Value.ToString();
                    break;
                }
            }
        }
        public string Message { get; set; }
        /// <summary> 错误列表</summary>
        /// <returns>错误列表</returns>
        private static Hashtable ErrorList()
        {
            Hashtable ht = new Hashtable
                               {
                                   {"000", "没有查到数据"},
                                   {"001","卡号或密码错误"},
                                   {"002","提供项目无法查找"},
                                   {"003","没有相关服务接口"},
                                   {"004","参数错误"},
                                   {"005","服务器内部请求异常"},
                                   {"006","卡号格式错误"},
                                   {"007","密码不能为空"},
                                   {"008","项目ID 格式错误"},
                                   {"009","原始密码不能为空"},
                                   {"010","原始密码长度最大16个字符"},
                                   {"011","新密码不能为空"},
                                   {"012","新密码长度最大16个字符"},
                                   {"013","没有开通帐号"},
                                   {"014","该员工不存在"},
                                   {"015","原始密码不正确"},
                                   {"016","身份证格式错误"},
                                   {"017","类别格式错误"},
                                   {"018","用户ID格式错误"},
                                   {"019","没有该用户信息"}
                               };
            return ht;
        }
    }
}
