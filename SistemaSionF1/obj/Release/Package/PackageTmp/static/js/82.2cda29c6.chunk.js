(this["webpackJsonp@coreui/coreui-free-react-admin-template"]=this["webpackJsonp@coreui/coreui-free-react-admin-template"]||[]).push([[82],{535:function(e,t,n){"use strict";n.d(t,"a",(function(){return o}));const a="".concat("http://34.208.193.210/apipagos/api/","cuentas");function o(e,t,n,o,r,c,i,s,l,d){let u=a,p="";var h={id_cuenta:e,numero_cuenta:t,nombre:n,id_empresa:o,id_banco:r,id_moneda:c,codigo_ach:i,opcion:s,id_usuario:l};""!==e&&""!==s&&(p+="/"+e+"/"+s),u+=p;const b=JSON.stringify(h);return fetch(u,{method:"POST",body:b,headers:{Authorization:"Bearer "+d,Accept:"application/json","Content-type":"application/json;charset=UTF-8"}}).then((e=>e.json())).then((e=>e)).catch((e=>e))}},931:function(e,t,n){"use strict";n.r(t);var a=n(1),o=n(818),r=n(16);const c="".concat("http://34.208.193.210/apipagos/api/","cuentas");function i(e,t,n){let a=c,o="";return null!==e&&(o+="/"+e),null!==t&&(o+="/"+t),a+=o,fetch(a,{method:"GET",headers:{Authorization:"Bearer "+n,Accept:"application/json"}}).then((function(e){return e.json()})).catch((e=>e))}var s=n(470),l=n(463),d=n(535),u=(n(465),n(459)),p=n(464),h=(n(460),n(462)),b=n(469),m=n.n(b),j=n(471),f=n.n(j),O=(n(472),n(10));t.default=()=>{const e=Object(r.g)(),[t,n]=Object(a.useState)(null),{session:c,clear:j}=Object(u.useSession)("PendrogonIT-Session"),[x,g]=Object(a.useState)([]),[y,_]=Object(a.useState)([]),[S,C]=Object(a.useState)(!1),[v,T]=Object(a.useState)(""),[k,w]=Object(a.useState)(0),[z,A]=Object(a.useState)(0);function N(e){let t=0;for(let n of y)e===n.objeto&&(t=1);return t}async function R(t){if(1==t)C(!1);else if(2==t){let t=0;c&&(t=c.id);"OK"===await Object(l.a)(t,null,null,"2",c.api_token)&&(j(),e.push("/"))}}Object(a.useEffect)((()=>{let e=!0,t=0;return c&&(t=c.id),i(null,null,c.api_token).then((t=>{e&&(console.log(t),g(t.cuentas))})),Object(s.a)(t,"2","Modulo Cuentas",c.api_token).then((t=>{e&&_(t.detalle)})),()=>e=!1}),[]);const E={headRow:{style:{borderTopStyle:"solid",borderTopWidth:"1px",borderTopColor:b.defaultThemes.default.divider.default}},headCells:{style:{paddingLeft:"8px",paddingRight:"8px",fontSize:"12px","&:not(:last-of-type)":{borderRightStyle:"solid",borderRightWidth:"1px",borderRightColor:b.defaultThemes.default.divider.default}}},cells:{style:{"&:not(:last-of-type)":{borderRightStyle:"solid",borderRightWidth:"1px",borderRightColor:b.defaultThemes.default.divider.default}}}},B=Object(a.useMemo)((()=>[{name:"N\xfamero Cuenta",selector:e=>e.numero_cuenta,center:!0,style:{fontSize:"11px"},sortable:!0,wrap:!0},{name:"Nombre",selector:e=>e.nombre,center:!0,style:{fontSize:"11px"},sortable:!0},{name:"Empresa",selector:e=>e.empresa,center:!0,sortable:!0,style:{fontSize:"11px"}},{name:"Banco",selector:e=>e.banco,center:!0,sortable:!0,style:{fontSize:"11px"},wrap:!0},{name:"Moneda",selector:e=>e.moneda,center:!0,sortable:!0,style:{fontSize:"11px"},wrap:!0},{name:"C\xf3digo ACH",selector:e=>e.codigo_ach,center:!0,sortable:!0,style:{fontSize:"11px"},wrap:!0},{name:"Acciones",cell:function(t){let n=!1;return 0==N("Modulo Cuentas")&&(n=!0),Object(O.jsxs)("div",{children:[Object(O.jsx)(h.c,{color:"primary",size:"sm",title:"Editar Cuenta",disabled:n,onClick:()=>e.push({pathname:"/cuentas/editar",id_cuenta:t.id_cuenta,numero_cuenta:t.numero_cuenta,nombre:t.nombre,id_empresa:t.id_empresa,id_banco:t.id_banco,id_moneda:t.id_moneda,codigo_ach:t.codigo_ach}),children:Object(O.jsx)(p.m,{})})," ",Object(O.jsx)(h.c,{color:"danger",size:"sm",title:"Eliminar Cuenta",disabled:n,onClick:()=>function(e,t,n){w(e),A(t),T("Est\xe1 seguro de eliminar la cuenta n\xfamero "+n+"?"),C(!0)}(t.id_cuenta,1,t.numero_cuenta),children:Object(O.jsx)(p.s,{})})]})},center:!0,width:"200px"}])),M={columns:B,data:x,filterPlaceholder:"Filtrar datos",export:!1,print:!1};if(c){let t=!1;return 0==N("Modulo Cuentas")&&(t=!0),Object(O.jsxs)(O.Fragment,{children:[Object(O.jsxs)(o.a,{responsive:!0,variant:"primary",show:S,onHide:()=>R(z),centered:!0,children:[Object(O.jsx)(o.a.Header,{closeButton:!0,children:Object(O.jsx)(o.a.Title,{children:"Confirmaci\xf3n"})}),Object(O.jsx)(o.a.Body,{children:v}),Object(O.jsxs)(o.a.Footer,{children:[Object(O.jsx)(h.c,{color:"secondary",onClick:()=>R(z),children:"Cancelar"}),Object(O.jsx)(h.c,{color:"primary",onClick:()=>async function(e,t){1==t?"OK"===await Object(d.a)(e,"","","","","","","2",c.id,c.api_token)&&await i(null,null,c.api_token).then((e=>{g(e.cuentas)})):2==t&&C(!1)}(k,z).then((()=>R(1))),children:"Aceptar"})]})]}),Object(O.jsx)("div",{className:"float-right",style:{marginBottom:"10px"},children:Object(O.jsx)(h.c,{color:"primary",size:"sm",disabled:t,onClick:()=>e.push("/cuentas/nueva"),children:"Crear Nueva"})}),Object(O.jsx)(f.a,{...M,children:Object(O.jsx)(m.a,{columns:B,noDataComponent:"No hay usuarios que mostrar",data:x,customStyles:E,pagination:!0,paginationPerPage:25,responsive:!0,persistTableHead:!0,striped:!0,dense:!0})})]})}return e.push("/"),Object(O.jsx)("div",{className:"sin-sesion",children:"SIN SESI\xd3N ACTIVA."})}}}]);
//# sourceMappingURL=82.2cda29c6.chunk.js.map