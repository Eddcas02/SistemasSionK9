(this["webpackJsonp@coreui/coreui-free-react-admin-template"]=this["webpackJsonp@coreui/coreui-free-react-admin-template"]||[]).push([[113],{898:function(e,t,r){"use strict";r.r(t);var n=r(1),o=r(469),a=r.n(o),i=r(719),s=r(818),c=(r(465),r(509)),l=r(463),d=r(459),p=r(16),u=r(464),h=(r(460),r(471)),b=r.n(h),j=(r(472),r(10));t.default=()=>{const e=Object(p.g)(),[t,r]=Object(n.useState)(null),{session:h,clear:m}=Object(d.useSession)("PendrogonIT-Session"),[f,x]=Object(n.useState)([]),[y,O]=Object(n.useState)(!1),[S,g]=Object(n.useState)(""),v=f;async function w(t){if(1==t)O(!1);else if(2==t){let t=0;h&&(t=h.id);"OK"===await Object(l.a)(t,null,null,"2",h.api_token)&&(m(),e.push("/"))}}Object(n.useEffect)((()=>{let e=!0;return Object(c.b)(h.id,h.api_token).then((t=>{e&&x(t.flujos)})),()=>e=!1}),[]);const T={headRow:{style:{borderTopStyle:"solid",borderTopWidth:"1px",borderTopColor:o.defaultThemes.default.divider.default}},headCells:{style:{paddingLeft:"8px",paddingRight:"8px",fontSize:"12px","&:not(:last-of-type)":{borderRightStyle:"solid",borderRightWidth:"1px",borderRightColor:o.defaultThemes.default.divider.default}}},cells:{style:{"&:not(:last-of-type)":{borderRightStyle:"solid",borderRightWidth:"1px",borderRightColor:o.defaultThemes.default.divider.default}}}};let C=new Intl.NumberFormat("es-GT",{style:"currency",currency:"GTQ"}),_=new Intl.NumberFormat("en-US",{style:"currency",currency:"USD"});const z=Object(n.useMemo)((()=>[{name:"Empresa",selector:e=>e.empresa_nombre,center:!0,style:{fontSize:"11px"},sortable:!0,wrap:!0,width:"150px"},{name:"No.",selector:e=>e.doc_num,center:!0,style:{fontSize:"11px"},sortable:!0,width:"90px"},{name:"Fecha Sis.",selector:e=>e.creation_date,center:!0,sortable:!0,style:{fontSize:"11px"},width:"100px"},{name:"Beneficiario",selector:e=>e.en_favor_de,center:!0,sortable:!0,style:{fontSize:"11px"},wrap:!0,width:"250px"},{name:"Concepto",selector:e=>e.comments,center:!0,style:{fontSize:"11px"},wrap:!0,width:"285px"},{name:"Monto",selector:e=>{return t=e.doc_total,"QTZ"===e.doc_curr?C.format(t):_.format(t);var t},center:!0,style:{fontSize:"11px"},width:"120px"},{name:"Acciones",cell:function(t){return Object(j.jsx)("div",{style:{alignItems:"center"},children:Object(j.jsx)(i.a,{variant:"outline-danger",size:"sm",title:"Ver archivos",onClick:()=>e.push({pathname:"/archivoflujo",id_flujo:t.id_flujo}),children:Object(j.jsx)(u.q,{})})})},center:!0,width:"70px"}])),R={columns:z,data:v,filterPlaceholder:"Filtrar datos",export:!1,print:!1};return h?Object(j.jsxs)(j.Fragment,{children:[Object(j.jsxs)(s.a,{responsive:!0,variant:"primary",show:y,onHide:()=>w(2),centered:!0,children:[Object(j.jsx)(s.a.Header,{closeButton:!0,children:Object(j.jsx)(s.a.Title,{children:"Confirmaci\xf3n"})}),Object(j.jsx)(s.a.Body,{children:S}),Object(j.jsxs)(s.a.Footer,{children:[Object(j.jsx)(i.a,{variant:"secondary",onClick:()=>w(2),children:"Cancelar"}),Object(j.jsx)(i.a,{variant:"primary",onClick:()=>w(1),children:"Aceptar"})]})]}),Object(j.jsx)(b.a,{...R,children:Object(j.jsx)(a.a,{columns:z,noDataComponent:"No hay archivos que mostrar",data:v,customStyles:T,pagination:!0,paginationPerPage:25,responsive:!0,persistTableHead:!0,striped:!0,dense:!0})})]}):(e.push("/"),Object(j.jsx)("div",{className:"sin-sesion",children:"SIN SESI\xd3N ACTIVA."}))}}}]);
//# sourceMappingURL=113.a4cd73bf.chunk.js.map