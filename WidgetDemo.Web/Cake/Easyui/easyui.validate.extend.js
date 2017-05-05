$.extend($.fn.validatebox.defaults.rules, {
    mobile: {
        validator: function (value, param) {
            var regMb = /^(0)?1(3|4|5|7|8)[0-9]{9}$/;
            return regMb.test(value);
            //return value.length >= param[0];
        },
        message: '请输入一个手机号码'
    },
    //验证正数
    positiveInteger: {
        validator: function (value) {
            var reg = /^\d+(?=\.{0,1}\d+$|$)/;
            return reg.test(value);
        },
        message: '请输入一个非负数'
    },
    //结束时间大于开始时间
    endTime: {
        validator: function (value, param) {
            if ($(param).datebox('getValue') != "" && value != "") {
                return $(param).datebox('getValue') <= value;
            } else {
                return true;
            }
        },
        message: '结束日期小于开始日期！'
    },
    // 验证IP地址 
    ip: {
        validator: function (value) {
            var exp = /^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$/;
            return exp.test(value);
        },
        message: 'IP地址格式不正确'
    },
    // 验证空格 
    blankCheck: {
        validator: function(value, param) {
            var deleBlanck = value.trim();
            var strLength = 0, len = value.length, charCode = -1;
            for (var i = 0; i < len; i++) {
                charCode = value.charCodeAt(i);
                if (charCode >= 0 && charCode <= 128) strLength += 1;
                else strLength += 2;
            }
            return !deleBlanck == "" && strLength <= param;
        },
        message: '输入格式不正确'
    },
    // 验证时间格式
    timeCheck: {
        validator: function(value) {
            var deleBlanck = value.trim();
            var timecheckrule = /^([1-2]\d{3})[\/|\-](0?[1-9]|10|11|12)[\/|\-]([1-2]?[0-9]|0[1-9]|30|31)$/ig;
            return !deleBlanck == "" && timecheckrule.test(value);
        },
        message: '日期格式不正确'
    },
    // 验证端口格式 
    ipport: {
        validator: function(value) {
            var reg = new RegExp("^[0-9]*$");
            var _reg = /^\S{6,}$/;
            var pattern1 = /^0.*/g;
            return (reg.test(value) && !_reg.test($.trim(value)) && !pattern1.test(value) && value<=65535);
        },
        message: '端口必须是介于1~65535之间的正整数'
    },
    // 验证Byte
    ByteCheck: {
        validator:function(value,param) {
            var CheckRule = /^[+]?[0-9]\d*$/;
            var result=false;
            if (CheckRule.test(value)) {
                result = parseInt(value) < param;
            }
            return result;
        },
        message: '请输入小于256的正整数'
    },
    //验证数字
    numberCheck: {
        validator: function (value, param) {
            return /^\d+$/.test(value);
            },
        message: '请输入数字'
    },
    
    //验证数字或小数
    pointNumberCheck: {
        validator:function(value) {
            var CheckRule = /^[0-9]+(\.[0-9]+)?$/;
            return CheckRule.test(value);
        },
        message:'请输入正数'
    }
});