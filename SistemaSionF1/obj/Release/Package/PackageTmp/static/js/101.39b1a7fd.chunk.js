(this["webpackJsonp@coreui/coreui-free-react-admin-template"]=this["webpackJsonp@coreui/coreui-free-react-admin-template"]||[]).push([[101],{584:function(e,t,a){"use strict";a.d(t,"a",(function(){return c}));const i="".concat("http://34.208.193.210/apipagos/api/","usuarioautorizacion");function c(e,t,a,c,n,s,r,o,l){let d=i,j="";var u={id_usuarioautorizacion:e,id_usuarioaprobador:t,id_usuariotemporal:a,fecha_inicio:c,fecha_final:n,opcion:s,activo:r,id_usuario:o};""!==e&&""!==s&&(j+="/"+e+"/"+s),d+=j;const b=JSON.stringify(u);return fetch(d,{method:"POST",body:b,headers:{Authorization:"Bearer "+l,Accept:"application/json","Content-type":"application/json;charset=UTF-8"}}).then((e=>e.json())).then((e=>e)).catch((e=>e))}},884:function(e,t,a){"use strict";a.r(t);var i=a(1),c=a(16),n=(a(465),a(818)),s=a(719),r=a(835),o=a(656),l=a.n(o),d=a(822),j=(a(570),a(459)),u=a(584),b=a(463),h=a(470),p=a(477),O=(a(460),a(462)),m=a(464),x=a(10);t.default=()=>{const e=Object(c.g)(),t=Object(c.h)(),[a,f]=Object(i.useState)(null),{session:y,clear:g}=Object(j.useSession)("PendrogonIT-Session"),[v,S]=Object(i.useState)(!1),[w,z]=Object(i.useState)(!1),[C,N]=Object(i.useState)(""),[k,_]=Object(i.useState)("danger"),[I,M]=Object(i.useState)("Error!"),[A,F]=Object(i.useState)([]),[T,B]=Object(i.useState)([]);Object(o.registerLocale)("es",d.a);const[E,L]=Object(i.useState)({aprobador:t.id_usuario,temporal:""}),[D,U]=Object(i.useState)(new Date),[H,J]=Object(i.useState)(new Date);Object(i.useEffect)((()=>{let e=!0,t=0;return y&&(t=y.id),Object(p.a)(null,null,null,null,y.api_token).then((t=>{e&&F(t.users)})),Object(h.a)(t,"2",null,y.api_token).then((t=>{e&&B(t.detalle)})),()=>e=!1}),[]);const R=e=>{L({...E,[e.target.name]:e.target.value})},K=async t=>{if(""!==E.aprobador&&""!==E.temporal&&D&&H)if(H>D){t.preventDefault();const a=await Object(u.a)("",E.aprobador,E.temporal,D,H,"","",y.id,y.api_token);"OK"===a?e.push("/autorizacion"):"Existe"===a&&(S(!0),M("Fechas existentes!"),_("danger"),N("Las fechas inicial o final coinciden con una autorizacion ya programada. Intente con otras fechas."))}else S(!0),M("Error!"),_("danger"),N("La fecha final debe ser despu\xe9s de la inicial.");else S(!0),M("Error!"),_("danger"),N("No has llenado todos los campos.")};async function P(t){if(1==t)z(!1);else if(2==t){let t=0;y&&(t=y.id);"OK"===await Object(b.a)(t,null,null,"2",y.api_token)&&(g(),e.push("/"))}}if(y){let t=!1;return 0==function(e){let t=0;for(let a of T)e===a.objeto&&(t=1);return t}("Modulo Autorizacion")&&(t=!0),Object(x.jsx)("div",{style:{flexDirection:"row"},children:Object(x.jsxs)(O.i,{children:[Object(x.jsxs)(n.a,{responsive:!0,variant:"primary",show:w,onHide:()=>P(2),centered:!0,children:[Object(x.jsx)(n.a.Header,{closeButton:!0,children:Object(x.jsx)(n.a.Title,{children:"Confirmaci\xf3n"})}),Object(x.jsx)(n.a.Body,{children:C}),Object(x.jsxs)(n.a.Footer,{children:[Object(x.jsx)(O.c,{color:"secondary",onClick:()=>P(2),children:"Cancelar"}),Object(x.jsx)(O.c,{color:"primary",onClick:()=>P(1),children:"Aceptar"})]})]}),Object(x.jsx)("div",{className:"float-left",style:{marginBottom:"10px"},children:Object(x.jsxs)(s.a,{variant:"primary",size:"sm",onClick:()=>e.goBack(),children:[Object(x.jsx)(m.c,{}),"\xa0\xa0Regresar"]})}),Object(x.jsx)("br",{}),Object(x.jsx)("br",{}),Object(x.jsxs)(r.a,{show:v,variant:k,onClose:()=>S(!1),dismissible:!0,children:[Object(x.jsx)(r.a.Heading,{children:I}),Object(x.jsx)("p",{children:C})]}),Object(x.jsx)(O.d,{className:"autorizacion-card",children:Object(x.jsx)(O.e,{style:{width:"80%"},children:Object(x.jsxs)(O.p,{className:"autorizacion-form",children:[Object(x.jsx)("h1",{children:"Asignaci\xf3n de Usuario Temporal"}),Object(x.jsx)("p",{className:"text-medium-emphasis autorizacion-form",children:"Seleccione a un nuevo encargado"}),Object(x.jsxs)(O.y,{className:"mb-3 autorizacion-form",children:[Object(x.jsx)(O.z,{style:{width:"22%"},children:"Usuario Aprobador"}),Object(x.jsxs)(O.t,{name:"aprobador",onChange:R,disabled:t,children:[Object(x.jsx)("option",{selected:!0,value:y.id,children:y.name}),A.map(((e,t)=>{if(0==e.eliminado&&1==e.activo)return Object(x.jsxs)("option",{value:e.id,children:[e.nombre," ",e.apellido]},e.id)}))]})]}),Object(x.jsxs)(O.y,{className:"mb-3 autorizacion-form",children:[Object(x.jsx)(O.z,{style:{width:"22%"},children:"Usuario Temporal"}),Object(x.jsxs)(O.t,{name:"temporal",onChange:R,children:[Object(x.jsx)("option",{children:"Seleccione usuario temporal."}),A.map(((e,t)=>{if(0==e.eliminado&&1==e.activo&&e.id!==y.id)return Object(x.jsxs)("option",{value:e.id,children:[e.nombre," ",e.apellido]},e.id)}))]})]}),Object(x.jsx)("div",{style:{width:"100%",alignItems:"center"},children:Object(x.jsxs)("div",{className:"autorizacion-fecha",children:[Object(x.jsxs)("div",{style:{width:"100%",alignItems:"center"},children:[Object(x.jsx)(O.s,{style:{marginLeft:"40px",marginRight:"15px"},children:"Fecha de Inicio"}),Object(x.jsx)(l.a,{locale:"es",selected:D,onChange:e=>U(e),dateFormat:"dd-MMMM-yyyy"})]}),Object(x.jsxs)("div",{style:{width:"50%",alignItems:"center"},children:[Object(x.jsx)(O.s,{style:{marginLeft:"40px",marginRight:"15px"},children:"Fecha de Fin"}),Object(x.jsx)(l.a,{locale:"es",selected:H,onChange:e=>J(e),dateFormat:"dd-MMMM-yyyy"})]})]})}),Object(x.jsx)("br",{}),Object(x.jsx)(O.c,{color:"primary",onClick:K,style:{marginBottom:"20px"},children:"Guardar Cambios"})]})})})]})})}return e.push("/"),Object(x.jsx)("div",{className:"sin-sesion",children:"SIN SESI\xd3N ACTIVA."})}}}]);
//# sourceMappingURL=101.39b1a7fd.chunk.js.map