(this["webpackJsonp@coreui/coreui-free-react-admin-template"]=this["webpackJsonp@coreui/coreui-free-react-admin-template"]||[]).push([[42],{482:function(e,t,c){"use strict";c.d(t,"a",(function(){return i}));const n="".concat("http://34.208.193.210/apipagos/api/","grupoautorizacion");function i(e,t,c){let i=n,o="";return null!==e&&(o+="/"+e),null!==t&&(o+="/"+t),i+=o,fetch(i,{method:"GET",headers:{Authorization:"Bearer "+c,Accept:"application/json"}}).then((function(e){return e.json()})).catch((e=>e))}},525:function(e,t,c){"use strict";c.d(t,"a",(function(){return i}));const n="".concat("http://34.208.193.210/apipagos/api/","condiciongrupo");function i(e,t,c,i,o,r,a,s){let l=n,d="";var u={id_condiciongrupo:e,id_condicionautorizacion:t,grupos:c,opcion:i,id_grupoautorizacion:o,activo:r,id_usuario:a};""!==c&&(d+="/"+c),""!==e&&""!==i&&(d+="/"+e+"/"+i),l+=d;const j=JSON.stringify(u);return fetch(l,{method:"POST",body:j,headers:{Authorization:"Bearer "+s,Accept:"application/json","Content-type":"application/json;charset=UTF-8"}}).then((e=>e.json())).then((e=>e)).catch((e=>e))}},881:function(e,t,c){"use strict";c.r(t);var n=c(1),i=c(459),o=c(818),r=c(835),a=(c(465),c(16)),s=c(525),l=c(463),d=c(482),u=c(467),j=(c(460),c(462)),p=c(10);t.default=()=>{const e=Object(a.g)(),t=Object(a.h)(),[c,h]=Object(n.useState)(null),{session:b,clear:O}=Object(i.useSession)("PendrogonIT-Session"),[x,m]=Object(n.useState)(!1),[g,f]=Object(n.useState)(!1),[y,v]=Object(n.useState)([]),[A,S]=Object(n.useState)(""),[E,C]=Object(n.useState)("Error!"),[_,N]=Object(n.useState)("danger"),[z,k]=Object(n.useState)({grupo_autorizacion:""});Object(n.useEffect)((()=>{let e=!0;return Object(d.a)(null,null,b.api_token).then((t=>{e&&v(t.grupos)})),()=>e=!1}),[]);const w=e=>{k({...z,[e.target.name]:e.target.value})},I=async c=>{let n="";c.preventDefault();var i=document.getElementsByName("grupo_autorizacion");for(var o of i)o.checked&&(n+=o.value+"|");const r=await Object(s.a)("",t.id_condicion,n,"1","","",b.id,b.api_token);"OK"===r?e.push("/condiciones"):"Error"===r?(m(!0),C("Error!"),S("Error de conexi\xf3n.")):"Repetidos"===r?(m(!0),C("Aviso!"),N("warning"),S("Los grupos seleccionados ya fueron elegidos para esta condici\xf3n! Intente con otros.")):console.log(r)};async function G(t){if(1==t)f(!1);else if(2==t){let t=0;b&&(t=b.id);"OK"===await Object(l.a)(t,null,null,"2",b.api_token)&&(O(),e.push("/"))}}return b?t.id_condicion?Object(p.jsx)("div",{style:{flexDirection:"row"},children:Object(p.jsxs)(j.i,{children:[Object(p.jsxs)(o.a,{responsive:!0,variant:"primary",show:g,onHide:()=>G(2),centered:!0,children:[Object(p.jsx)(o.a.Header,{closeButton:!0,children:Object(p.jsx)(o.a.Title,{children:"Confirmaci\xf3n"})}),Object(p.jsx)(o.a.Body,{children:A}),Object(p.jsxs)(o.a.Footer,{children:[Object(p.jsx)(j.c,{color:"secondary",onClick:()=>G(2),children:"Cancelar"}),Object(p.jsx)(j.c,{color:"primary",onClick:()=>G(1),children:"Aceptar"})]})]}),Object(p.jsxs)(r.a,{show:x,variant:_,onClose:()=>m(!1),dismissible:!0,children:[Object(p.jsx)(r.a.Heading,{children:E}),Object(p.jsx)("p",{children:A})]}),Object(p.jsx)(j.d,{style:{display:"flex",alignItems:"center"},children:Object(p.jsx)(j.e,{style:{width:"80%"},children:Object(p.jsxs)(j.p,{style:{width:"100%"},children:[Object(p.jsx)("h1",{children:"Asignaci\xf3n de Grupos de Autorizaci\xf3n"}),Object(p.jsx)("p",{className:"text-medium-emphasis",children:"Asigne grupos de autorizaci\xf3n a la condici\xf3n"}),Object(p.jsxs)(j.y,{className:"mb-3",children:[Object(p.jsx)(j.z,{children:Object(p.jsx)(u.b,{})}),Object(p.jsx)(j.r,{type:"text",placeholder:"Nombre",name:"nombre",value:t.descripcion,disabled:!0})]}),y.map(((e,t)=>{if(0==e.eliminado&&1==e.activo)return Object(p.jsx)(j.q,{value:e.id_grupo,type:"checkbox",name:"grupo_autorizacion",label:e.identificador,onChange:w},e.id_grupo)})),Object(p.jsx)("br",{}),Object(p.jsx)(j.c,{color:"primary",onClick:I,children:"Guardar Cambios"})]})})})]})}):(e.push("/condiciones"),Object(p.jsx)("div",{className:"sin-sesion",children:"NO SE CARG\xd3 EL C\xd3DIGO DE CONDICI\xd3N. REGRESE A LA PANTALLA DE PAGOS."})):(e.push("/"),Object(p.jsx)("div",{className:"sin-sesion",children:"SIN SESI\xd3N ACTIVA."}))}}}]);
//# sourceMappingURL=42.0f211d05.chunk.js.map