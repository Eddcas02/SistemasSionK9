(this["webpackJsonp@coreui/coreui-free-react-admin-template"]=this["webpackJsonp@coreui/coreui-free-react-admin-template"]||[]).push([[60],{573:function(e,t,c){"use strict";c.d(t,"a",(function(){return s}));const r="".concat("http://34.208.193.210/apipagos/api/","restriccionempresa");function s(e,t,c,s,n,a){let i=r,o="";var l={id_restriccionempresa:e,opcion:s,id_usuario:n,empresa_codigo:t,empresa_nombre:c};""!==e&&""!==s&&(o+="/"+e+"/"+s),i+=o;const p=JSON.stringify(l);return fetch(i,{method:"POST",body:p,headers:{Authorization:"Bearer "+a,Accept:"application/json","Content-type":"application/json;charset=UTF-8"}}).then((e=>e.json())).then((e=>e)).catch((e=>e))}},574:function(e,t,c){"use strict";c.d(t,"b",(function(){return s})),c.d(t,"a",(function(){return a}));const r="".concat("http://34.208.193.210/apipagos/api/","restriccionempresa");function s(e,t){let c=r,s="";return null!==e&&(s+="/"+e),c+=s,fetch(c,{method:"GET",headers:{Authorization:"Bearer "+t,Accept:"application/json"}}).then((function(e){return e.json()})).catch((e=>e))}const n="".concat("http://34.208.193.210/apipagos/api/","empresasdisponibles");function a(e){return fetch(n,{method:"GET",headers:{Authorization:"Bearer "+e,Accept:"application/json"}}).then((function(e){return e.json()})).catch((e=>e))}},861:function(e,t,c){"use strict";c.r(t);var r=c(1),s=c(459),n=c(818),a=c(719),i=c(835),o=(c(465),c(16)),l=c(467),p=c(573),j=c(463),d=c(574),h=(c(460),c(462)),u=c(464),m=c(10);t.default=()=>{const e=Object(o.g)(),[t,c]=Object(r.useState)(null),{session:b,clear:O}=Object(s.useSession)("PendrogonIT-Session"),[x,f]=Object(r.useState)([]),[g,y]=Object(r.useState)(!1),[_,S]=Object(r.useState)(!1),[v,A]=Object(r.useState)(""),[k,C]=Object(r.useState)("danger"),[w,N]=Object(r.useState)("Error!"),[B,E]=Object(r.useState)({empresa_codigo:"",empresa_nombre:""});Object(r.useEffect)((()=>{let e=!0;return Object(d.a)(b.api_token).then((t=>{e&&f(t.restriccion_empresa)})),()=>e=!1}),[]);const T=e=>{if("empresa"==e.target.name){let t=e.target.value.split("|");E({...B,empresa_codigo:t[0],empresa_nombre:t[1]})}else E({...B,[e.target.name]:e.target.value})},z=async t=>{if(""!==B.descripcion){t.preventDefault();"OK"===await Object(p.a)("",B.empresa_codigo,B.empresa_nombre,"",b.id,b.api_token)&&e.push("/restriccionempresa")}else y(!0),N("Error!"),C("danger"),A("No has ingresado ninguna descripci\xf3n.")};async function I(t){if(1==t)S(!1);else if(2==t){let t=0;b&&(t=b.id);"OK"===await Object(j.a)(t,null,null,"2",b.api_token)&&(O(),e.push("/"))}}return b?Object(m.jsx)("div",{style:{flexDirection:"row"},children:Object(m.jsxs)(h.i,{children:[Object(m.jsxs)(n.a,{responsive:!0,variant:"primary",show:_,onHide:()=>I(2),centered:!0,children:[Object(m.jsx)(n.a.Header,{closeButton:!0,children:Object(m.jsx)(n.a.Title,{children:"Confirmaci\xf3n"})}),Object(m.jsx)(n.a.Body,{children:v}),Object(m.jsxs)(n.a.Footer,{children:[Object(m.jsx)(h.c,{color:"secondary",onClick:()=>I(2),children:"Cancelar"}),Object(m.jsx)(h.c,{color:"primary",onClick:()=>I(1),children:"Aceptar"})]})]}),Object(m.jsx)("div",{className:"float-left",style:{marginBottom:"10px"},children:Object(m.jsxs)(a.a,{variant:"primary",size:"sm",onClick:()=>e.goBack(),children:[Object(m.jsx)(u.c,{}),"\xa0\xa0Regresar"]})}),Object(m.jsx)("br",{}),Object(m.jsx)("br",{}),Object(m.jsxs)(i.a,{show:g,variant:k,onClose:()=>y(!1),dismissible:!0,children:[Object(m.jsx)(i.a.Heading,{children:w}),Object(m.jsx)("p",{children:v})]}),Object(m.jsx)(h.d,{style:{display:"flex",alignItems:"center"},children:Object(m.jsx)(h.e,{style:{width:"80%"},children:Object(m.jsxs)(h.p,{style:{width:"100%"},children:[Object(m.jsx)("h1",{children:"Nueva restricci\xf3n de empresa"}),Object(m.jsx)("p",{className:"text-medium-emphasis",children:"Agrega una nueva empresa a la lista de restricci\xf3n"}),Object(m.jsxs)(h.y,{className:"mb-3",children:[Object(m.jsx)(h.z,{children:Object(m.jsx)(l.q,{})}),Object(m.jsxs)(h.t,{placeholder:"Empresa",name:"empresa",onChange:T,children:[Object(m.jsx)("option",{children:"Seleccione una empresa"}),x.map(((e,t)=>Object(m.jsx)("option",{value:e.empresa_codigo+"|"+e.empresa_nombre,children:e.empresa_nombre},e.enmpresa_codigo)))]})]}),Object(m.jsx)(h.c,{color:"primary",onClick:z,children:"Agregar empresa"})]})})})]})}):(e.push("/"),Object(m.jsx)("div",{className:"sin-sesion",children:"SIN SESI\xd3N ACTIVA."}))}}}]);
//# sourceMappingURL=60.e9dd0865.chunk.js.map