(this["webpackJsonp@coreui/coreui-free-react-admin-template"]=this["webpackJsonp@coreui/coreui-free-react-admin-template"]||[]).push([[35],{686:function(e,t,n){var r;e.exports=(r=n(1),(()=>{"use strict";var e={418:e=>{var t=Object.getOwnPropertySymbols,n=Object.prototype.hasOwnProperty,r=Object.prototype.propertyIsEnumerable;function o(e){if(null==e)throw new TypeError("Object.assign cannot be called with null or undefined");return Object(e)}e.exports=function(){try{if(!Object.assign)return!1;var e=new String("abc");if(e[5]="de","5"===Object.getOwnPropertyNames(e)[0])return!1;for(var t={},n=0;n<10;n++)t["_"+String.fromCharCode(n)]=n;if("0123456789"!==Object.getOwnPropertyNames(t).map((function(e){return t[e]})).join(""))return!1;var r={};return"abcdefghijklmnopqrst".split("").forEach((function(e){r[e]=e})),"abcdefghijklmnopqrst"===Object.keys(Object.assign({},r)).join("")}catch(e){return!1}}()?Object.assign:function(e,i){for(var a,h,s=o(e),d=1;d<arguments.length;d++){for(var c in a=Object(arguments[d]))n.call(a,c)&&(s[c]=a[c]);if(t){h=t(a);for(var l=0;l<h.length;l++)r.call(a,h[l])&&(s[h[l]]=a[h[l]])}}return s}},251:(e,t,n)=>{n(418);var r=n(899),o=60103;if(t.Fragment=60107,"function"==typeof Symbol&&Symbol.for){var i=Symbol.for;o=i("react.element"),t.Fragment=i("react.fragment")}var a=r.__SECRET_INTERNALS_DO_NOT_USE_OR_YOU_WILL_BE_FIRED.ReactCurrentOwner,h=Object.prototype.hasOwnProperty,s={key:!0,ref:!0,__self:!0,__source:!0};function d(e,t,n){var r,i={},d=null,c=null;for(r in void 0!==n&&(d=""+n),void 0!==t.key&&(d=""+t.key),void 0!==t.ref&&(c=t.ref),t)h.call(t,r)&&!s.hasOwnProperty(r)&&(i[r]=t[r]);if(e&&e.defaultProps)for(r in t=e.defaultProps)void 0===i[r]&&(i[r]=t[r]);return{$$typeof:o,type:e,key:d,ref:c,props:i,_owner:a.current}}t.jsx=d,t.jsxs=d},893:(e,t,n)=>{e.exports=n(251)},899:e=>{e.exports=r}},t={};function n(r){var o=t[r];if(void 0!==o)return o.exports;var i=t[r]={exports:{}};return e[r](i,i.exports,n),i.exports}n.d=(e,t)=>{for(var r in t)n.o(t,r)&&!n.o(e,r)&&Object.defineProperty(e,r,{enumerable:!0,get:t[r]})},n.o=(e,t)=>Object.prototype.hasOwnProperty.call(e,t),n.r=e=>{"undefined"!=typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})};var o={};return(()=>{n.r(o),n.d(o,{Component:()=>g,areCropsEqual:()=>h,centerCrop:()=>d,clamp:()=>a,containCrop:()=>p,convertToPercentCrop:()=>c,convertToPixelCrop:()=>l,default:()=>g,defaultCrop:()=>i,makeAspectCrop:()=>s});var e=n(893),t=n(899);function r(e){var t,n,o="";if("string"==typeof e||"number"==typeof e)o+=e;else if("object"==typeof e)if(Array.isArray(e))for(t=0;t<e.length;t++)e[t]&&(n=r(e[t]))&&(o&&(o+=" "),o+=n);else for(t in e)e[t]&&(o&&(o+=" "),o+=t);return o}const i={x:0,y:0,width:0,height:0,unit:"px"};function a(e,t,n){return Math.min(Math.max(e,t),n)}function h(e,t){return e.width===t.width&&e.height===t.height&&e.x===t.x&&e.y===t.y&&e.unit===t.unit}function s(e,t,n,r){const o=l(e,n,r);return e.width&&(o.height=o.width/t),e.height&&(o.width=o.height*t),o.y+o.height>r&&(o.height=r-o.y,o.width=o.height*t),o.x+o.width>n&&(o.width=n-o.x,o.height=o.width/t),"%"===e.unit?c(o,n,r):o}function d(e,t,n){const r=l(e,t,n);return r.x=(t-r.width)/2,r.y=(n-r.height)/2,"%"===e.unit?c(r,t,n):r}function c(e,t,n){return"%"===e.unit?{...i,...e,unit:"%"}:{unit:"%",x:e.x?e.x/t*100:0,y:e.y?e.y/n*100:0,width:e.width?e.width/t*100:0,height:e.height?e.height/n*100:0}}function l(e,t,n){return e.unit?"px"===e.unit?{...i,...e,unit:"px"}:{unit:"px",x:e.x?e.x*t/100:0,y:e.y?e.y*n/100:0,width:e.width?e.width*t/100:0,height:e.height?e.height*n/100:0}:{...i,...e,unit:"px"}}function p(e,t,n,r,o,i=0,a=0,h=r,s=o){const d={...e};let c=i,l=a,p=h,w=s;t&&(t>1?(c=a*t,p=h*t):(l=i/t,w=s/t)),d.y<0&&(d.height=Math.max(d.height+d.y,l),d.y=0),d.x<0&&(d.width=Math.max(d.width+d.x,c),d.x=0);const g=r-(d.x+d.width);g<0&&(d.x=Math.min(d.x,r-c),d.width+=g);const u=o-(d.y+d.height);if(u<0&&(d.y=Math.min(d.y,o-l),d.height+=u),d.width<c&&("sw"!==n&&"nw"!=n||(d.x-=c-d.width),d.width=c),d.height<l&&("nw"!==n&&"ne"!=n||(d.y-=l-d.height),d.height=l),d.width>p&&("sw"!==n&&"nw"!=n||(d.x-=p-d.width),d.width=p),d.height>w&&("nw"!==n&&"ne"!=n||(d.y-=w-d.height),d.height=w),t){const e=d.width/d.height;if(e<t){const e=d.width/t;"nw"!==n&&"ne"!=n||(d.y-=e-d.height),d.height=e}else if(e>t){const e=d.height*t;"sw"!==n&&"nw"!=n||(d.x-=e-d.width),d.width=e}}return d}const w={capture:!0,passive:!1};class g extends t.PureComponent{constructor(){super(...arguments),this.document=document,this.keysDown=new Set,this.docMoveBound=!1,this.mouseDownOnCrop=!1,this.dragStarted=!1,this.evData={startClientX:0,startClientY:0,startCropX:0,startCropY:0,clientX:0,clientY:0,isResize:!0},this.componentRef=(0,t.createRef)(),this.mediaRef=(0,t.createRef)(),this.initChangeCalled=!1,this.state={cropIsActive:!1,newCropIsBeingDrawn:!1},this.onCropPointerDown=e=>{const{crop:t,disabled:n}=this.props,r=this.getBox();if(!t)return;const o=l(t,r.width,r.height);if(n)return;e.cancelable&&e.preventDefault(),this.bindDocMove(),this.componentRef.current.focus({preventScroll:!0});const i=e.target.dataset.ord,a=Boolean(i);let h=e.clientX,s=e.clientY,d=o.x,c=o.y;i&&("ne"===i||"e"==i?(d=o.x,c=o.y+o.height):"se"===i||"s"===i?(d=o.x,c=o.y):"sw"===i||"w"==i?(d=o.x+o.width,c=o.y):"nw"!==i&&"n"!=i||(d=o.x+o.width,c=o.y+o.height),h=d+r.x,s=c+r.y),this.evData={startClientX:h,startClientY:s,startCropX:d,startCropY:c,clientX:e.clientX,clientY:e.clientY,isResize:a,ord:i},this.mouseDownOnCrop=!0,this.setState({cropIsActive:!0})},this.onComponentPointerDown=e=>{const{crop:t,disabled:n,locked:r,keepSelection:o,onChange:i}=this.props,a=this.getBox();if(n||r||o&&t)return;e.cancelable&&e.preventDefault(),this.bindDocMove(),this.componentRef.current.focus({preventScroll:!0});const h=e.clientX-a.x,s=e.clientY-a.y,d={unit:"px",x:h,y:s,width:0,height:0};this.evData={startClientX:e.clientX,startClientY:e.clientY,startCropX:h,startCropY:s,clientX:e.clientX,clientY:e.clientY,isResize:!0},this.mouseDownOnCrop=!0,i(l(d,a.width,a.height),c(d,a.width,a.height)),this.setState({cropIsActive:!0,newCropIsBeingDrawn:!0})},this.onDocPointerMove=e=>{const{crop:t,disabled:n,onChange:r,onDragStart:o}=this.props,i=this.getBox();if(n||!t||!this.mouseDownOnCrop)return;e.cancelable&&e.preventDefault(),this.dragStarted||(this.dragStarted=!0,o&&o(e));const{evData:a}=this;let s;a.clientX=e.clientX,a.clientY=e.clientY,s=a.isResize?this.resizeCrop():this.dragCrop(),h(t,s)||r(l(s,i.width,i.height),c(s,i.width,i.height))},this.onComponentKeyDown=e=>{const{crop:t,disabled:n,onChange:r,onComplete:o}=this.props,i=this.getBox();if(n)return;this.keysDown.add(e.key);let h=!1;if(!t)return;const s=this.makePixelCrop(),d=(navigator.platform.match("Mac")?e.metaKey:e.ctrlKey)?g.nudgeStepLarge:e.shiftKey?g.nudgeStepMedium:g.nudgeStep;if(this.keysDown.has("ArrowLeft")&&(s.x-=d,h=!0),this.keysDown.has("ArrowRight")&&(s.x+=d,h=!0),this.keysDown.has("ArrowUp")&&(s.y-=d,h=!0),this.keysDown.has("ArrowDown")&&(s.y+=d,h=!0),h){e.cancelable&&e.preventDefault(),s.x=a(s.x,0,i.width-s.width),s.y=a(s.y,0,i.height-s.height);const t=l(s,i.width,i.height),n=c(s,i.width,i.height);r(t,n),o&&o(t,n)}},this.onHandlerKeyDown=(e,t)=>{const{aspect:n=0,crop:r,disabled:o,minWidth:i=0,minHeight:a=0,maxWidth:s,maxHeight:d,onChange:w,onComplete:u}=this.props,y=this.getBox();if(o||!r)return;if("ArrowUp"!==e.key&&"ArrowDown"!==e.key&&"ArrowLeft"!==e.key&&"ArrowRight"!==e.key)return;e.stopPropagation(),e.preventDefault();const x=l(r,y.width,y.height),m=(navigator.platform.match("Mac")?e.metaKey:e.ctrlKey)?g.nudgeStepLarge:e.shiftKey?g.nudgeStepMedium:g.nudgeStep;"ArrowLeft"===e.key?"nw"===t?(x.x-=m,x.y-=m,x.width+=m,x.height+=m):"w"===t?(x.x-=m,x.width+=m):"sw"===t?(x.x-=m,x.width+=m,x.height+=m):"ne"===t?(x.y+=m,x.width-=m,x.height-=m):"e"===t?x.width-=m:"se"===t&&(x.width-=m,x.height-=m):"ArrowRight"===e.key&&("nw"===t?(x.x+=m,x.y+=m,x.width-=m,x.height-=m):"w"===t?(x.x+=m,x.width-=m):"sw"===t?(x.x+=m,x.width-=m,x.height-=m):"ne"===t?(x.y-=m,x.width+=m,x.height+=m):"e"===t?x.width+=m:"se"===t&&(x.width+=m,x.height+=m)),"ArrowUp"===e.key?"nw"===t?(x.x-=m,x.y-=m,x.width+=m,x.height+=m):"n"===t?(x.y-=m,x.height+=m):"ne"===t?(x.y-=m,x.width+=m,x.height+=m):"sw"===t?(x.x+=m,x.width-=m,x.height-=m):"s"===t?x.height-=m:"se"===t&&(x.width-=m,x.height-=m):"ArrowDown"===e.key&&("nw"===t?(x.x+=m,x.y+=m,x.width-=m,x.height-=m):"n"===t?(x.y+=m,x.height-=m):"ne"===t?(x.y+=m,x.width-=m,x.height-=m):"sw"===t?(x.x-=m,x.width+=m,x.height+=m):"s"===t?x.height+=m:"se"===t&&(x.width+=m,x.height+=m));const f=p(x,n,t,y.width,y.height,i,a,s,d);if(!h(r,f)){const e=c(f,y.width,y.height);w(f,e),u&&u(f,e)}},this.onComponentKeyUp=e=>{this.keysDown.delete(e.key)},this.onDocPointerDone=e=>{const{crop:t,disabled:n,onComplete:r,onDragEnd:o}=this.props,i=this.getBox();this.unbindDocMove(),!n&&t&&this.mouseDownOnCrop&&(this.mouseDownOnCrop=!1,this.dragStarted=!1,o&&o(e),r&&r(l(t,i.width,i.height),c(t,i.width,i.height)),this.setState({cropIsActive:!1,newCropIsBeingDrawn:!1}))}}getBox(){const e=this.mediaRef.current;if(!e)return{x:0,y:0,width:0,height:0};const{x:t,y:n,width:r,height:o}=e.getBoundingClientRect();return{x:t,y:n,width:r,height:o}}componentDidUpdate(e){const{crop:t,onComplete:n}=this.props;if(n&&!e.crop&&t){const{width:e,height:r}=this.getBox();e&&r&&n(l(t,e,r),c(t,e,r))}}componentWillUnmount(){this.resizeObserver&&this.resizeObserver.disconnect()}bindDocMove(){this.docMoveBound||(this.document.addEventListener("pointermove",this.onDocPointerMove,w),this.document.addEventListener("pointerup",this.onDocPointerDone,w),this.document.addEventListener("pointercancel",this.onDocPointerDone,w),this.docMoveBound=!0)}unbindDocMove(){this.docMoveBound&&(this.document.removeEventListener("pointermove",this.onDocPointerMove,w),this.document.removeEventListener("pointerup",this.onDocPointerDone,w),this.document.removeEventListener("pointercancel",this.onDocPointerDone,w),this.docMoveBound=!1)}getCropStyle(){const{crop:e}=this.props;if(e)return{top:"".concat(e.y).concat(e.unit),left:"".concat(e.x).concat(e.unit),width:"".concat(e.width).concat(e.unit),height:"".concat(e.height).concat(e.unit)}}dragCrop(){const{evData:e}=this,t=this.getBox(),n=this.makePixelCrop(),r=e.clientX-e.startClientX,o=e.clientY-e.startClientY;return n.x=a(e.startCropX+r,0,t.width-n.width),n.y=a(e.startCropY+o,0,t.height-n.height),n}getPointRegion(e){const{evData:t}=this,n=t.clientX-e.x,r=t.clientY-e.y<t.startCropY;return n<t.startCropX?r?"nw":"sw":r?"ne":"se"}resizeCrop(){const{evData:e}=this,t=this.getBox(),{aspect:n=0,minWidth:r=0,minHeight:o=0,maxWidth:i,maxHeight:a}=this.props,h=this.getPointRegion(t),s=this.makePixelCrop(),d=e.ord?e.ord:h,c=e.clientX-e.startClientX,l=e.clientY-e.startClientY,w={unit:"px",x:0,y:0,width:0,height:0};"ne"===h?(w.x=e.startCropX,w.width=c,n?(w.height=w.width/n,w.y=e.startCropY-w.height):(w.height=Math.abs(l),w.y=e.startCropY-w.height)):"se"===h?(w.x=e.startCropX,w.y=e.startCropY,w.width=c,w.height=n?w.width/n:l):"sw"===h?(w.x=e.startCropX+c,w.y=e.startCropY,w.width=Math.abs(c),w.height=n?w.width/n:l):"nw"===h&&(w.x=e.startCropX+c,w.width=Math.abs(c),n?(w.height=w.width/n,w.y=e.startCropY-w.height):(w.height=Math.abs(l),w.y=e.startCropY+l));const u=p(w,n,h,t.width,t.height,r,o,i,a);return n||g.xyOrds.indexOf(d)>-1?(s.x=u.x,s.y=u.y,s.width=u.width,s.height=u.height):g.xOrds.indexOf(d)>-1?(s.x=u.x,s.width=u.width):g.yOrds.indexOf(d)>-1&&(s.y=u.y,s.height=u.height),s}createCropSelection(){const{ariaLabels:t=g.defaultProps.ariaLabels,disabled:n,locked:r,renderSelectionAddon:o,ruleOfThirds:i,crop:a}=this.props,h=this.getCropStyle();if(a)return(0,e.jsxs)("div",{style:h,className:"ReactCrop__crop-selection",onPointerDown:this.onCropPointerDown,"aria-label":t.cropArea,tabIndex:0,onKeyDown:this.onComponentKeyDown,onKeyUp:this.onComponentKeyUp,children:[!n&&!r&&(0,e.jsxs)("div",{className:"ReactCrop__drag-elements",children:[(0,e.jsx)("div",{className:"ReactCrop__drag-bar ord-n","data-ord":"n"}),(0,e.jsx)("div",{className:"ReactCrop__drag-bar ord-e","data-ord":"e"}),(0,e.jsx)("div",{className:"ReactCrop__drag-bar ord-s","data-ord":"s"}),(0,e.jsx)("div",{className:"ReactCrop__drag-bar ord-w","data-ord":"w"}),(0,e.jsx)("div",{className:"ReactCrop__drag-handle ord-nw","data-ord":"nw",tabIndex:0,"aria-label":t.nwDragHandle,onKeyDown:e=>this.onHandlerKeyDown(e,"nw")}),(0,e.jsx)("div",{className:"ReactCrop__drag-handle ord-n","data-ord":"n",tabIndex:0,"aria-label":t.nDragHandle,onKeyDown:e=>this.onHandlerKeyDown(e,"n")}),(0,e.jsx)("div",{className:"ReactCrop__drag-handle ord-ne","data-ord":"ne",tabIndex:0,"aria-label":t.neDragHandle,onKeyDown:e=>this.onHandlerKeyDown(e,"ne")}),(0,e.jsx)("div",{className:"ReactCrop__drag-handle ord-e","data-ord":"e",tabIndex:0,"aria-label":t.eDragHandle,onKeyDown:e=>this.onHandlerKeyDown(e,"e")}),(0,e.jsx)("div",{className:"ReactCrop__drag-handle ord-se","data-ord":"se",tabIndex:0,"aria-label":t.seDragHandle,onKeyDown:e=>this.onHandlerKeyDown(e,"se")}),(0,e.jsx)("div",{className:"ReactCrop__drag-handle ord-s","data-ord":"s",tabIndex:0,"aria-label":t.sDragHandle,onKeyDown:e=>this.onHandlerKeyDown(e,"s")}),(0,e.jsx)("div",{className:"ReactCrop__drag-handle ord-sw","data-ord":"sw",tabIndex:0,"aria-label":t.swDragHandle,onKeyDown:e=>this.onHandlerKeyDown(e,"sw")}),(0,e.jsx)("div",{className:"ReactCrop__drag-handle ord-w","data-ord":"w",tabIndex:0,"aria-label":t.wDragHandle,onKeyDown:e=>this.onHandlerKeyDown(e,"w")})]}),o&&(0,e.jsx)("div",{className:"ReactCrop__selection-addon",onMouseDown:e=>e.stopPropagation(),children:o(this.state)}),i&&(0,e.jsxs)(e.Fragment,{children:[(0,e.jsx)("div",{className:"ReactCrop__rule-of-thirds-hz"}),(0,e.jsx)("div",{className:"ReactCrop__rule-of-thirds-vt"})]})]})}makePixelCrop(){const e={...i,...this.props.crop||{}},t=this.getBox();return l(e,t.width,t.height)}render(){const{aspect:t,children:n,circularCrop:o,className:i,crop:a,disabled:h,locked:s,style:d,ruleOfThirds:c}=this.props,{cropIsActive:l,newCropIsBeingDrawn:p}=this.state,w=a?this.createCropSelection():null,g=function(){for(var e,t,n=0,o="";n<arguments.length;)(e=arguments[n++])&&(t=r(e))&&(o&&(o+=" "),o+=t);return o}("ReactCrop",i,{"ReactCrop--active":l,"ReactCrop--disabled":h,"ReactCrop--locked":s,"ReactCrop--new-crop":p,"ReactCrop--fixed-aspect":a&&t,"ReactCrop--circular-crop":a&&o,"ReactCrop--rule-of-thirds":a&&c,"ReactCrop--invisible-crop":!this.dragStarted&&a&&!a.width&&!a.height});return(0,e.jsxs)("div",{ref:this.componentRef,className:g,style:d,children:[(0,e.jsx)("div",{ref:this.mediaRef,className:"ReactCrop__child-wrapper",onPointerDown:this.onComponentPointerDown,children:n}),w]})}}g.xOrds=["e","w"],g.yOrds=["n","s"],g.xyOrds=["nw","ne","se","sw"],g.nudgeStep=1,g.nudgeStepMedium=10,g.nudgeStepLarge=100,g.defaultProps={ariaLabels:{cropArea:"Use the arrow keys to move the crop selection area",nwDragHandle:"Use the arrow keys to move the north west drag handle to change the crop selection area",nDragHandle:"Use the up and down arrow keys to move the north drag handle to change the crop selection area",neDragHandle:"Use the arrow keys to move the north east drag handle to change the crop selection area",eDragHandle:"Use the up and down arrow keys to move the east drag handle to change the crop selection area",seDragHandle:"Use the arrow keys to move the south east drag handle to change the crop selection area",sDragHandle:"Use the up and down arrow keys to move the south drag handle to change the crop selection area",swDragHandle:"Use the arrow keys to move the south west drag handle to change the crop selection area",wDragHandle:"Use the up and down arrow keys to move the west drag handle to change the crop selection area"}}})(),o})())},806:function(e,t,n){},899:function(e,t,n){"use strict";var r=n(8),o=n(21),i=n(474),a=n.n(i),h=n(1),s=n.n(h),d=n(475),c=["bsPrefix","variant","animation","size","children","as","className"],l=s.a.forwardRef((function(e,t){var n=e.bsPrefix,i=e.variant,h=e.animation,l=e.size,p=e.children,w=e.as,g=void 0===w?"div":w,u=e.className,y=Object(o.a)(e,c),x=(n=Object(d.a)(n,"spinner"))+"-"+h;return s.a.createElement(g,Object(r.a)({ref:t},y,{className:a()(u,x,l&&x+"-"+l,i&&"text-"+i)}),p)}));l.displayName="Spinner",t.a=l}}]);
//# sourceMappingURL=35.fb426585.chunk.js.map