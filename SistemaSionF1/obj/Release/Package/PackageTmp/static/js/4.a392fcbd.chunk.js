(this["webpackJsonp@coreui/coreui-free-react-admin-template"]=this["webpackJsonp@coreui/coreui-free-react-admin-template"]||[]).push([[4],{478:function(t,e,n){"use strict";n.d(e,"m",(function(){return r})),n.d(e,"c",(function(){return o})),n.d(e,"k",(function(){return i})),n.d(e,"f",(function(){return a})),n.d(e,"a",(function(){return c})),n.d(e,"b",(function(){return f})),n.d(e,"l",(function(){return u})),n.d(e,"e",(function(){return s})),n.d(e,"d",(function(){return d})),n.d(e,"o",(function(){return p})),n.d(e,"i",(function(){return l})),n.d(e,"j",(function(){return b})),n.d(e,"n",(function(){return O})),n.d(e,"h",(function(){return h})),n.d(e,"g",(function(){return m}));var r="top",o="bottom",i="right",a="left",c="auto",f=[r,o,i,a],u="start",s="end",d="clippingParents",p="viewport",l="popper",b="reference",O=f.reduce((function(t,e){return t.concat([e+"-"+u,e+"-"+s])}),[]),h=[].concat(f,[c]).reduce((function(t,e){return t.concat([e,e+"-"+u,e+"-"+s])}),[]),m=["beforeRead","read","afterRead","beforeMain","main","afterMain","beforeWrite","write","afterWrite"]},483:function(t,e,n){"use strict";n.d(e,"a",(function(){return o})),n.d(e,"b",(function(){return i})),n.d(e,"c",(function(){return a}));var r=n(489);function o(t){return t instanceof Object(r.a)(t).Element||t instanceof Element}function i(t){return t instanceof Object(r.a)(t).HTMLElement||t instanceof HTMLElement}function a(t){return"undefined"!==typeof ShadowRoot&&(t instanceof Object(r.a)(t).ShadowRoot||t instanceof ShadowRoot)}},489:function(t,e,n){"use strict";function r(t){if(null==t)return window;if("[object Window]"!==t.toString()){var e=t.ownerDocument;return e&&e.defaultView||window}return t}n.d(e,"a",(function(){return r}))},492:function(t,e,n){"use strict";function r(t){return t.split("-")[0]}n.d(e,"a",(function(){return r}))},493:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var r=n(483);function o(t){return((Object(r.a)(t)?t.ownerDocument:t.document)||window.document).documentElement}},498:function(t,e,n){"use strict";function r(t){return t?(t.nodeName||"").toLowerCase():null}n.d(e,"a",(function(){return r}))},502:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var r=n(489);function o(t){return Object(r.a)(t).getComputedStyle(t)}},503:function(t,e,n){"use strict";n.d(e,"a",(function(){return x}));var r=n(527),o=n(478),i=n(489),a=n(493),c=n(592);var f=n(502),u=n(593),s=n(526);var d=n(695),p=n(537),l=n(483),b=n(546),O=n(679),h=n(498);function m(t){return Object.assign({},t,{left:t.x,top:t.y,right:t.x+t.width,bottom:t.y+t.height})}function v(t,e){return e===o.o?m(function(t){var e=Object(i.a)(t),n=Object(a.a)(t),r=e.visualViewport,o=n.clientWidth,f=n.clientHeight,u=0,s=0;return r&&(o=r.width,f=r.height,/^((?!chrome|android).)*safari/i.test(navigator.userAgent)||(u=r.offsetLeft,s=r.offsetTop)),{width:o,height:f,x:u+Object(c.a)(t),y:s}}(t)):Object(l.b)(e)?function(t){var e=Object(r.a)(t);return e.top=e.top+t.clientTop,e.left=e.left+t.clientLeft,e.bottom=e.top+t.clientHeight,e.right=e.left+t.clientWidth,e.width=t.clientWidth,e.height=t.clientHeight,e.x=e.left,e.y=e.top,e}(e):m(function(t){var e,n=Object(a.a)(t),r=Object(u.a)(t),o=null==(e=t.ownerDocument)?void 0:e.body,i=Object(s.a)(n.scrollWidth,n.clientWidth,o?o.scrollWidth:0,o?o.clientWidth:0),d=Object(s.a)(n.scrollHeight,n.clientHeight,o?o.scrollHeight:0,o?o.clientHeight:0),p=-r.scrollLeft+Object(c.a)(t),l=-r.scrollTop;return"rtl"===Object(f.a)(o||n).direction&&(p+=Object(s.a)(n.clientWidth,o?o.clientWidth:0)-i),{width:i,height:d,x:p,y:l}}(Object(a.a)(t)))}function j(t,e,n){var r="clippingParents"===e?function(t){var e=Object(d.a)(Object(b.a)(t)),n=["absolute","fixed"].indexOf(Object(f.a)(t).position)>=0&&Object(l.b)(t)?Object(p.a)(t):t;return Object(l.a)(n)?e.filter((function(t){return Object(l.a)(t)&&Object(O.a)(t,n)&&"body"!==Object(h.a)(t)})):[]}(t):[].concat(e),o=[].concat(r,[n]),i=o[0],a=o.reduce((function(e,n){var r=v(t,n);return e.top=Object(s.a)(r.top,e.top),e.right=Object(s.b)(r.right,e.right),e.bottom=Object(s.b)(r.bottom,e.bottom),e.left=Object(s.a)(r.left,e.left),e}),v(t,i));return a.width=a.right-a.left,a.height=a.bottom-a.top,a.x=a.left,a.y=a.top,a}var g=n(673),y=n(676),w=n(678);function x(t,e){void 0===e&&(e={});var n=e,i=n.placement,c=void 0===i?t.placement:i,f=n.boundary,u=void 0===f?o.d:f,s=n.rootBoundary,d=void 0===s?o.o:s,p=n.elementContext,b=void 0===p?o.i:p,O=n.altBoundary,h=void 0!==O&&O,v=n.padding,x=void 0===v?0:v,k=Object(y.a)("number"!==typeof x?x:Object(w.a)(x,o.b)),D=b===o.i?o.j:o.i,E=t.elements.reference,L=t.rects.popper,M=t.elements[h?D:b],W=j(Object(l.a)(M)?M:M.contextElement||Object(a.a)(t.elements.popper),u,d),P=Object(r.a)(E),B=Object(g.a)({reference:P,element:L,strategy:"absolute",placement:c}),H=m(Object.assign({},L,B)),R=b===o.i?H:P,A={top:W.top-R.top+k.top,bottom:R.bottom-W.bottom+k.bottom,left:W.left-R.left+k.left,right:R.right-W.right+k.right},T=t.modifiersData.offset;if(b===o.i&&T){var C=T[c];Object.keys(A).forEach((function(t){var e=[o.k,o.c].indexOf(t)>=0?1:-1,n=[o.m,o.c].indexOf(t)>=0?"y":"x";A[t]+=C[n]*e}))}return A}},526:function(t,e,n){"use strict";n.d(e,"a",(function(){return r})),n.d(e,"b",(function(){return o})),n.d(e,"c",(function(){return i}));var r=Math.max,o=Math.min,i=Math.round},527:function(t,e,n){"use strict";n.d(e,"a",(function(){return i}));var r=n(483),o=Math.round;function i(t,e){void 0===e&&(e=!1);var n=t.getBoundingClientRect(),i=1,a=1;return Object(r.b)(t)&&e&&(i=n.width/t.offsetWidth||1,a=n.height/t.offsetHeight||1),{width:o(n.width/i),height:o(n.height/a),top:o(n.top/a),right:o(n.right/i),bottom:o(n.bottom/a),left:o(n.left/i),x:o(n.left/i),y:o(n.top/a)}}},537:function(t,e,n){"use strict";n.d(e,"a",(function(){return s}));var r=n(489),o=n(498),i=n(502),a=n(483);function c(t){return["table","td","th"].indexOf(Object(o.a)(t))>=0}var f=n(546);function u(t){return Object(a.b)(t)&&"fixed"!==Object(i.a)(t).position?t.offsetParent:null}function s(t){for(var e=Object(r.a)(t),n=u(t);n&&c(n)&&"static"===Object(i.a)(n).position;)n=u(n);return n&&("html"===Object(o.a)(n)||"body"===Object(o.a)(n)&&"static"===Object(i.a)(n).position)?e:n||function(t){var e=-1!==navigator.userAgent.toLowerCase().indexOf("firefox");if(-1!==navigator.userAgent.indexOf("Trident")&&Object(a.b)(t)&&"fixed"===Object(i.a)(t).position)return null;for(var n=Object(f.a)(t);Object(a.b)(n)&&["html","body"].indexOf(Object(o.a)(n))<0;){var r=Object(i.a)(n);if("none"!==r.transform||"none"!==r.perspective||"paint"===r.contain||-1!==["transform","perspective"].indexOf(r.willChange)||e&&"filter"===r.willChange||e&&r.filter&&"none"!==r.filter)return n;n=n.parentNode}return null}(t)||e}},545:function(t,e,n){"use strict";function r(t){return t.split("-")[1]}n.d(e,"a",(function(){return r}))},546:function(t,e,n){"use strict";n.d(e,"a",(function(){return a}));var r=n(498),o=n(493),i=n(483);function a(t){return"html"===Object(r.a)(t)?t:t.assignedSlot||t.parentNode||(Object(i.c)(t)?t.host:null)||Object(o.a)(t)}},591:function(t,e,n){"use strict";function r(t){return["top","bottom"].indexOf(t)>=0?"x":"y"}n.d(e,"a",(function(){return r}))},592:function(t,e,n){"use strict";n.d(e,"a",(function(){return a}));var r=n(527),o=n(493),i=n(593);function a(t){return Object(r.a)(Object(o.a)(t)).left+Object(i.a)(t).scrollLeft}},593:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var r=n(489);function o(t){var e=Object(r.a)(t);return{scrollLeft:e.pageXOffset,scrollTop:e.pageYOffset}}},594:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var r=n(502);function o(t){var e=Object(r.a)(t),n=e.overflow,o=e.overflowX,i=e.overflowY;return/auto|scroll|overlay|hidden/.test(n+i+o)}},595:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var r=n(527);function o(t){var e=Object(r.a)(t),n=t.offsetWidth,o=t.offsetHeight;return Math.abs(e.width-n)<=1&&(n=e.width),Math.abs(e.height-o)<=1&&(o=e.height),{x:t.offsetLeft,y:t.offsetTop,width:n,height:o}}},671:function(t,e,n){"use strict";var r=n(489),o={passive:!0};e.a={name:"eventListeners",enabled:!0,phase:"write",fn:function(){},effect:function(t){var e=t.state,n=t.instance,i=t.options,a=i.scroll,c=void 0===a||a,f=i.resize,u=void 0===f||f,s=Object(r.a)(e.elements.popper),d=[].concat(e.scrollParents.reference,e.scrollParents.popper);return c&&d.forEach((function(t){t.addEventListener("scroll",n.update,o)})),u&&s.addEventListener("resize",n.update,o),function(){c&&d.forEach((function(t){t.removeEventListener("scroll",n.update,o)})),u&&s.removeEventListener("resize",n.update,o)}},data:{}}},672:function(t,e,n){"use strict";var r=n(673);e.a={name:"popperOffsets",enabled:!0,phase:"read",fn:function(t){var e=t.state,n=t.name;e.modifiersData[n]=Object(r.a)({reference:e.rects.reference,element:e.rects.popper,strategy:"absolute",placement:e.placement})},data:{}}},673:function(t,e,n){"use strict";n.d(e,"a",(function(){return c}));var r=n(492),o=n(545),i=n(591),a=n(478);function c(t){var e,n=t.reference,c=t.element,f=t.placement,u=f?Object(r.a)(f):null,s=f?Object(o.a)(f):null,d=n.x+n.width/2-c.width/2,p=n.y+n.height/2-c.height/2;switch(u){case a.m:e={x:d,y:n.y-c.height};break;case a.c:e={x:d,y:n.y+n.height};break;case a.k:e={x:n.x+n.width,y:p};break;case a.f:e={x:n.x-c.width,y:p};break;default:e={x:n.x,y:n.y}}var l=u?Object(i.a)(u):null;if(null!=l){var b="y"===l?"height":"width";switch(s){case a.l:e[l]=e[l]-(n[b]/2-c[b]/2);break;case a.e:e[l]=e[l]+(n[b]/2-c[b]/2)}}return e}},674:function(t,e,n){"use strict";var r=n(478),o=n(537),i=n(489),a=n(493),c=n(502),f=n(492),u=n(526),s={top:"auto",right:"auto",bottom:"auto",left:"auto"};function d(t){var e,n=t.popper,f=t.popperRect,d=t.placement,p=t.offsets,l=t.position,b=t.gpuAcceleration,O=t.adaptive,h=t.roundOffsets,m=!0===h?function(t){var e=t.x,n=t.y,r=window.devicePixelRatio||1;return{x:Object(u.c)(Object(u.c)(e*r)/r)||0,y:Object(u.c)(Object(u.c)(n*r)/r)||0}}(p):"function"===typeof h?h(p):p,v=m.x,j=void 0===v?0:v,g=m.y,y=void 0===g?0:g,w=p.hasOwnProperty("x"),x=p.hasOwnProperty("y"),k=r.f,D=r.m,E=window;if(O){var L=Object(o.a)(n),M="clientHeight",W="clientWidth";L===Object(i.a)(n)&&(L=Object(a.a)(n),"static"!==Object(c.a)(L).position&&(M="scrollHeight",W="scrollWidth")),L=L,d===r.m&&(D=r.c,y-=L[M]-f.height,y*=b?1:-1),d===r.f&&(k=r.k,j-=L[W]-f.width,j*=b?1:-1)}var P,B=Object.assign({position:l},O&&s);return b?Object.assign({},B,((P={})[D]=x?"0":"",P[k]=w?"0":"",P.transform=(E.devicePixelRatio||1)<2?"translate("+j+"px, "+y+"px)":"translate3d("+j+"px, "+y+"px, 0)",P)):Object.assign({},B,((e={})[D]=x?y+"px":"",e[k]=w?j+"px":"",e.transform="",e))}e.a={name:"computeStyles",enabled:!0,phase:"beforeWrite",fn:function(t){var e=t.state,n=t.options,r=n.gpuAcceleration,o=void 0===r||r,i=n.adaptive,a=void 0===i||i,c=n.roundOffsets,u=void 0===c||c,s={placement:Object(f.a)(e.placement),popper:e.elements.popper,popperRect:e.rects.popper,gpuAcceleration:o};null!=e.modifiersData.popperOffsets&&(e.styles.popper=Object.assign({},e.styles.popper,d(Object.assign({},s,{offsets:e.modifiersData.popperOffsets,position:e.options.strategy,adaptive:a,roundOffsets:u})))),null!=e.modifiersData.arrow&&(e.styles.arrow=Object.assign({},e.styles.arrow,d(Object.assign({},s,{offsets:e.modifiersData.arrow,position:"absolute",adaptive:!1,roundOffsets:u})))),e.attributes.popper=Object.assign({},e.attributes.popper,{"data-popper-placement":e.placement})},data:{}}},675:function(t,e,n){"use strict";var r=n(492),o=n(478);e.a={name:"offset",enabled:!0,phase:"main",requires:["popperOffsets"],fn:function(t){var e=t.state,n=t.options,i=t.name,a=n.offset,c=void 0===a?[0,0]:a,f=o.h.reduce((function(t,n){return t[n]=function(t,e,n){var i=Object(r.a)(t),a=[o.f,o.m].indexOf(i)>=0?-1:1,c="function"===typeof n?n(Object.assign({},e,{placement:t})):n,f=c[0],u=c[1];return f=f||0,u=(u||0)*a,[o.f,o.k].indexOf(i)>=0?{x:u,y:f}:{x:f,y:u}}(n,e.rects,c),t}),{}),u=f[e.placement],s=u.x,d=u.y;null!=e.modifiersData.popperOffsets&&(e.modifiersData.popperOffsets.x+=s,e.modifiersData.popperOffsets.y+=d),e.modifiersData[i]=f}}},676:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var r=n(677);function o(t){return Object.assign({},Object(r.a)(),t)}},677:function(t,e,n){"use strict";function r(){return{top:0,right:0,bottom:0,left:0}}n.d(e,"a",(function(){return r}))},678:function(t,e,n){"use strict";function r(t,e){return e.reduce((function(e,n){return e[n]=t,e}),{})}n.d(e,"a",(function(){return r}))},679:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var r=n(483);function o(t,e){var n=e.getRootNode&&e.getRootNode();if(t.contains(e))return!0;if(n&&Object(r.c)(n)){var o=e;do{if(o&&t.isSameNode(o))return!0;o=o.parentNode||o.host}while(o)}return!1}},680:function(t,e,n){"use strict";n.d(e,"a",(function(){return o}));var r=n(526);function o(t,e,n){return Object(r.a)(t,Object(r.b)(e,n))}},681:function(t,e,n){"use strict";var r=n(492),o=n(595),i=n(679),a=n(537),c=n(591),f=n(680),u=n(676),s=n(678),d=n(478);e.a={name:"arrow",enabled:!0,phase:"main",fn:function(t){var e,n=t.state,i=t.name,p=t.options,l=n.elements.arrow,b=n.modifiersData.popperOffsets,O=Object(r.a)(n.placement),h=Object(c.a)(O),m=[d.f,d.k].indexOf(O)>=0?"height":"width";if(l&&b){var v=function(t,e){return t="function"===typeof t?t(Object.assign({},e.rects,{placement:e.placement})):t,Object(u.a)("number"!==typeof t?t:Object(s.a)(t,d.b))}(p.padding,n),j=Object(o.a)(l),g="y"===h?d.m:d.f,y="y"===h?d.c:d.k,w=n.rects.reference[m]+n.rects.reference[h]-b[h]-n.rects.popper[m],x=b[h]-n.rects.reference[h],k=Object(a.a)(l),D=k?"y"===h?k.clientHeight||0:k.clientWidth||0:0,E=w/2-x/2,L=v[g],M=D-j[m]-v[y],W=D/2-j[m]/2+E,P=Object(f.a)(L,W,M),B=h;n.modifiersData[i]=((e={})[B]=P,e.centerOffset=P-W,e)}},effect:function(t){var e=t.state,n=t.options.element,r=void 0===n?"[data-popper-arrow]":n;null!=r&&("string"!==typeof r||(r=e.elements.popper.querySelector(r)))&&Object(i.a)(e.elements.popper,r)&&(e.elements.arrow=r)},requires:["popperOffsets"],requiresIfExists:["preventOverflow"]}},682:function(t,e,n){"use strict";var r=n(478),o=n(503);function i(t,e,n){return void 0===n&&(n={x:0,y:0}),{top:t.top-e.height-n.y,right:t.right-e.width+n.x,bottom:t.bottom-e.height+n.y,left:t.left-e.width-n.x}}function a(t){return[r.m,r.k,r.c,r.f].some((function(e){return t[e]>=0}))}e.a={name:"hide",enabled:!0,phase:"main",requiresIfExists:["preventOverflow"],fn:function(t){var e=t.state,n=t.name,r=e.rects.reference,c=e.rects.popper,f=e.modifiersData.preventOverflow,u=Object(o.a)(e,{elementContext:"reference"}),s=Object(o.a)(e,{altBoundary:!0}),d=i(u,r),p=i(s,c,f),l=a(d),b=a(p);e.modifiersData[n]={referenceClippingOffsets:d,popperEscapeOffsets:p,isReferenceHidden:l,hasPopperEscaped:b},e.attributes.popper=Object.assign({},e.attributes.popper,{"data-popper-reference-hidden":l,"data-popper-escaped":b})}}},688:function(t,e,n){"use strict";n.d(e,"a",(function(){return g}));var r=n(527),o=n(593),i=n(489),a=n(483);var c=n(498),f=n(592),u=n(493),s=n(594);function d(t,e,n){void 0===n&&(n=!1);var d=Object(a.b)(e),p=Object(a.b)(e)&&function(t){var e=t.getBoundingClientRect(),n=e.width/t.offsetWidth||1,r=e.height/t.offsetHeight||1;return 1!==n||1!==r}(e),l=Object(u.a)(e),b=Object(r.a)(t,p),O={scrollLeft:0,scrollTop:0},h={x:0,y:0};return(d||!d&&!n)&&(("body"!==Object(c.a)(e)||Object(s.a)(l))&&(O=function(t){return t!==Object(i.a)(t)&&Object(a.b)(t)?{scrollLeft:(e=t).scrollLeft,scrollTop:e.scrollTop}:Object(o.a)(t);var e}(e)),Object(a.b)(e)?((h=Object(r.a)(e,!0)).x+=e.clientLeft,h.y+=e.clientTop):l&&(h.x=Object(f.a)(l))),{x:b.left+O.scrollLeft-h.x,y:b.top+O.scrollTop-h.y,width:b.width,height:b.height}}var p=n(595),l=n(695),b=n(537),O=n(478);function h(t){var e=new Map,n=new Set,r=[];function o(t){n.add(t.name),[].concat(t.requires||[],t.requiresIfExists||[]).forEach((function(t){if(!n.has(t)){var r=e.get(t);r&&o(r)}})),r.push(t)}return t.forEach((function(t){e.set(t.name,t)})),t.forEach((function(t){n.has(t.name)||o(t)})),r}function m(t){var e;return function(){return e||(e=new Promise((function(n){Promise.resolve().then((function(){e=void 0,n(t())}))}))),e}}var v={placement:"bottom",modifiers:[],strategy:"absolute"};function j(){for(var t=arguments.length,e=new Array(t),n=0;n<t;n++)e[n]=arguments[n];return!e.some((function(t){return!(t&&"function"===typeof t.getBoundingClientRect)}))}function g(t){void 0===t&&(t={});var e=t,n=e.defaultModifiers,r=void 0===n?[]:n,o=e.defaultOptions,i=void 0===o?v:o;return function(t,e,n){void 0===n&&(n=i);var o={placement:"bottom",orderedModifiers:[],options:Object.assign({},v,i),modifiersData:{},elements:{reference:t,popper:e},attributes:{},styles:{}},c=[],f=!1,u={state:o,setOptions:function(n){s(),o.options=Object.assign({},i,o.options,n),o.scrollParents={reference:Object(a.a)(t)?Object(l.a)(t):t.contextElement?Object(l.a)(t.contextElement):[],popper:Object(l.a)(e)};var f=function(t){var e=h(t);return O.g.reduce((function(t,n){return t.concat(e.filter((function(t){return t.phase===n})))}),[])}(function(t){var e=t.reduce((function(t,e){var n=t[e.name];return t[e.name]=n?Object.assign({},n,e,{options:Object.assign({},n.options,e.options),data:Object.assign({},n.data,e.data)}):e,t}),{});return Object.keys(e).map((function(t){return e[t]}))}([].concat(r,o.options.modifiers)));return o.orderedModifiers=f.filter((function(t){return t.enabled})),o.orderedModifiers.forEach((function(t){var e=t.name,n=t.options,r=void 0===n?{}:n,i=t.effect;if("function"===typeof i){var a=i({state:o,name:e,instance:u,options:r}),f=function(){};c.push(a||f)}})),u.update()},forceUpdate:function(){if(!f){var t=o.elements,e=t.reference,n=t.popper;if(j(e,n)){o.rects={reference:d(e,Object(b.a)(n),"fixed"===o.options.strategy),popper:Object(p.a)(n)},o.reset=!1,o.placement=o.options.placement,o.orderedModifiers.forEach((function(t){return o.modifiersData[t.name]=Object.assign({},t.data)}));for(var r=0;r<o.orderedModifiers.length;r++)if(!0!==o.reset){var i=o.orderedModifiers[r],a=i.fn,c=i.options,s=void 0===c?{}:c,l=i.name;"function"===typeof a&&(o=a({state:o,options:s,name:l,instance:u})||o)}else o.reset=!1,r=-1}}},update:m((function(){return new Promise((function(t){u.forceUpdate(),t(o)}))})),destroy:function(){s(),f=!0}};if(!j(t,e))return u;function s(){c.forEach((function(t){return t()})),c=[]}return u.setOptions(n).then((function(t){!f&&n.onFirstUpdate&&n.onFirstUpdate(t)})),u}}},690:function(t,e,n){"use strict";var r={left:"right",right:"left",bottom:"top",top:"bottom"};function o(t){return t.replace(/left|right|bottom|top/g,(function(t){return r[t]}))}var i=n(492),a={start:"end",end:"start"};function c(t){return t.replace(/start|end/g,(function(t){return a[t]}))}var f=n(503),u=n(545),s=n(478);e.a={name:"flip",enabled:!0,phase:"main",fn:function(t){var e=t.state,n=t.options,r=t.name;if(!e.modifiersData[r]._skip){for(var a=n.mainAxis,d=void 0===a||a,p=n.altAxis,l=void 0===p||p,b=n.fallbackPlacements,O=n.padding,h=n.boundary,m=n.rootBoundary,v=n.altBoundary,j=n.flipVariations,g=void 0===j||j,y=n.allowedAutoPlacements,w=e.options.placement,x=Object(i.a)(w),k=b||(x===w||!g?[o(w)]:function(t){if(Object(i.a)(t)===s.a)return[];var e=o(t);return[c(t),e,c(e)]}(w)),D=[w].concat(k).reduce((function(t,n){return t.concat(Object(i.a)(n)===s.a?function(t,e){void 0===e&&(e={});var n=e,r=n.placement,o=n.boundary,a=n.rootBoundary,c=n.padding,d=n.flipVariations,p=n.allowedAutoPlacements,l=void 0===p?s.h:p,b=Object(u.a)(r),O=b?d?s.n:s.n.filter((function(t){return Object(u.a)(t)===b})):s.b,h=O.filter((function(t){return l.indexOf(t)>=0}));0===h.length&&(h=O);var m=h.reduce((function(e,n){return e[n]=Object(f.a)(t,{placement:n,boundary:o,rootBoundary:a,padding:c})[Object(i.a)(n)],e}),{});return Object.keys(m).sort((function(t,e){return m[t]-m[e]}))}(e,{placement:n,boundary:h,rootBoundary:m,padding:O,flipVariations:g,allowedAutoPlacements:y}):n)}),[]),E=e.rects.reference,L=e.rects.popper,M=new Map,W=!0,P=D[0],B=0;B<D.length;B++){var H=D[B],R=Object(i.a)(H),A=Object(u.a)(H)===s.l,T=[s.m,s.c].indexOf(R)>=0,C=T?"width":"height",S=Object(f.a)(e,{placement:H,boundary:h,rootBoundary:m,altBoundary:v,padding:O}),q=T?A?s.k:s.f:A?s.c:s.m;E[C]>L[C]&&(q=o(q));var N=o(q),V=[];if(d&&V.push(S[R]<=0),l&&V.push(S[q]<=0,S[N]<=0),V.every((function(t){return t}))){P=H,W=!1;break}M.set(H,V)}if(W)for(var I=function(t){var e=D.find((function(e){var n=M.get(e);if(n)return n.slice(0,t).every((function(t){return t}))}));if(e)return P=e,"break"},U=g?3:1;U>0;U--){if("break"===I(U))break}e.placement!==P&&(e.modifiersData[r]._skip=!0,e.placement=P,e.reset=!0)}},requiresIfExists:["offset"],data:{_skip:!1}}},693:function(t,e,n){"use strict";var r=n(478),o=n(492),i=n(591);var a=n(680),c=n(595),f=n(537),u=n(503),s=n(545),d=n(677),p=n(526);e.a={name:"preventOverflow",enabled:!0,phase:"main",fn:function(t){var e=t.state,n=t.options,l=t.name,b=n.mainAxis,O=void 0===b||b,h=n.altAxis,m=void 0!==h&&h,v=n.boundary,j=n.rootBoundary,g=n.altBoundary,y=n.padding,w=n.tether,x=void 0===w||w,k=n.tetherOffset,D=void 0===k?0:k,E=Object(u.a)(e,{boundary:v,rootBoundary:j,padding:y,altBoundary:g}),L=Object(o.a)(e.placement),M=Object(s.a)(e.placement),W=!M,P=Object(i.a)(L),B="x"===P?"y":"x",H=e.modifiersData.popperOffsets,R=e.rects.reference,A=e.rects.popper,T="function"===typeof D?D(Object.assign({},e.rects,{placement:e.placement})):D,C={x:0,y:0};if(H){if(O||m){var S="y"===P?r.m:r.f,q="y"===P?r.c:r.k,N="y"===P?"height":"width",V=H[P],I=H[P]+E[S],U=H[P]-E[q],z=x?-A[N]/2:0,_=M===r.l?R[N]:A[N],F=M===r.l?-A[N]:-R[N],J=e.elements.arrow,X=x&&J?Object(c.a)(J):{width:0,height:0},Y=e.modifiersData["arrow#persistent"]?e.modifiersData["arrow#persistent"].padding:Object(d.a)(),G=Y[S],K=Y[q],Q=Object(a.a)(0,R[N],X[N]),Z=W?R[N]/2-z-Q-G-T:_-Q-G-T,$=W?-R[N]/2+z+Q+K+T:F+Q+K+T,tt=e.elements.arrow&&Object(f.a)(e.elements.arrow),et=tt?"y"===P?tt.clientTop||0:tt.clientLeft||0:0,nt=e.modifiersData.offset?e.modifiersData.offset[e.placement][P]:0,rt=H[P]+Z-nt-et,ot=H[P]+$-nt;if(O){var it=Object(a.a)(x?Object(p.b)(I,rt):I,V,x?Object(p.a)(U,ot):U);H[P]=it,C[P]=it-V}if(m){var at="x"===P?r.m:r.f,ct="x"===P?r.c:r.k,ft=H[B],ut=ft+E[at],st=ft-E[ct],dt=Object(a.a)(x?Object(p.b)(ut,rt):ut,ft,x?Object(p.a)(st,ot):st);H[B]=dt,C[B]=dt-ft}}e.modifiersData[l]=C}},requiresIfExists:["offset"]}},695:function(t,e,n){"use strict";n.d(e,"a",(function(){return u}));var r=n(546),o=n(594),i=n(498),a=n(483);function c(t){return["html","body","#document"].indexOf(Object(i.a)(t))>=0?t.ownerDocument.body:Object(a.b)(t)&&Object(o.a)(t)?t:c(Object(r.a)(t))}var f=n(489);function u(t,e){var n;void 0===e&&(e=[]);var i=c(t),a=i===(null==(n=t.ownerDocument)?void 0:n.body),s=Object(f.a)(i),d=a?[s].concat(s.visualViewport||[],Object(o.a)(i)?i:[]):i,p=e.concat(d);return a?p:p.concat(u(Object(r.a)(d)))}}}]);
//# sourceMappingURL=4.a392fcbd.chunk.js.map