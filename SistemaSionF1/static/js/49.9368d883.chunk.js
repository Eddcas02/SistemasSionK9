(this["webpackJsonp@coreui/coreui-free-react-admin-template"]=this["webpackJsonp@coreui/coreui-free-react-admin-template"]||[]).push([[49],{532:function(e,c,t){"use strict";t.d(c,"a",(function(){return i}));const n="".concat("http://34.208.193.210/apipagos/api/","bancos");function i(e,c,t,i,s,a,o,r,l,j){let d=n,b="";var h={id_banco:e,nombre:c,direccion:t,codigo_transferencia:i,codigo_SAP:s,id_pais:a,activo:o,opcion:r,id_usuario:l};""!==e&&""!==r&&(b+="/"+e+"/"+r),d+=b;const O=JSON.stringify(h);return fetch(d,{method:"POST",body:O,headers:{Authorization:"Bearer "+j,Accept:"application/json","Content-type":"application/json;charset=UTF-8"}}).then((e=>e.json())).then((e=>e)).catch((e=>e))}},599:function(e,c,t){"use strict";t.d(c,"a",(function(){return i}));const n="".concat("http://34.208.193.210/apipagos/api/","paises");function i(e,c,t){let i=n,s="";return null!==e&&(s+="/"+e),null!==c&&(s+="/"+c),i+=s,fetch(i,{method:"GET",headers:{Authorization:"Bearer "+t,Accept:"application/json"}}).then((function(e){return e.json()})).catch((e=>e))}},906:function(e,c,t){"use strict";t.r(c);var n=t(1),i=t(459),s=t(818),a=t(719),o=t(835),r=(t(465),t(16)),l=t(532),j=t(463),d=t(599),b=t(467),h=t(687),O=t(511),p=(t(460),t(462)),u=t(464),x=t(10);c.default=e=>{const c=Object(r.g)(),t=Object(r.h)(),[m,f]=Object(n.useState)(null),{session:g,clear:S}=Object(i.useSession)("PendrogonIT-Session"),[y,A]=Object(n.useState)(!1),[C,v]=Object(n.useState)(!1),[N,T]=Object(n.useState)(""),[P,E]=Object(n.useState)([]),[I,k]=Object(n.useState)({nombre:t.nombre,direccion:t.direccion,estado:t.estado,pais:t.pais,codigoTransferencia:t.codigoTransferencia,codigoSAP:t.codigoSAP});Object(n.useEffect)((()=>{let e=!0;return Object(d.a)(null,null,g.api_token).then((c=>{e&&E(c.paises)})),()=>e=!1}),[]);const w=e=>{k({...I,[e.target.name]:e.target.value})},_=async e=>{if(""!==I.nombre&&""!==I.direccion&&""!==I.pais&&""!==I.codigoTransferencia&&""!==I.codigoSAP){e.preventDefault();"OK"===await Object(l.a)(t.id_banco,I.nombre,I.direccion,I.codigoTransferencia,I.codigoSAP,I.pais,I.estado,"1",g.id,g.api_token)&&c.push("/bancos")}else A(!0),T("No has llenado todos los campos.")};async function z(e){if(1==e)v(!1);else if(2==e){let e=0;g&&(e=g.id);"OK"===await Object(j.a)(e,null,null,"2",g.api_token)&&(S(),c.push("/"))}}return g?t.id_banco?Object(x.jsx)("div",{style:{flexDirection:"row"},children:Object(x.jsxs)(p.i,{children:[Object(x.jsxs)(s.a,{responsive:!0,variant:"primary",show:C,onHide:()=>z(2),centered:!0,children:[Object(x.jsx)(s.a.Header,{closeButton:!0,children:Object(x.jsx)(s.a.Title,{children:"Confirmaci\xf3n"})}),Object(x.jsx)(s.a.Body,{children:N}),Object(x.jsxs)(s.a.Footer,{children:[Object(x.jsx)(p.c,{color:"secondary",onClick:()=>z(2),children:"Cancelar"}),Object(x.jsx)(p.c,{color:"primary",onClick:()=>z(1),children:"Aceptar"})]})]}),Object(x.jsx)("div",{className:"float-left",style:{marginBottom:"10px"},children:Object(x.jsxs)(a.a,{variant:"primary",size:"sm",onClick:()=>c.goBack(),children:[Object(x.jsx)(u.c,{}),"\xa0\xa0Regresar"]})}),Object(x.jsx)("br",{}),Object(x.jsx)("br",{}),Object(x.jsxs)(o.a,{show:y,variant:"danger",onClose:()=>A(!1),dismissible:!0,children:[Object(x.jsx)(o.a.Heading,{children:"Error!"}),Object(x.jsx)("p",{children:N})]}),Object(x.jsx)(p.d,{style:{display:"flex",alignItems:"center"},children:Object(x.jsx)(p.e,{style:{width:"80%"},children:Object(x.jsxs)(p.p,{style:{width:"100%"},children:[Object(x.jsx)("h1",{children:"Modificaci\xf3n de Banco"}),Object(x.jsx)("p",{className:"text-medium-emphasis",children:"Modifique la informaci\xf3n del banco"}),Object(x.jsxs)(p.y,{className:"mb-3",children:[Object(x.jsx)(p.z,{children:Object(x.jsx)(O.a,{})}),Object(x.jsx)(p.r,{type:"text",placeholder:"Nombre",name:"nombre",defaultValue:t.nombre,onChange:w})]}),Object(x.jsxs)(p.y,{className:"mb-3",children:[Object(x.jsx)(p.z,{children:Object(x.jsx)(h.a,{})}),Object(x.jsx)(p.r,{type:"text",placeholder:"Direccion",name:"direccion",defaultValue:t.direccion,onChange:w})]}),Object(x.jsxs)(p.y,{className:"mb-3",children:[Object(x.jsx)(p.z,{children:Object(x.jsx)(O.b,{})}),Object(x.jsx)(p.r,{type:"text",placeholder:"C\xf3digo Transferencia",name:"codigoTransferencia",defaultValue:t.codigoTransferencia,onChange:w})]}),Object(x.jsxs)(p.y,{className:"mb-3",children:[Object(x.jsx)(p.z,{children:Object(x.jsx)(O.b,{})}),Object(x.jsx)(p.r,{type:"text",placeholder:"C\xf3digo SAP",name:"codigoSAP",defaultValue:t.codigoSAP,onChange:w})]}),Object(x.jsxs)(p.y,{className:"mb-3",children:[Object(x.jsx)(p.z,{children:Object(x.jsx)(b.l,{})}),Object(x.jsxs)(p.t,{name:"pais",onChange:w,children:[Object(x.jsx)("option",{children:"Seleccione pa\xeds. (Opcional)"}),P.map(((e,c)=>Object(x.jsx)("option",{value:e.IdPais,children:e.Nombre},e.IdPais)))]})]}),Object(x.jsxs)(p.y,{className:"mb-3",children:[Object(x.jsx)(p.z,{children:Object(x.jsx)(b.w,{})}),Object(x.jsxs)(p.t,{name:"estado",onChange:w,children:[Object(x.jsx)("option",{children:"Seleccione estado. (Opcional)"}),Object(x.jsx)("option",{value:"1",children:"Activo"}),Object(x.jsx)("option",{value:"0",children:"Inactivo"})]})]}),Object(x.jsx)(p.c,{color:"primary",onClick:_,children:"Guardar Cambios"})]})})})]})}):(c.push("/bancos"),Object(x.jsx)("div",{className:"sin-sesion",children:"NO SE CARG\xd3 EL C\xd3DIGO DEL USUARIO. REGRESE A LA PANTALLA DE USUARIOS."})):(c.push("/"),Object(x.jsx)("div",{className:"sin-sesion",children:"SIN SESI\xd3N ACTIVA."}))}}}]);
//# sourceMappingURL=49.9368d883.chunk.js.map