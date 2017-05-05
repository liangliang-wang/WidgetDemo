function DDDD() {
    var e = a.getSelectedResources();
    $("span.icon_gif01[data-category='FreeList']").html("<dfn>¥</dfn>" + e.FreeListPrice + "礼包");
    var t = [], i = [];
    if (n.remove({ Type: n.TYPE.XResource }), n.remove({ Type: n.TYPE.Ticket }),
    e && e.length > 0 && e.each(function (e) {
        var a = 0
          , r = 0
          , o = e.selectedDate
          , s = e.selectedEndDate
          , l = e.prices;
        if (2 == e.resourceType) {
            var c = Object.keys(e.prices);
            if (o && s)
                c.each(function (e) {
                    if (o && s && e >= o && s >= e || o && o == e) {
                        var t = l[e];
                        t && (r += t.ctrip,
                            a += t.market);
    }
    });
    else if (c && c.length) {
                var d = o || s || c[0]
                  , u = e.prices[d];
                u && (r += u.ctrip,
                    a += u.market);
    }
    } else {
            var d = e.selectedDate || e.date;
            e.prices && e.prices[d] && (a = e.prices[d].market,
                r = e.prices[d].ctrip);
    }
        i.push({
        name: e.name,
        original: a,
        price: r,
        count: e.selectedCount,
        bmstatus: e.bmstatus
    }),
        t.push(e.productId);
        var h = 4 == e.typeId ? n.TYPE.Ticket : n.TYPE.XResource;
        n.add({
        Type: h,
        Token: e.id,
        Count: e.selectedCount || e.count,
        UseDate: e.selectedDate || e.date,
        UseEndDate: e.selectedEndDate || e.selectedDate || e.date,
        OrderExtendInfos: e.selectedOrderExtendInfos,
        XData: encodeURIComponent(JSON.stringify(e)),
        Name: escape(e.name)
    });
    }),
    t.length > 0) {
        var r = $("#hXData");
        r.length > 0 && r.value(t);
    }
    n.setxresources(i),
        n.refreshPriceDom(),
        n.preserve();
}