/* jquery.simplr.smoothscroll version 1.0 copyright (c) 2012 https://github.com/simov/simplr-smoothscroll licensed under MIT */ ;
(function (e) {
	"use strict";
	e.srSmoothscroll = function (t) {
		//alert(a)
		var platform = window.navigator.platform;
		if ((platform === 'MacIntel' || platform === 'MacPPC')) {
			return false
		};
		var n = e.extend({
			step: 170,
			speed: 1000,
			ease: "swing"
		}, t || {});
		var r = e(window),
			i = e(document),
			s = 0,
			o = n.step,
			u = n.speed,
			a = r.height(),
			f = navigator.userAgent.indexOf("AppleWebKit") !== -1 ? e("body") : e("html"),
			l = false,
			rdy = 0;
		//alert(a)
		e("body").mousewheel(function (e, t) {
			//Sidenav FIX
            var nav;
            if ((nav = $('.rd-mobilemenu')).length > 0) {
                if (nav.hasClass('active')) {
                    return true;  
                }
            }
            //=========== 
			l = true;
			if (rdy == 0) {
				rdy = 1;
				if (t < 0) s = r.scrollTop() + o;
				else s = r.scrollTop() - o;
			} else {
				if (t < 0) s = s + a >= i.height() ? s : s += o;
				else s = s <= 0 ? 0 : s -= o;
			}
			f.stop().animate({
				scrollTop: s
			}, u, n.ease, function () {
				l = false
			});
			return false
		});
		//alert(a)
		r.on("resize", function (e) {
			a = r.height()
		}).on("scroll", function (e) {
			if (!l) s = r.scrollTop()
		})
	}
})(jQuery);