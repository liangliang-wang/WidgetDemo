$(document).ready(function () {
    $('.col-md-2').on('click', '.ajax-link', function (e) {
        var url = $(this).attr('data-href');
        var name = $(this).text();
        var guid = Guid();
        var panel = CreateTabContent(guid, url);
        $("#layouttabcontent").html("");
        $("#layouttabcontent").append(panel);
        $("#" + guid + "frame").attr("src", url);
    });
});
/*设定菜单宽度*/
function MessagesMenuWidth() {
    var W = window.innerWidth;
    var W_menu = $('#sidebar-left').outerWidth();
    var w_messages = (W - W_menu) * 16.666666666666664 / 100;
    $('#messages-menu').width(w_messages);
}
/*初始化按钮*/
function InitPreNextbtn() {
    $("#backforwardbtn").on("click", function () {
        var sidebargroupwidth = $("#sidebargroup").width();
        $(".navbartabdiv").css({ "margin-left": sidebargroupwidth + "px" });
    });
    $("#forwardbtn").on("click", function () {
        var navwidth = $("#forwardbtn").offset().left - $("#backforwardbtn").offset().left - 46;
        var tabwidth = 0;
        $(".navbartabdiv").find("li").each(function () {
            tabwidth = tabwidth + $(this).width();
        });
        if (tabwidth <= navwidth) {
            return;
        } else {
            var marginleft = 90 - (tabwidth - navwidth + navwidth / 5);
            $(".navbartabdiv").css({ "margin-left": marginleft + "px" });
        }
    });
}
/*创建tab*/
function CreateTab(name, href) {
    if (href == "") return;
    href = href.toLowerCase();
    if (name == "") name = "无标题" + $(".navbartabdiv").find("a").length;
    var tables = $(".navbartabdiv").find("li");
    var ishave = false;
    $(".navbartabdiv").find("a").each(function () {
        if ($(this).attr("data-href").toLowerCase() == href.toLowerCase()) {
            ishave = true;
            $(this).click();
            ScrollToTab(this);
        }
    });
    if (!ishave) {
        var guid = Guid();
        var tab = CreateTabToggle(guid, name, href);
        var panel = CreateTabContent(guid, href);
        $("#layouttabcontent").append(panel);
        $(".navbartabdiv").find("ul").append(tab);
        $("#" + guid + "frame").attr("src", href);
        $(".navbartabdiv").find("a[aria-controls='" + guid + "']").click();
        InitTabRemove(guid);
        ScrollToTab($(".navbartabdiv").find("a[aria-controls='" + guid + "']"));
    }
}
function InitTabRemove(guid) {
    $(".navbartabdiv").find("a[aria-controls='" + guid + "']").find(".removetab").on("click", function () {
        var guid = $(this).parent().attr("aria-controls");
        var waitClick = $(this).parent().parent().next().length > 0 ? $(this).parent().parent().next()[0] : $(this).parent().parent().prev().length > 0 ? $(this).parent().parent().prev()[0] : null;
        $(this).parent().parent().remove();
        $("#" + guid + "frame").parent().remove();
        if (waitClick != null) {
            $(waitClick).find("a").click();
        }
    });
}
/*跳转到页面*/
function ScrollToTab(element) {
    var navwidth = $("#forwardbtn").offset().left - $("#backforwardbtn").offset().left - 46;
    var width = $(element).width();
    tabwidth = $(element).offset().left;
    if (tabwidth <= navwidth && tabwidth > width) {
        return;
    } else {
        var marginleft = $(".navbartabdiv").css("margin-left").replace("px", "") - (tabwidth - navwidth + navwidth / 5);
        var sidebargroupwidth = $("#sidebargroup").width();
        if (marginleft > sidebargroupwidth) {
            marginleft = sidebargroupwidth;
        }
        $(".navbartabdiv").css({ "margin-left": marginleft + "px" });
    }
}
/*唯一id*/
function Guid() {
    function s4() {
        return Math.floor((1 + Math.random()) * 0x10000).toString(16).substring(1);
    };
    return s4() + s4() + s4() + s4() + s4() + s4() + s4() + s4();
}
/*创建触发器*/
function CreateTabToggle(guid, name, href) {
    var toggle = '<li role="presentation" >';
    toggle += '<a class="noborder" style="border:0;" href="#' + guid + '" aria-controls="' + guid + '" role="tab" data-toggle="tab" data-href="' + href + '"><span class="tabname">' + name + '</span><i class="icon-remove-sign removetab"></i></a>';
    toggle += '</li>';
    return toggle;
}
/*创建panel*/
function CreateTabContent(guid, href) {
    var panel = '<div role="tabpanel" class="tab-pane" id="' + guid + '" style="height: 100%;">'
    panel += '<iframe class="tabpaneliframe" name="' + guid + 'frame" id="' + guid + 'frame" frameborder="0" data-id="' + guid + '" scrolling="auto" style="display: inline;width:100%;height:100%;border:0px;"></iframe>'
    panel += "</div>";
    return panel;
}