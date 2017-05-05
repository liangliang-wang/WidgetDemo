var _IdField = "Id";
$(document).ready(function () {
    addForm();
    closeForm();
});
/*添加Form*/
function addForm() {
    $("#editForm").find("input[name='Id']").val("0");
    $("#editForm").resetForm();
    $('#divEdit').dialog({
        title: '新增',
        modal: true,
        collapsible: false,
        resizable: true,
        iconCls: 'icon-monitor',
        onClose: function () {
            //解决弹出窗口关闭后，验证消息还显示在最上面
            $('.tooltip').remove();
        }
    });
}
/*编辑Form*/
function editForm() {
    var rows = $('#tbGrid').datagrid('getSelections');
    if (rows.length == 0) {
        $.messager.alert("提示", "请选择要编辑的数据！", "info");
        return;
    }
    if (rows.length > 1) {
        $.messager.alert("提示", "每次只能编辑一条数据！", "info");
        return;
    }
    $('#editForm').form('load', rows[0]);
    $('#divEdit').dialog({
        title: '编辑',
        modal: true,
        collapsible: false,
        resizable: true,
        iconCls: 'icon-monitor',
        onClose: function () {
            //解决弹出窗口关闭后，验证消息还显示在最上面
            $('.tooltip').remove();
        }
    });

}
/*显示数据*/
function showForm(data) {
    var rows = $('#tbGrid').datagrid('getSelections');
    if (rows.length == 0) {
        $.messager.alert("提示", "请选择要查看的数据！", "info");
        return;
    }
    if (rows.length > 1) {
        $.messager.alert("提示", "每次只能查看一条数据！", "info");
        return;
    }
    if (data == null) $('#editForm').form('load', rows[0]);
    else $('#editForm').form('load', data);
    $('#divEdit').dialog({
        title: '明细',
        modal: true,
        collapsible: false,
        iconCls: 'icon-monitor',
        resizable: true
    });
}
function submitForm(formId, divId, callBack) {
    var fId = formId || "editForm";
    fId = "#" + fId;
    $(fId).form('submit', {
        success: function (data) {
            if (!isNaN(data)) {
                if (data > 0) {
                    var id = $(fId).find("input[name=" + _IdField + "]").val();
                    clearForm(formId);
                    closeForm(divId);
                    if (id > 0) {
                        $.messager.show({ title: '提 示', msg: '数据更新成功！', showType: 'slide' });
                        $('.tooltip').remove();
                        $('#tbGrid').datagrid('reload');
                        $('#tbGrid').datagrid('clearSelections');
                    } else {
                        $.messager.show({ title: '提 示', msg: '数据添加成功！', showType: 'slide' });
                        $('.tooltip').remove();
                        $('#tbGrid').datagrid('load');
                    }
                    if (callBack)
                        callBack();
                }
                else {
                    var id1 = $(fId).find("input[name=" + _IdField + "]").val();
                    if (id1 > 0) {
                        $('.tooltip').remove();
                        $.messager.alert("错误", "数据更新失败，请稍后重试！", "error");
                    } else {
                        $('.tooltip').remove();
                        $.messager.alert("错误", "数据添加失败，请稍后重试！", "error");
                    }
                }
            }
            else {
                $.messager.alert("提示", data, "info");
            }
        }
    });
}
function clearForm(formId) {
    var fId = formId || "editForm";
    fId = "#" + fId;
    $(fId).form('clear');
}
function closeForm(formId) {
    var fId = formId || "divEdit";
    fId = "#" + fId;
    $(fId).dialog('close');
}
/*搜索*/
function searchGrid() {
    var para = serializObject("formsearch");
    $('#tbGrid').datagrid('load', serializObject("formsearch"));
    //查询后清空选中数据

    $('#tbGrid').datagrid('clearSelections');
    $('#tbGrid').datagrid('clearChecked');
}
/*重置*/
function resetsForm() {
    $("#formsearch").form("clear");
    $("#formsearch :input").val("");
    $("#formsearch [type=text]").val("");
    $("#formsearch select").val("");
    $("#formsearch [type=checkbox]").attr("checked", "");
}
/*删除数据*/
function delAjax(url) {
    url = changeURLPar(url, "rd", Math.random());
    $.messager.confirm("确 认", "您确定要删除吗？", function (r) {
        if (!r) return;
        var html = $.ajax({
            url: url,
            async: false
        }).responseText;
        if (html > 0) {
            $('#tbGrid').datagrid('clearSelections');
            $('#tbGrid').datagrid('reload');
            $.messager.show({ title: '提 示', msg: '您已成功删除' + html + '条数据！', showType: 'slide' });
        }
        else if (html == 0) {
            $.messager.show({ title: '提 示', msg: '删除数据失败，请稍后重试！', showType: 'slide' });
        }
        else { $.messager.show({ title: '提 示', msg: html, showType: 'slide' }); }
    });
}
/*序列化form中的参数*/
function serializObject(name) {
    var o = {};
    $.each($("#" + name).serializeArray(), function (i) {
        if (o[this['name']]) {
            o[this['name']] = o[this['name']] + "," + this['value'];
        }
        else o[this['name']] = this['value'];
    });
    return o;
}
/*获取datagrid选中项*/
function getGridSelect(name) {
    var ids = [];
    var sr = $("#" + name).datagrid('getSelections');
    for (var i = 0; i < sr.length; i++) {
        var o = eval("sr[i]." + _IdField);
        ids.push(o);
    }
    return ids.join(',');
}
/*设置url参数值，ref参数名,value新的参数值*/
function changeURLPar(url, ref, value) {
    var str = "";
    if (url.indexOf('?') != -1) str = url.substr(url.indexOf('?') + 1);
    else return url + "?" + ref + "=" + value;
    var returnurl = "";
    var setparam = "";
    var arr;
    var modify = "0";
    if (str.indexOf('&') != -1) {
        arr = str.split('&');
        for (i in arr) {
            if (arr[i].split('=')[0] == ref) {
                setparam = value;
                modify = "1";
            }
            else {
                setparam = arr[i].split('=')[1];
            }
            returnurl = returnurl + arr[i].split('=')[0] + "=" + setparam + "&";
        }
        returnurl = returnurl.substr(0, returnurl.length - 1);
        if (modify == "0")
            if (returnurl == str)
                returnurl = returnurl + "&" + ref + "=" + value;
    }
    else {
        if (str.indexOf('=') != -1) {
            arr = str.split('=');
            if (arr[0] == ref) {
                setparam = value;
                modify = "1";
            }
            else {
                setparam = arr[1];
            }
            returnurl = arr[0] + "=" + setparam;
            if (modify == "0")
                if (returnurl == str)
                    returnurl = returnurl + "&" + ref + "=" + value;
        }
        else
            returnurl = ref + "=" + value;
    }
    return url.substr(0, url.indexOf('?')) + "?" + returnurl;
}


var dateFormat = function () {
    return function (date, mask, utc) {
        if (!date) {
            date = new Date();
        }
        if (!mask) {
            mask = "yyyy-MM-dd HH:mm";
        } else {
            mask = mask.replace(/\-mm\-/g, "-MM-");
            mask = mask.replace(/\:MM$/g, ":mm");
            mask = mask.replace(/^mm\-/g, "MM-");
        }
        return Date.parse(date.toString()).toString(mask);
    };
} ();

// For convenience...
Date.prototype.format = function (mask, utc) {
    return dateFormat(this, mask, utc);
};

/*
监控数据格式化
*/
function statValueFormat(statValue, tStyle) {
    statValue = statValue || 0;
    statValue = parseFloat(statValue);
    if (tStyle == "1") {
        statValue *= 100;
        return statValue.toFixed(2) + "%";
    } else {
        return statValue.toFixed(0);
    }
}

function rowStatusFormatter(value) {
    switch (value) {
        case "0": return "<span style=\"color:red;\">无效</span>";
        case "1": return "<span style=\"color:green;\">有效</span>";
        default: return "";
    }
}
function rowStyler(value, zeroGreen) {
    if (zeroGreen && value) {
        return "color:green;";
    }

    if (value == 0) {
        return "color:red;";
    } else {
        return "color:green;";
    }
}

$.formatString = function (str) {
    for (var i = 0; i < arguments.length - 1; i++) {
        str = str.replace("{" + i + "}", arguments[i + 1]);
    }
    return str;
};
//按下ESC键退出当前编辑窗口
$(document).keydown(function (e) {
    if (!e)
        e = window.event;
    if ((e.keyCode || e.which) == 27) {
        closeForm();
    }
});
/*导入Form*/
function importForm() {
    $("#importForm").resetForm();
    $('#divImport').dialog({
        title: '导入',
        modal: true,
        collapsible: false,
        resizable: true
    });
}

//检查输入值是否在绑定的数据中
function checkComboboxInput(combobox, valueField, textField) {
    var isMatch = false;

    var datas = combobox.combobox('getData');
    var currValue = combobox.combobox('getValue');
    var currText = combobox.combobox('getText');

    for (var i = 0; i < datas.length; i++) {
        if ((datas[i][valueField] == currValue) && (datas[i][textField] == currText)) {
            isMatch = true;
            break;
        }
    }
    return isMatch;
}

//清除cookie    
function clearCookie(name) {
    setCookie(name, "", -1);
}
//设置cookie    
function setCookie(name, value, seconds) {
    seconds = seconds || 0;   //seconds有值就直接赋值，没有为0，这个根php不一样。    
    var expires = "";
    if (seconds != 0) {      //设置cookie生存时间    
        var date = new Date();
        date.setTime(date.getTime() + (seconds * 1000));
        expires = "; expires=" + date.toGMTString();
    }
    document.cookie = name + "=" + escape(value) + expires + "; path=/";   //转码并赋值    
}
//取得cookie    
function getCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');    //把cookie分割成组    
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];                      //取得字符串    
        while (c.charAt(0) == ' ') {          //判断一下字符串有没有前导空格    
            c = c.substring(1, c.length);      //有的话，从第二位开始取    
        }
        if (c.indexOf(nameEQ) == 0) {
            //如果含有我们要的name    
            return unescape(c.substring(nameEQ.length, c.length));    //解码并截取我们要值    
        }
    }
    return "";
}

//添加额外的Tab
function addExtTab(url, title) {
    if (window.parent.$('#tabs').tabs('exists', title)) {
        window.parent.$('#tabs').tabs('select', title);
        refreshTab({ tabTitle: title, url: url });
    } else {
        window.parent.$('#tabs').tabs('add', {
            title: title,
            content: '<iframe scrolling="auto" frameborder="0"  src="' + url + '" style="width:100%;height:99%;"></iframe>',
            closable: true
        });
    }
}
//刷新tab
function refreshTab(cfg) {
    var refresh_tab = cfg.tabTitle ? window.parent.$('#tabs').tabs('getTab', cfg.tabTitle) : window.parent.$('#tabs').tabs('getSelected');
    if (refresh_tab && refresh_tab.find('iframe').length > 0) {
        var _refresh_ifram = refresh_tab.find('iframe')[0];
        var refresh_url = cfg.url ? cfg.url : _refresh_ifram.src;
        _refresh_ifram.contentWindow.location.href = refresh_url;
    }
}
//按F5改变浏览器地址，消除后带的参数
function KeyDown() {
    if ((event.keyCode == 116)) {
        event.keyCode = 0;
        event.returnValue = false;
        var href = window.parent.location.href;
        var newhref = href.substring(0, href.indexOf("/monitor") + 8);
        if (href.indexOf("/MonitorConfig")>0) {
            window.parent.parent.location.href = newhref;
        } else {
            window.parent.location.href = newhref;
        }
    }
}
document.onkeydown = KeyDown;