<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrincipalMaster.aspx.cs" Inherits="SistemaSionF1.Views.MDIPrincipal.PrincipalMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css'>
    <link href="../../SQEstilos/EstilosMenu.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css" />
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <link href="../../SQEstilos/EstilosMenu.css" rel="stylesheet" />
    <link href="../../EstaticosMDI/estilosbarrita.css" rel="stylesheet" />
    <script src="../../EstaticosMDI/jsbarrita.js"></script>
    <link rel="stylesheet" href="../../AvDiseños/Botones.css" />
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js" type="text/javascript"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.min.css" rel="stylesheet" />
    <link href="../../EstaticosMDI/cssContene.css" rel="stylesheet" />
    <title>Principal</title>
</head> 
<body>
    <form id="form1" runat="server">


        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>





        <%-- MENU PRINCIPAL --%>
   <nav class="navbar navbar-default no-margin">
      <!-- Brand and toggle get grouped for better mobile display -->
      <div class="navbar-header fixed-brand">
         <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" id="menu-toggle">
<span class="glyphicon glyphicon-th-large" aria-hidden="true"></span>
</button>
        <a class="navbar-brand" style="font-size: 15px"><i class="fa fa-file fa-4"></i>Menú de Gestión</a>
      </div>
      <!-- navbar-header-->
      <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
         <ul class="nav navbar-nav">
            <li class="active">
               <button class="navbar-toggle collapse in" data-toggle="collapse" id="menu-toggle-2"> <span class="glyphicon glyphicon-th-large" aria-hidden="true"></span>
               </button>
            </li>
         </ul>
      </div>
      <!-- bs-example-navbar-collapse-1 -->
   </nav>

        <%-- OPCIONES DEL MENU --%>
        <div id="wrapper">
            <%-- MENU --%>
            <div id="sidebar-wrapper">
                <ul class="sidebar-nav nav-pills nav-stacked" id="menu">
                    <li class="active">
                        <a href="PrincipalMaster.aspx"><span class="fa-stack fa-lg pull-left"><i class="fa fa-home fa-stack-1x "></i></span>Inicio</a>

                    </li>

                    <%--    INFOGENERAL    --%>




                    <asp:Repeater ID="RepetirAreas" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                        <ItemTemplate>
                            <li>
                                     <asp:Label ID="lblarea" runat="server" Visible="false" Text='<%# Eval("gen_areanombre") %>'></asp:Label>
                        
                                <a id="dash" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-user fa-stack-1x "></i></span>   <%# Eval("gen_areanombre") %></a>
 <ul class="nav-pills nav-stacked" style="list-style-type: none;">
                                <asp:Repeater ID="repetirapp" runat="server">
                                    <ItemTemplate>

                                       
                                                      <asp:Label ID="idapp" runat="server" Visible="false" Text='<%# Eval("codegenapp") %>'></asp:Label>
                                            <li><a id="datosp" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-edit fa-stack-1x "></i></span><%# Eval("gen_nombreapp") %></a></li>


                                      
                                    </ItemTemplate>
                                </asp:Repeater>
  </ul>
                            </li>


                        </ItemTemplate>
                    </asp:Repeater>

                    <%--    ACTIVO          --%>




                    <%--    PASIVO          --%>






                    <%--    INGRESOS        --%>






                    <%--    EGRESOS          --%>


            




                    <%--    MANTENIMIENTO          --%>




               


                    <%--    OPCIONES DE ADMINISTRACION          --%>



<%--                    <li>
                        <a id="A1" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-pencil fa-stack-1x "></i></span>Administración</a>
                        <ul class="nav-pills nav-stacked" style="list-style-type: none;">
                            <li><a id="BASIGLOTE" runat="server" href="~/Views/EP/est_elegirlote.aspx"><span class="fa-stack fa-lg pull-left"><i class="fa fa-group fa-stack-1x "></i></span>Administración de lotes</a></li>

                        </ul>
                    </li>


                    <li>
                        <a id="reportes" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-line-chart fa-stack-1x "></i></span>Reportes</a>

                    </li>
                    <li>
                        <a id="finaltodo" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-check fa-stack-1x "></i></span>
                            <asp:LinkButton ID="LinkButton1" CausesValidation="False" OnClick="LinkButton1_Click" Text="Finalizar" runat="server" /></a>

                    </li>
                    <li>
                        <a id="Reporte" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-archive fa-stack-1x "></i></span>
                            <asp:LinkButton ID="isrepo" OnClientClick="return confirm('¿Verificar su Reporte?')" CausesValidation="False" OnClick="isrepo_Click" Text="Reporte" runat="server" /></a>

                    </li>--%>
                    <li>
                        <a id="lotes" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-database fa-stack-1x "></i></span>
                            <asp:Label ID="nombreuser" runat="server" /> </a>

                    </li>
                    <li class="btn-danger">
                        <a id="salir" href="../Sesion/CerrarSesion.aspx"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-close fa-stack-1x "></i></span>Salir</a>
                        <a href="#">content</a>
                    </li>
                </ul>
            </div>
            <%-- CONTENIDO DE LA PAGINA --%>
            <div id="page-content-wrapper">
                <div class="container-fluid xyz">
                    <div class="row">
                        <div class="col-lg-12">
                            <h1 id="encabezado">Sistemas Sion<a></a></h1>

                            <p id="subencabezado">
                                Bienvenido, da click en una <b>Opcion</b>, para gestionar cualquier sistema.
                  
                            </p>

                        </div>

                        <div id="data" runat="server" class="menu">
                            <%-- Información General --%>

                            <asp:Repeater ID="repetirdiv" runat="server">
                                <ItemTemplate>

                                                            <div id="INFOGENERAL" runat="server">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>

                                        <div class="atrib1">
                                            <iframe id="iframer" runat="server" src='<%# Eval("gen_urlareaapp") %>' class="cont"></iframe>
                                        </div>


                                    </ContentTemplate>

                                </asp:UpdatePanel>
                            </div>

                                </ItemTemplate>
                            </asp:Repeater>

    

                


                        </div>


                    </div>









                </div>
            </div>
        </div>
        <!-- /#page-content-wrapper -->

    <%--    <asp:LinkButton ID="btnrecargar" runat="server" OnClick="btnrecargar_Click" ClientIDMode="Static"></asp:LinkButton>--%>

        <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
        <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js'></script>
        <script src="../../SQEstilos/jsmenu.js"></script>


    </form>


    <script>

        function numeros(e) {
            var unicode = e.charCode ? e.charCode : e.keyCode
            if (unicode != 8) {
                if (unicode < 48 || unicode > 57) //if not a number
                { return false } //disable key press    
            }
        }

        function soloLetras(e) {
            key = e.keyCode || e.which;
            tecla = String.fromCharCode(key).toLowerCase();
            letras = " áéíóúabcdefghijklmnñopqrstuvwxyz";
            especiales = "8-37-39-46";

            tecla_especial = false
            for (var i in especiales) {
                if (key == especiales[i]) {
                    tecla_especial = true;
                    break;
                }
            }

            if (letras.indexOf(tecla) == -1 && !tecla_especial) {
                return false;
            }
        }

    </script>
    <script type="text/javascript">

        function redirigir() {

            document.getElementById('btnrecargar').click();

        }
    </script>
</body>
</html>
