<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="SistemaSionF1.Views.Procesos.Busqueda" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../DiseñoModals/Modales.css" rel="stylesheet" />
    <script src='https://kit.fontawesome.com/a076d05399.js'></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.min.css" rel="stylesheet"/>
    <link rel="preconnect" href="https://fonts.gstatic.com"/>
    <link href="https://fonts.googleapis.com/css2?family=Nunito:wght@400;600&display=swap" rel="stylesheet"/>
    <title>Búsqueda</title>
     <style>
         @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;400&display=swap');
    
         html{
            width:100%;
            height:100%;
             font-family:'Montserrat';
        }

        body{
            font-family:'Montserrat';
           /* background-image:url("../../Imagenes/Imagenes_areas/fondo_blanco_liso.jpg");*/
      
  background-size: 100%;
        }

        .formularioCobros{
            display:flex;
            flex-direction:column;
            width:750px;
            justify-items: center;
            align-content: center;
            justify-content: center;
            align-items: center;
        }

        .general{
            display:flex;
            justify-content:center;
            align-content:center;
            align-items:flex-start;
            width:100%;
            height:auto;
            margin-top:25px;
            
        }

        .encabezado{
            padding:25px;
            flex-direction:column;
            margin:15px;
            width: 80%;
        }

        .linea{
            border-bottom: 3px #32599C solid;
            height:5px;
            width:100%;
        }

         .formatoinput {
            width: 46%;
            border: 0.5px black solid;
            height: 30px;
            display: flex;
            align-items: center;
            align-content:center;
        }

        .formatoinput2{
            width:99%;
            margin-top:8px;
            border: 0.5px black solid;
            height: 30px;
        }

        .formatoinput3 {
            width: 29%;
            border: 0.5px black solid;
            height: 30px;
            display: flex;
            align-items: center;
            align-content:center;
        }

          .formatoinput4 {
            width: 21%;
            border: 0.5px black solid;
            height: 30px;
            display: flex;
            align-items: center;
            align-content:center;
        }

        .formato{
            display:flex;
            flex-direction:row;
            justify-content: space-between;
            width:100%;
        }

        .formato2{
            display:flex;
            flex-direction:row;
            justify-content: space-around;
        }

        .formato3{
            display:flex;
            flex-direction:column;
            width:100%;
        }

         .titulos{
             font-size:13px;
             display:flex;
            align-items:center;
            align-content:center;
         }

        .formatoTitulo{
            display:flex;
            flex-direction:row;
            justify-content: flex-start;
        }

                .boton{
            background-color: #213C69;
            color: white;
            border:0px;
            width:45%;
            margin-top:15px;
            height: 30px;
        }

        .boton:hover {
             background-color: #32599C; 
             color: white; 
               border:0px;
             /*border: 2px solid #69A43C;*/
        }

         .boton2{
             background-color: #213C69; 
             color: white; 
             /*border: 2px solid #69A43C;*/
            width:45%;
            margin-top:15px;
            height: 30px;
              border:0px;
        }

        .boton2:hover {
            background-color: #32599C;
            color: white;
            border:0px;
        }

         .boton3{
            background-color: #003A6E;
            color: white;
            border:0px;
             width:22%;
             display: flex;
             align-items: center;
            align-content:center;
            justify-content:center;
             height: 25px;
        }

        .boton3:hover {
             background-color: white; 
             color: black; 
             border: 2px solid #003A6E;
            
        }

        .tabla{
            width:100%;
        }

      .tabla td{
            padding:7px;
        }

        .linea2{
            border-left: 1px #003563 solid;
            height:25px;
            width:5px;
        }
    </style>
</head>
<body style="background-size:cover">
     <div id="menu" runat="server" class="menu"></div>
    <form id="form1" runat="server">
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="general">
            <p id="color" runat="server" hidden="hidden"></p>
            <div class="formularioCobros">
                  <div style="display:flex; justify-content:center">
                    <label style="font-size:18px; color:#003563" class="titulos"><b>Búsqueda de Documentos</b></label>
                 </div><br />
                 <div style="display:flex; justify-content:center">
                    <span id="NombreCategoria" runat="server" style="font-size:16px; color:#003563" class="titulos"><b></b></span>
                 </div><br />
                <div style="display:flex; justify-content:center">
                    <span id="NombreSubcategoria" runat="server" style="font-size:14px; color:#003563" class="titulos"><b></b></span>
                 </div><br />

                 <div class="linea"></div>

                <div class="encabezado">
                    <div class="formato3">
                        <label class="titulos" style="color:#003563"><b>Nombre del documento</b></label>
                        <div style="margin-top:10px;" class="formato">
                           <img style="max-width:4%; display:flex;align-items:center; justify-content:center;color:#003563" src="../../Imagenes/lupa_azul.png"/>
                            <div style="width:2%;display:flex;align-items:center; justify-content:center;color:#003563" class="linea2"></div>
                            <asp:DropDownList style="width:92%" id="NombreDocumento" runat="server" class="formatoinput" AutoPostBack="false"></asp:DropDownList>
                        </div>
                    </div><br /><br />
                     <div class="formato2">
                        <asp:Button ID="Buscar" runat="server" CssClass="boton2" Text="Buscar" OnClick="Buscar_Click"/>
                    </div>
                     <div class="formato2">
                        <asp:Button ID="VerTodo" runat="server" CssClass="boton" Text="Ver Todo" OnClick="VerTodo_Click"/>
                    </div>
                </div>
                  <div class="linea"></div><br /><br />

                 <div class="encabezado" style="width:150%; font-size:14px">
                    <div style="justify-content: center;display:flex" class="formato">
                        <div>
                        <asp:GridView ID="gridViewDocumentos" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedDocumento" OnRowDataBound="gridViewDocumentos_RowDataBound" OnRowDeleting="gridViewDocumentos_RowDeleting"
                            BorderStyle="Solid" AllowPaging="true" PageSize="10" OnPageIndexChanging="documento_PageIndexChanging" BackColor="White">
                             <Columns>
                                     
                               <asp:TemplateField ControlStyle-CssClass="diseño" visible="false" HeaderText="Código">
                                    <ItemTemplate>
                                       <asp:Label ID="lblid" Text='<%# Eval("Id") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Código">
                                    <ItemTemplate>
                                       <asp:Label ID="lblcodigo" Width="86px" Text='<%# Eval("Codigo") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Tipo documento">
                                    <ItemTemplate>
                                       <asp:Label ID="lbltipodoc" Text='<%# Eval("TipoDocumento") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre documento">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombredoc" Text='<%# Eval("Nombre") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                   <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Versión">
                                    <ItemTemplate>
                                       <asp:Label ID="lblversion" Text='<%# Eval("Version") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                     <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Estado">
                                    <ItemTemplate>
                                       <asp:Label ID="lblestado" Text='<%# Eval("Estado") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Origen">
                                    <ItemTemplate>
                                       <asp:Label ID="lblorigen" Text='<%# Eval("Origen") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Opciones">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="iddoc"  runat="server" OnClick="iddoc_Click" >
                                           
                                            <asp:Image ID="imgver" runat="server" ImageUrl="../../Imagenes/verDoc.png"  AlternateText="Ver Documento" ToolTip="Ver Documento" />
                                        </asp:LinkButton>
                                   <asp:LinkButton ID="iddocdown"  runat="server" OnClick="iddocdown_Click"   >
                                       <asp:Image ID="imgdescarga" runat="server"  AlternateText="Descargar" ToolTip="Descargar"/>
                                     </asp:LinkButton>
                                       </ItemTemplate>
                                </asp:TemplateField>  
                             
                          <%--      
                                <asp:ButtonField   Text="Ver Documento" ItemStyle-CssClass="fas fa-search" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="Black">
                                    <ItemStyle Width="135px" ForeColor="Black"></ItemStyle>
                                </asp:ButtonField>--%>
                            </Columns>
                             <HeaderStyle CssClass="prueba" Height="23px" ForeColor="White" BackColor="#003563"></HeaderStyle>
                        </asp:GridView>
                       </div>
                       </div>
                </div>
            </div>
           

            
        </div>
        <asp:LinkButton Text="text" cssClass="linkbtn" runat="server" ID="po"  />
        
                                         <div id="divh" runat="server"  style="text-align: center;" >
           
                      

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="po"
                                BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                                  <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="Button2_Click" />    <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/Procesos/visordocumentos.aspx "  runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                       <%-- <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="po">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="Panl1" 
                    Duration="0.3" Fps="60">
                    <FadeIn />                                        
                    <Move Horizontal="0" Vertical="0"></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>
    </cc1:AnimationExtender>--%>

                       
                         </div>


      
        <%-- <script type="text/javascript">
             var color = document.getElementById("color").innerHTML;
             if (color == "1") {
                 document.body.style.backgroundImage = "url('../../Imagenes/Imagenes_areas/Gestor_Documental_liso.png')";
             }
             else if (color == "2") {
                 document.body.style.backgroundImage = "url('../../Imagenes/Imagenes_areas/Gestor_Documental_liso.png')";
             }
             else if (color == "3") {
                 document.body.style.backgroundImage = "url('../../Imagenes/Imagenes_areas/Gestor_Documental_liso.png')";
             }
             else if (color == "4") {
                 document.body.style.backgroundImage = "url('../../Imagenes/Imagenes_areas/Gestor_Documental_liso.png')";
             }
             else if (color == "5") {
                 document.body.style.backgroundImage = "url('../../Imagenes/Imagenes_areas/Gestor_Documental_liso.png')";
             }
             else if (color == "6") {
                 document.body.style.backgroundImage = "url('../../Imagenes/Imagenes_areas/Gestor_Documental_liso.png')";
             }
             else if (color == "7") {
                 document.body.style.backgroundImage = "url('../../Imagenes/Imagenes_areas/Gestor_Documental_liso.png')";
             }
             else if (color == "8") {
                 document.body.style.backgroundImage = "url('../../Imagenes/Imagenes_areas/Gestor_Documental_liso.png')";
             }
             else if (color == "9") {
                 document.body.style.backgroundImage = "url('../../Imagenes/Imagenes_areas/Gestor_Documental_liso.png')";
             }
         </script>--%>
        <script>
            $(document).ready(function () {
                $('.menu').load('MenuPrincipal.aspx');
            });
        </script>

              <script>
                  $('#<%=NombreDocumento.ClientID%>').chosen();
              </script>
    </form>
</body>
</html>
