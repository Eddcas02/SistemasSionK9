(this["webpackJsonp@coreui/coreui-free-react-admin-template"]=this["webpackJsonp@coreui/coreui-free-react-admin-template"]||[]).push([[100],{584:function(e,t,a){"use strict";a.d(t,"a",(function(){return i}));const o="".concat("http://34.208.193.210/apipagos/api/","usuarioautorizacion");function i(e,t,a,i,n,r,c,s,l){let u=o,d="";var p={id_usuarioautorizacion:e,id_usuarioaprobador:t,id_usuariotemporal:a,fecha_inicio:i,fecha_final:n,opcion:r,activo:c,id_usuario:s};""!==e&&""!==r&&(d+="/"+e+"/"+r),u+=d;const h=JSON.stringify(p);return fetch(u,{method:"POST",body:h,headers:{Authorization:"Bearer "+l,Accept:"application/json","Content-type":"application/json;charset=UTF-8"}}).then((e=>e.json())).then((e=>e)).catch((e=>e))}},927:function(e,t,a){"use strict";a.r(t);var o=a(1),i=a(818),n=(a(465),a(470));const r="".concat("http://34.208.193.210/apipagos/api/","usuarioautorizacion");function c(e,t,a){let o=r,i="";return null!==e&&(i+="/"+e),null!==t&&(i+="/"+t),o+=i,fetch(o,{method:"GET",headers:{Authorization:"Bearer "+a,Accept:"application/json"}}).then((function(e){return e.json()})).catch((e=>{"Failed to fetch"==e.message&&alert("Error de conexi\xf3n. Revise si est\xe1 conectado a Internet.")}))}var s=a(584),l=a(463),u=a(459),d=a(16),p=a(501),h=(a(460),a(462)),f=a(469),j=a.n(f),b=a(471),m=a.n(b),O=(a(472),a(10));t.default=()=>{const e=Object(d.g)(),[t,a]=Object(o.useState)(null),{session:r,clear:b}=Object(u.useSession)("PendrogonIT-Session"),[x,y]=Object(o.useState)([]),[S,g]=Object(o.useState)([]),[v,z]=Object(o.useState)(!1),[C,_]=Object(o.useState)(0),[T,k]=Object(o.useState)(0),[A,w]=Object(o.useState)(0),[R,E]=Object(o.useState)("");function F(e){let t=0;for(let a of S)e===a.objeto&&(t=1);return t}async function N(t){if(1==t)z(!1);else if(2==t){let t=0;r&&(t=r.id);"OK"===await Object(l.a)(t,null,null,"2",r.api_token)&&(b(),e.push("/"))}}Object(o.useEffect)((()=>{let e=!0,t=0;return r&&(t=r.id),c(t,null,r.api_token).then((t=>{e&&y(t.autorizacion)})),Object(n.a)(t,"2","Modulo Autorizacion",r.api_token).then((t=>{e&&g(t.detalle)})),()=>e=!1}),[]);const I={headRow:{style:{borderTopStyle:"solid",borderTopWidth:"1px",borderTopColor:f.defaultThemes.default.divider.default}},headCells:{style:{paddingLeft:"8px",paddingRight:"8px",fontSize:"12px","&:not(:last-of-type)":{borderRightStyle:"solid",borderRightWidth:"1px",borderRightColor:f.defaultThemes.default.divider.default}}},cells:{style:{"&:not(:last-of-type)":{borderRightStyle:"solid",borderRightWidth:"1px",borderRightColor:f.defaultThemes.default.divider.default}}}},B=Object(o.useMemo)((()=>[{name:"Usuario Temporal",selector:e=>e.usuariotemporal,center:!0,style:{fontSize:"11px"},sortable:!0,wrap:!0},{name:"Fecha inico",selector:e=>e.fecha_inicio,center:!0,style:{fontSize:"11px"},sortable:!0},{name:"Fecha final",selector:e=>e.fecha_final,center:!0,sortable:!0,style:{fontSize:"11px"}},{name:"Estado",cell:function(e){let t="Inactivo";return 1==e.activo&&(t="Activo"),t},center:!0,sortable:!0,style:{fontSize:"11px"},wrap:!0},{name:"Acciones",cell:function(e){let t=!1;return F("Modulo Usuarios")||(t=!0),Object(O.jsx)("div",{children:Object(O.jsx)(h.c,{color:"info",size:"sm",title:"Cambiar Estado",onClick:()=>function(e,t,a){_(e),k(a),w(t),z(!0),E("Est\xe1 seguro de cambiar el estado de la autorizaci\xf3n de encargado temporal?")}(e.id_usuarioautorizacion,1,e.activo),children:Object(O.jsx)(p.a,{})})})},center:!0,width:"200px"}])),P={columns:B,data:x,filterPlaceholder:"Filtrar datos",export:!1,print:!1};if(r){let t=!1;return 0==F("Modulo Autorizacion")&&(t=!0),Object(O.jsxs)(O.Fragment,{children:[Object(O.jsxs)(i.a,{responsive:!0,variant:"primary",show:v,onHide:()=>N(A),centered:!0,children:[Object(O.jsx)(i.a.Header,{closeButton:!0,children:Object(O.jsx)(i.a.Title,{children:"Confirmaci\xf3n"})}),Object(O.jsx)(i.a.Body,{children:R}),Object(O.jsxs)(i.a.Footer,{children:[Object(O.jsx)(h.c,{color:"secondary",onClick:()=>N(A),children:"Cancelar"}),Object(O.jsx)(h.c,{color:"primary",onClick:()=>async function(e,t,a){if(1==t){let o;o=0==a?"1":"0","OK"===await Object(s.a)(e,"","","","",t,o,r.id,r.api_token)&&await c(r.id,null,r.api_token).then((e=>{y(e.autorizacion)}))}else 2==t&&z(!1)}(C,A,T).then((()=>N(1))),children:"Aceptar"})]})]}),Object(O.jsx)("div",{className:"float-right",style:{marginBottom:"10px"},children:Object(O.jsx)(h.c,{color:"primary",size:"sm",onClick:()=>e.push({pathname:"/autorizacion/nueva",id_usuario:r.id}),children:"Crear Nueva"})}),Object(O.jsx)(m.a,{...P,children:Object(O.jsx)(j.a,{columns:B,noDataComponent:"No hay usuarios que mostrar",data:x,customStyles:I,pagination:!0,paginationPerPage:25,responsive:!0,persistTableHead:!0,striped:!0,dense:!0})})]})}return e.push("/"),Object(O.jsx)("div",{className:"sin-sesion",children:"SIN SESI\xd3N ACTIVA."})}}}]);
//# sourceMappingURL=100.8428fa71.chunk.js.map