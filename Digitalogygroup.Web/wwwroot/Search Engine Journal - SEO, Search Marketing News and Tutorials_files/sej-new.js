function shsow_shares(){var e=document.getElementsByClassName("sharebtn");if(void 0!==e&&1<e.length)for(s=0;s<e.length;s++){var t=getAttr(e[s],"data-id");("undefined"!=t&&null!=t&&(void 0===window.sactive_id||t!=window.sactive_id&&0!=window.sactive_id)?saddClass:sremoveClass)(e[s],"dnone")}else null!=e&&1==e.length&&sremoveClass(e[0],"dnone");if(null!=e){sbuttons=document.querySelectorAll(".sej-share a.nwind");for(var s=0,a=sbuttons.length;s<a;s++){shasClass(sbuttons[s],"sprocess")||(sbuttons[s].addEventListener("click",sej_sharepop,!1),saddClass(sbuttons[s],"sprocess"),serv_n=sbuttons[s].getAttribute("data-service"),(navigator.userAgent||navigator.vendor||window.opera).match(/Android/i)&&"SMS"==serv_n&&(bod=sbuttons[s].getAttribute("href"),newurl=bod.replace("sms:&","sms:?"),sbuttons[s].setAttribute("href",newurl)))}}}function sej_sharepop(e){e.preventDefault();var t=e.target.tagName.toLowerCase();return elem="a"!=t?sparents(e.target,"a"):e.target,serv_n=elem.getAttribute("data-service"),can_url=window.location.href,"undefined"!=typeof __gaTracker&&(__gaTracker("send","event","AddToAny Share/Save Button",serv_n,can_url),__gaTracker("send","social","AddToAny",serv_n,can_url)),url=elem.getAttribute("href"),window.open(url,"","menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=600,width=600,top=30,left=80"),!1}function sej2017_shorten_long_digits_K(e){return!!e&&(1e3<=e&&(e=Math.floor(e/1e3)+"K"),e)}function sej2017_getFirstKey(e){for(var t in e)return t}window.addEventListener("load",function(){var e=document.getElementsByClassName("com-btn");sadd_event(e,"click",function(){console.log("open_comments click"),sremoveClass([".right-fix",".comm-ovrl"],"dnone"),setTimeout(function(){saddClass([".right-fix",".comm-ovrl",".close-comm"],"show-comm")},100),saddClass("body","no-ovrf")}),sadd_event([".comm-ovrl",".close-comm"],"click",function(){sremoveClass([".right-fix",".comm-ovrl",".close-comm"],"show-comm"),setTimeout(function(){saddClass([".right-fix",".comm-ovrl"],"dnone")},100),sremoveClass("body","no-ovrf")})}),document.addEventListener("fake_pageview",function(){shsow_shares()}),window.addEventListener("DOMContentLoaded",function(){wpadmin=document.querySelector("#wpadminbar"),shsow_shares();var e=document.getElementsByClassName("com-btn");void 0!==e&&null!=e&&sremoveClass(e,"dnone"),String.prototype.endsWith=function(e){return e===this.substr(0-e.length)};var i="";jQuery(document).ready(function(p){var e="ontouchstart"in window||0<navigator.msMaxTouchPoints;document.documentElement.className+=e?" touch-scr":" no-touch-scr",p(".top-icons-drop, .touch-scr .sej_touch_menu").click(function(e){e.preventDefault();var t=p(this).attr("data-show");"desktop-drop"!=t&&a(".sej-menu"),a(".sej-mobile-section-menu");var s=p("."+t);p(".top-icons-drop,  .touch-scr .sej_touch_menu").each(function(){p(this).attr("data-show")!=t&&(module_element2=p("."+p(this).attr("data-show")),module_element2.removeClass("active"),0<p(this).parents("li").length&&p(this).parents("li").removeClass("active"),"top-subscribe"==p(this).attr("data-show")&&p(this).removeClass("active"))}),0<p(this).parents("li").length&&p(this).parents("li").toggleClass("active"),s.toggleClass("active"),"top-subscribe"==t&&p(this).toggleClass("active")}),p(".open-button").click(function(e){e.preventDefault(),a(".top-icons-drop"),a(".sej-social-icon"),a(".sej-search-icon"),p(".sej-mobile-section-menu").toggleClass("active"),p(".open-button_m").toggleClass("active"),p(".open-button_m").toggleClass("fa-close"),p(".open-button_m").toggleClass("fa-bars"),p("body").toggleClass("menu-cover"),p("body").toggleClass("no-overflow-mob"),p("html").toggleClass("no-overflow-mob")}),p(".transparent-cover").click(function(){a(".sej-mobile-section-menu")}),p("#sej-page-wrapper").click(function(){a(".sej-search-icon"),a(".sej-social-icon"),a(".top-subscribe"),p(".sej-menu, .sej-btn-top, .sej_drop_menu_icon").removeClass("active")}),p(".sej-mobile-menu > ul > li > a[href='#expand']").click(function(e){e.preventDefault();var t=p(this).parent(),s=t.find(".sej-submenu"),a=t.find(".list-unstyled").height();t.hasClass("active")?(t.removeClass("active"),s.animate({height:0},400,function(){p(".logo-sect div.sej-logo").addClass("margin-0")})):(p(".sej-mobile-menu > ul > li.active > .sej-submenu").css("height",0),p(".sej-mobile-menu > ul > li.active").removeClass("active"),t.addClass("active"),s.animate({height:a},400,function(){p(".logo-sect div.sej-logo").removeClass("margin-0")}))}),p(".textwidget .af-form-wrapper").submit(function(){var e,t=p.trim(p(".text",this).val());if(!/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,25})+$/.test(t))return p(".text",this).addClass("redborder"),p(".sidebar-error-email",this).remove(),e=""==t||"Enter email address"==t?"Email is required.":"Invalid email address.",p(".text",this).after('<span class="sidebar-error-email validerror" style="float: left;display:inline-block;">'+e+"</span>"),!1;p(document).trigger("aweber_form_valid_success"),p(".text",this).removeClass("redborder"),p(".sidebar-error-email").remove()}),void 0!==p.fn.datepicker&&(p("#showadserach").click(function(){p("#search-filters-form").toggle(),p(this).css({display:"none"}),p("#hideadserach").css({display:"inline-block"})}),p("#hideadserach").click(function(){p("#search-filters-form").toggle(),p(this).css({display:"none"}),p("#showadserach").css({display:"inline-block"})}),p("#search-filters-form").submit(function(){return 0<p("#search-date-from").datepicker("getDate")-p("#search-date-to").datepicker("getDate")?(p(".search-vmessages").addClass("validerror margin-bottom-15").html("The start date must come before the end date."),p("#search-date-from,#search-date-to").addClass("redborder"),!1):(p("#search-date-from,#search-date-to").removeClass("redborder"),p(".search-vmessages").html(""),void p(this).append('<input type="hidden" value="site-search" name="type" />'))}),p("#search-date-from, #search-date-to").datepicker({changeMonth:!0,changeYear:!0,minDate:new Date(2009,0,1),maxDate:"0",dateFormat:"MM d, yy",showButtonPanel:!0,closeText:"Done",onClose:function(e,t){var s,a=p("#ui-datepicker-div .ui-datepicker-month :selected").val(),o=p("#ui-datepicker-div .ui-datepicker-year :selected").val();"search-date-to"==this.id?(p("#search-date-to").datepicker("getDate"),a=parseInt(a),o=parseInt(o),s=new Date(o,a+1,0),p(this).datepicker("setDate",new Date(o,a,s.getDate()))):p(this).datepicker("setDate",new Date(o,a,1))}})),p(".inline-tweet-click").click(function(e){e.preventDefault(),0<p(this).attr("data-href").length&&(window.open(p(this).attr("data-href"),"tweetwindow","width=566,height=592,location=yes,directories=no,channelmode=no,menubar=no,resizable=no,scrollbars=no,status=no,toolbar=no"),"undefined"!=typeof __gaTracker&&__gaTracker("send","event","Post Inline Tweet",window.location.href))});window.innerHeight;p("#mobileheadermenu").length;var t;sej_isRetina();function _(t){p.ajax({url:"/location.json",success:function(e){void 0===e.country||t.hasClass("nosubform")||(sej_visitor_country=e.country,sej_visitor_country&&0==t.has(".countryinput_api").length&&(t.append('<input type="hidden" class="countryinput_api" name="custom_COUNTRY" value="'+sej_visitor_country+'"/>'),t.append('<input type="hidden" class="countryinput_webform" name="COUNTRY" value="'+sej_visitor_country+'"/>'),0<t.has(".select-state").length&&"US"==e.country&&(t.find(".select-state").removeClass("dnone"),t.find(".select-state select").addClass("sej_validate sej_requaired sej_selected_v form-control"))))},async:!1})}function g(e){var t=!0,s=p.trim(e.val()),a=e.parent("div"),o=a.find(".sej_error_message");a.hasClass("selectr-container")&&(par_div2=a.parent("div"),o=par_div2.find(".sej_error_message")),e.val(s);var n,i,r;return!e.hasClass("sej_requaired")||("text"==(n=e.attr("type"))&&""==p.trim(e.val())||"checkbox"==n&&!e.is(":checked"))&&(o.html("This field is required"),o.show(),e.addClass("input-error"),console.log("sej_requaired 333"),console.log(e.parent("div")),t=!1),e.hasClass("sej_phone_v")&&(phone_checked_value=s.replace(/\s|\+|\.|-|\)|\(/g,""),i=/^\d{1,9}$/.test(phone_checked_value)?"Please enter a valid 10-digit  phone number. (You only entered "+phone_checked_value.length+" digits.) ":/^\d+$/.test(phone_checked_value)?"":"Please enter a valid phone number",console.log(phone_checked_value),i&&(o.html(i),o.show(),e.addClass("input-error"),t=!1)),e.hasClass("sej_selected_v")&&""==e.children("option:selected").val()&&(o.html("Please select an option"),o.show(),e.addClass("input-error"),(a=e.parent("div")).hasClass("selectr-container")&&(a.addClass("input-error"),console.log("XXXXXXXXXXX")),console.log("YYYYYYYYYYYY"),t=!1),!e.hasClass("sej_email")||(r=s,r=p.trim(r),/^\w+([\+\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,25})+$/.test(r)&&l(s))||(i="Please enter a valid email address.",l(s)||(i="Please check an email domain syntax."),o.html(i),o.show(),e.addClass("input-error"),t=!1),e.hasClass("sej_website_v")&&!function(e){if(function(e){return!!/^(?!:\/\/)([a-zA-Z0-9-]+\.){0,5}[a-zA-Z0-9-][a-zA-Z0-9-]+\.[a-zA-Z]{2,64}?$/gi.test(e)}(e=e.toLowerCase())||function(e){return!!/^(?:(?:https?|ftp):\/\/)?(?:(?!(?:10|127)(?:\.\d{1,3}){3})(?!(?:169\.254|192\.168)(?:\.\d{1,3}){2})(?!172\.(?:1[6-9]|2\d|3[0-1])(?:\.\d{1,3}){2})(?:[1-9]\d?|1\d\d|2[01]\d|22[0-3])(?:\.(?:1?\d{1,2}|2[0-4]\d|25[0-5])){2}(?:\.(?:[1-9]\d?|1\d\d|2[0-4]\d|25[0-4]))|(?:(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)(?:\.(?:[a-z\u00a1-\uffff0-9]-*)*[a-z\u00a1-\uffff0-9]+)*(?:\.(?:[a-z\u00a1-\uffff]{2,})))(?::\d{2,5})?(?:\/\S*)?$/.test(e)}(e))return!0;return!1}(s)&&(o.html("Please enter a valid website"),o.show(),e.addClass("input-error"),t=!1),t&&(o.hide(),e.removeClass("input-error"),(a=e.parent("div")).hasClass("selectr-container")&&a.removeClass("input-error")),t}function l(e){if(!(e=p.trim(e)).endsWith(".con")){for(var t=["hotmial","hotmal","homail","yaho","yhoo","gmil","gmaill"],s=0;s<t.length;s++){if(e.endsWith(t[s]+".com"))return}return 1}}function s(e,t){void 0===t&&(t=!1),0<p(".sej_mouse_over").length&&!t||(p(".sej_home_featured_tab.selected").removeClass("selected").removeClass("sej_mouse_over"),p(".sej_home_featured_tab"+e).addClass("selected"),p(".sej_big_featured_image").stop().animate({opacity:.2},400,function(){p(".sej_big_featured_image").css({background:"url( "+sej_home_featured_tabs[e].image+" )"}).stop().animate({opacity:1},400)}),p(".sej_big_tab_sec").html(sej_home_featured_tabs[e].content),0<p(".sej2017_home_slider_big_title").length&&p(".sej2017_home_slider_big_title").html(p(".sej_home_featured_tab"+e+" .sej-ptitle").html()))}function a(e){p(e).hasClass("active")&&0<p(e).length&&(".sej-search-icon"==e&&(p(e).removeClass("active"),p(".top-search").removeClass("active")),".sej-social-icon"==e&&(p(e).removeClass("active"),p(".top-icons").removeClass("active")),".top-subscribe"==e&&(p(e).removeClass("active"),p(".sej-top-subscribe").removeClass("active")),".top-icons-drop"==e&&(p(e).removeClass("active"),p(".top-subscribe").removeClass("active")),".top-icons-drop"==e&&(p(e).removeClass("active"),p(".top-subscribe").removeClass("active")),".sej-mobile-section-menu"==e&&(p(e).removeClass("active"),p(".open-button").removeClass("sej_hovered"),p(".open-button_m").toggleClass("active"),p(".open-button_m").toggleClass("fa-close"),p(".open-button_m").toggleClass("fa-bars"),p("body").removeClass("menu-cover"),p("body").removeClass("no-overflow-mob"),p("html").removeClass("no-overflow-mob")))}p(".new-guide-ul-nav").find(".nolink > a").click(function(){p(this).next().slideToggle("fast"),p(".new-guide-ul-nav .sub-menu").not(p(this).next()).slideUp("fast")}),p("#select-webinar").change(function(){p(".select-webinar-form").submit()}),p(".i-drop-down").mouseenter(function(){p(".dropdown-social-menu").removeClass("display-none"),p(".i-drop-down").addClass("active-dropdown")}).mouseleave(function(){p(".dropdown-social-menu").addClass("display-none"),p(".i-drop-down").removeClass("active-dropdown")}),p(".sej-tabs-nav a").click(function(e){e.preventDefault(),p(this).parents(".sej-tabs-nav").find("a").each(function(){p(this).removeClass("sej-tab-active"),p("#"+p(this).attr("data-id")).addClass("inactive")}),"yes"!=p(this).attr("data-flazy")&&"posts-tab-2"==p(this).attr("data-id")&&(p("#posts-tab-2 img.lazy").trigger("sej-force-lazy"),p(this).attr("data-flazy","yes")),p(this).addClass("sej-tab-active"),p("#"+p(this).attr("data-id")).removeClass("inactive")}),0<p(".gform").length&&_(p(".gform")),p("input").change(function(){""!=p(this).attr("class")&&/wpcf7/i.test(p(this).attr("class"))||g(p(this))}),p("select").change(function(){""!=p(this).attr("class")&&/wpcf7/i.test(p(this).attr("class"))||g(p(this))}),0<p("#mce-country").length&&(new Selectr(document.getElementById("mce-country")),p("#mce-country").change(function(){"United States"==p(this).find("option:selected").val()?(p("#parent-state").css({display:"block"}),p("#mce-state option").prop("selected","")):(p("#parent-state").css({display:"none"}),p("#parent-state option[value='Other']").prop("selected",!0))}),new Selectr(document.getElementById("mce-state"))),p("body").delegate(".sej2017_validate_form","submit",function(e){var t=!0,o=p(this),n=!0;if(o.find(".sej_validate").each(function(){g(p(this))||(t=!1)}),!t)return o.find(".sej_final_message").html("Validation errors occurred."),o.find(".sej_final_message").removeClass("dnone").addClass("sej_error_message").show(),!1;o.find(".sej_final_message").addClass("dnone").hide(),_(o);var s,i,r,a,l,d,c,u,h,m,f,v=!1;return(0<p(".post-link").length||void 0===p(this).attr("data-hosted")&&0<p(".listid-form",this).length&&0<p(".reduri-form",this).length)&&(v=!0),v&&t&&(e.preventDefault(),s=p(".listid-form",this).val(),i=p(".reduri-form",this).val(),r=p(".reduri-form-success",this).val(),a=p(".sej_email",this).val(),l=p(".wsource",this).val(),d=p(this).serializeArray(),c=p('input[type="submit"]',this).val(),u=null,0<p(".post-link").length&&"web-form"==o.attr("id")&&(u=p(".post-link",this).val(),h=p(".webinar_id",this).val(),m=p(".post_id",this).val()),a&&(o.find('input[type="submit"]').val("Please wait..."),f=null!=u&&"web-form"==o.attr("id")?{action:"mcheck_em",pid:m,email:a,wsource:l,post_link:u,data:d,webinar_id:h}:("undefined"!=typeof fbq&&fbq("trackCustom","NewsletterSubscribe",{content_name:l}),{action:"mcheck",lid:s,email:a,wsource:l,data:d}),p.ajax({type:"POST",url:ajaxurl,data:f,success:function(e){{var t,s,a;o.find('input[type="submit"]').val(c),e&&void 0!==(t=e).message&&(0<o.find(".sej_final_message").length&&(1==t.success?(o.find(".sej_final_message").addClass("greentheme"),o.find(".sej_final_message").removeClass("sej_error_message")):o.find(".sej_final_message").addClass("sej_error_message"),o.find(".sej_final_message").removeClass("dnone"),o.find(".sej_final_message").html(t.message),o.find(".sej_final_message").show(),"web-form"==o.attr("id")&&1==t.success&&(o.hide(),p("#web-watch-mess").html(t.message).removeClass("dnone"),"undefined"!=typeof __gaTracker&&__gaTracker("send","event","Webinar Recap Sign Up",u),p("html, body").animate({scrollTop:p(".reg-watch").offset().top-100},500))),4==t.success&&"web-form"==o.attr("id")&&(p(".reg-watch").find(".g-recaptcha>div").addClass("input-error"),p(".reg-watch").find(".captcha_error.sej_final_message").removeClass("dnone").html("Wrong Captcha").show()),0==t.success&&(window.location.href=t.post_link),-1==t.success&&(window.location.href=i),1==t.success&&"web-form"!=o.attr("id")&&(window.location.href=r),1!=t.success&&-1!=t.success||p(this).attr("data-trigger")&&n&&p(document).trigger(p(this).attr("data-trigger")),-2!=t.success&&2!=t.success||!o.hasClass("gform")||(window.location.href=r),-2==t.success&&0<o.find(".sej_alter_sub").length&&(s=o.find(".sej_alter_sub").val(),a='<br/>Please try again by using this link <a target="_blank" href="'+s+'">'+s+"</a>.",o.find(".sej_final_message").html(a).addClass("sej_error_message")))}}}))),p(this).attr("data-trigger")&&p(document).trigger(p(this).attr("data-trigger"),p(this)),!p(this).attr("data-hosted")&&void 0}),0!=p(".sej_show_on_scroll").length&&p(window).on("resize scroll load",function(e){!function(){var e;window.innerWidth<=1180?p(".sej_show_on_scroll").stop().animate({width:100},500,function(){p(".sej_show_on_scroll .sej-logo").addClass("sej_show"),p(".sej-l-sect").addClass("sej_animated"),p(".sej-l-sect").removeClass("margin-0"),p(".sej-top-menu").removeClass("margin-m-17"),p(".flex-nav").addClass("acomplete"),p(this).css("width","auto")}):(e=p(this).scrollTop(),0<p("#wpadminbar").length&&(e+=p("#wpadminbar").height()),0==p(".acomplete").length&&180<=e&&p(".sej_show_on_scroll").stop().animate({width:205},500,function(){p(".sej_show_on_scroll .sej-logo").addClass("sej_show"),p(".sej-l-sect").addClass("sej_animated"),p(".sej-l-sect").removeClass("margin-0"),p(".flex-nav").addClass("acomplete")}),e<180&&(p(".sej_show_on_scroll .sej-logo").removeClass("sej_show"),p(".logo-sect").removeClass("sej_animated"),p(".logo-sect .sej-logo-section").addClass("margin-0"),p(".sej_show_on_scroll").stop().animate({width:0},500,function(){p(".flex-nav").removeClass("acomplete")})))}(e.type)}),p(".sej_home_featured_tab").on("mouseenter",function(e){1024<=window.innerWidth&&(e.preventDefault(),s(p(this).data("id"),!0),clearInterval(i),i=setInterval(function(){s(void 0!==p(".sej_home_featured_tab.selected").next("li").data("id")?p(".sej_home_featured_tab.selected").next("li").data("id"):p(".sej_home_featured_tab").first().data("id"),!1)},6e3))}),p(".sej-top-container").on("mouseleave",function(e){p(this).removeClass("sej_mouse_over")}),p(".sej-top-container").on("mouseenter",function(e){p(this).addClass("sej_mouse_over")}),p(".sej_home_featured_tab").on("click",function(e){var t;1024<=window.innerWidth&&(void 0!==(t=p(".sej-ptitle a",this).attr("href"))&&(window.location=t))}),0!=p(".sej_home_featured_tab").length&&(t=window.home_first_slide,b_webp&&(t=t.substr(0,t.lastIndexOf("."))+".webp"),p(".sej_big_featured_image").css("background-image","url("+t+")"),p(window).on("load",function(){1024<=window.innerWidth&&(i=setInterval(function(){s(void 0!==p(".sej_home_featured_tab.selected").next("li").data("id")?p(".sej_home_featured_tab.selected").next("li").data("id"):p(".sej_home_featured_tab").first().data("id"))},6e3))})),p(".menu-sect  a, .sej-mobile-menu .sej-submenu a").click(function(e){var t,s;"undefined"!=typeof __gaTracker&&(t=p(this).hasClass("sub-m-cat")?p(this).attr("data-ga"):p(this).parents("ul").attr("data-ga"),s=p.trim(p(this).text()),__gaTracker("send","event","Main Menu Click",t,s))}),p(".sej-slide-list .sej_home_featured_tab").click(function(e){"undefined"!=typeof __gaTracker&&__gaTracker("send","event","Home Slider Click",p(this).index()+1)}),p(".s_spons a, .sponsored-logo a, #stckbtn").click(function(){"undefined"==typeof the_permalink&&(the_permalink=window.location.href),__gaTracker("send","event","Cover Format Sponsored Posts Clicks",the_permalink,p(this).attr("href"))});var o,n=!0;p("[data-ga-sub]").click(function(){n&&"undefined"!=typeof __gaTracker&&void 0!==p(this).attr("data-ga-sub")&&(__gaTracker("send","event","Newsletter Sign Up",p(this).attr("data-ga-sub"),window.location.href),n=!1)}),p(".sej-article-content a").click(function(){"undefined"!=typeof __gaTracker&&void 0===p(this).attr("data-ga-sub")&&__gaTracker("send","event","outbound-link",p(this).attr("href"))}),p(".nav-bar-cta").click(function(){"undefined"!=typeof __gaTracker&&(p(this).attr("data-show")?__gaTracker("send","event","Nav Bar CTA","Subscribe"):__gaTracker("send","event","Nav Bar CTA",p(this).attr("href")),0<p(".sej-t-link").length&&"true"==p(this).attr("data-tk")&&__gaTracker("send","event","Background Takeover","Nav Bar Image",p(this).attr("href")))}),p("body").delegate(".sej2017_home_slider_big_title a","click",function(e){"undefined"!=typeof __gaTracker&&__gaTracker("send","event","Homepage Featured Posts Var 1 Click",p(this).attr("href"))}),p(".mobile-device #aweber-form").removeAttr("target"),0<p("ul.checkbox-list").length&&p("ul.checkbox-list li").each(function(){var e=p(this).text();p(this).html('<input type="checkbox" />'+e)}),o=function(n){function i(e,t){var s=n(this);if(this.value===s.attr(d?"placeholder-x":"placeholder")&&s.hasClass(h.customClass))if(this.value="",s.removeClass(h.customClass),s.data("placeholder-password")){if(s=s.hide().nextAll('input[type="password"]:first').show().attr("id",s.removeAttr("id").data("placeholder-id")),!0===e)return s[0].value=t;s.focus()}else this==l()&&this.select()}function r(e){var t,s=n(this),a=this.id;if(!e||"blur"!==e.type||!s.hasClass(h.customClass))if(""===this.value){if("password"===this.type){if(!s.data("placeholder-textinput")){try{t=s.clone().prop({type:"text"})}catch(e){t=n("<input>").attr(n.extend(function(e){var s={},a=/^jQuery\d+$/;return n.each(e.attributes,function(e,t){t.specified&&!a.test(t.name)&&(s[t.name]=t.value)}),s}(this),{type:"text"}))}t.removeAttr("name").data({"placeholder-enabled":!0,"placeholder-password":s,"placeholder-id":a}).bind("focus.placeholder",i),s.data({"placeholder-textinput":t,"placeholder-id":a}).before(t)}this.value="",s=s.removeAttr("id").hide().prevAll('input[type="text"]:first').attr("id",s.data("placeholder-id")).show()}else{var o=s.data("placeholder-password");o&&(o[0].value="",s.attr("id",s.data("placeholder-id")).show().nextAll('input[type="password"]:last').hide().removeAttr("id"))}s.addClass(h.customClass),s[0].value=s.attr(d?"placeholder-x":"placeholder")}else s.removeClass(h.customClass)}function l(){try{return document.activeElement}catch(e){}}var e,t,d=!1,s="[object OperaMini]"===Object.prototype.toString.call(window.operamini),a="placeholder"in document.createElement("input")&&!s&&!d,o="placeholder"in document.createElement("textarea")&&!s&&!d,c=n.valHooks,u=n.propHooks,h={};a&&o?((t=n.fn.placeholder=function(){return this}).input=!0,t.textarea=!0):((t=n.fn.placeholder=function(e){return h=n.extend({},{customClass:"placeholder"},e),this.filter((a?"textarea":":input")+"["+(d?"placeholder-x":"placeholder")+"]").not("."+h.customClass).not(":radio, :checkbox, [type=hidden]").bind({"focus.placeholder":i,"blur.placeholder":r}).data("placeholder-enabled",!0).trigger("blur.placeholder")}).input=a,t.textarea=o,e={get:function(e){var t=n(e),s=t.data("placeholder-password");return s?s[0].value:t.data("placeholder-enabled")&&t.hasClass(h.customClass)?"":e.value},set:function(e,t){var s,a,o=n(e);return""!==t&&(s=o.data("placeholder-textinput"),a=o.data("placeholder-password"),s?(i.call(s[0],!0,t)||(e.value=t),s[0].value=t):a&&(i.call(e,!0,t)||(a[0].value=t),e.value=t)),o.data("placeholder-enabled")?""===t?(e.value=t,e!=l()&&r.call(e)):(o.hasClass(h.customClass)&&i.call(e),e.value=t):e.value=t,o}},a||(c.input=e,u.value=e),o||(c.textarea=e,u.value=e),n(function(){n(document).delegate("form","submit.placeholder",function(){var e=n("."+h.customClass,this).each(function(){i.call(this,!0,"")});setTimeout(function(){e.each(r)},10)})}),n(window).bind("beforeunload.placeholder",function(){var e=!0;try{"javascript:void(0)"===document.activeElement.toString()&&(e=!1)}catch(e){}e&&n("."+h.customClass).each(function(){this.value=""})}))},"function"==typeof define&&define.amd?define(["jquery"],o):o("object"==typeof module&&module.exports?require("jquery"):jQuery),p("input, textarea").placeholder()})});