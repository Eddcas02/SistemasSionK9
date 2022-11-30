<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="MarcajesModificar.aspx.cs" Inherits="SistemaSionF1.Views.Sesion.MarcajesModificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
<link rel="preconnect" href="https://fonts.gstatic.com"/>
<link href="https://fonts.googleapis.com/css2?family=Nunito:wght@400;600&display=swap" rel="stylesheet"/>
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.min.css" rel="stylesheet"/>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>

    <title>Marcajes</title>
     <style>
         @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;400&display=swap');
        html{
            width:100%;
            height:100%;
        }

        body{
            font-family:"Montserrat";
        }

        .formularioCobros{
            display:flex;
            flex-direction:column;
            width:950px;
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
            width: 100%;
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
            width: 23%;
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

        .comboboxs{
            display:flex;
            flex-direction:row;
            justify-content: space-between;
            width:920px;
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
             border: 0px;
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

        .Marcar:hover{
            background-image:url(../../Imagenes/cheque_verde.png);
        }

        .tabla{
            width:100%;
        }

      .tabla td{
            padding:7px;
        }
    </style>
</head>
<body style="background-size:cover">
     <div id="menu" runat="server" class="menu"></div>
    <form id="form1" runat="server">
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

         <a href="../Sesion/MenuBarra.aspx" ><i style="color:black" class="fa fa-home fa-3x"></i></a>


        <div class="general">
            <p id="color" runat="server" hidden="hidden"></p>
            <div class="formularioCobros">
                  <div style="display:flex; justify-content:center">
                    <label style="font-size:18px" class="titulos"><b>Validar marcajes pendientes</b></label>
                 </div><br />

              
                  <div class="linea"></div>
            <div class="encabezado">
              <div class="formatoTitulo" style="margin-bottom:5px">
                <label class="titulos" ><b>Fecha inicial</b></label>
                               </div>
                <div class="formato">
                         <asp:TextBox  ID="FechaInicial" runat="server" type="date" class="formatoinput"/>
                          <%-- <asp:DropDownList id="Colaborador" runat="server" class="formatoinput" AutoPostBack="false" style="margin-left:28%"></asp:DropDownList>--%>
                                              </div><br />
             
            <div class="formatoTitulo" style="margin-bottom:5px">
                        <label class="titulos"><b>Empresa</b></label>
                         <label class="titulos" style="margin-left:56%"><b>Finca</b></label>
                       
                  </div>
                <div class="formato">
                        <asp:DropDownList id="Empresa" runat="server" class="formatoinput" AutoPostBack="true" OnSelectedIndexChanged="Empresa_SelectedIndexChanged"></asp:DropDownList>
                         <asp:DropDownList id="Finca" runat="server" class="formatoinput" AutoPostBack="false" style="margin-left:28%"></asp:DropDownList>
                </div><br /><br />

                <div class="formato2">
                        <asp:Button ID="Procesar" runat="server" CssClass="boton" Text="Procesar" OnClick="Procesar_Cick" />
                    </div>

               <br /><br /><br />

                <div class="formatoBuscar">
                    <input id="Buscar" runat="server" type="text" class="formatoinput3" placeholder="Buscar..." style="border:0.5px solid #DEDEDE"/>
                    <a class="fondoLupa">
                        <img src="../../Imagenes/Imagenes_procesos/lupa.png" style="height:30px"/>
                    </a>
                </div>
              

                    <div style="overflow: auto; height: 400px">
                        <asp:GridView ID="gridViewColaboradores" runat="server" CssClass="tabla" AutoGenerateColumns="False" ForeColor="Black"
                            BorderStyle="Solid" OnRowEditing="gridColaboradores_RowEditing" OnRowCancelingEdit="gridColaboradores_RowCancelingEdit"
                OnRowUpdating="gridColaboradores_RowUpdating" onclick ="SetDivPosition()">
                            <Columns>
                                <asp:TemplateField ControlStyle-CssClass="diseño" Visible="false"  HeaderText="Empresa">
                                    <ItemTemplate>
                                       <asp:Label ID="lblempresa" Text='<%# Eval("IdEmpresa") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Id Colaborador">
                                    <ItemTemplate>
                                       <asp:Label ID="lblcolab" Text='<%# Eval("IdColaborador") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Código biometrico">
                                    <ItemTemplate>
                                       <asp:Label ID="lblcodbio" Text='<%# Eval("CodigoColaboradorBiometrico") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre Colaborador">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombre" Text='<%# Eval("NombreCompleto") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                       <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Fecha">
                                    <ItemTemplate>
                                       <asp:Label ID="lblfecha" Text='<%# Eval("Fecha","{0:dd/MM/yyyy}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                        <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Hora Entrada">
                                    <ItemTemplate>
                                       <asp:Label ID="lblentrada" Text='<%# Eval("Entrada","{0:t}") %>' runat="server" />
                                    </ItemTemplate>
                                     <EditItemTemplate>
                                        <asp:TextBox ID="txtEntrada" Text='<%# Eval("Entrada","{0:t}") %>' runat="server"  MaxLength="5"/>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Hora Salida">
                                    <ItemTemplate>
                                       <asp:Label ID="lblsalida" Text='<%# Eval("Salida","{0:t}") %>' runat="server" />
                                    </ItemTemplate>
                                     <EditItemTemplate>
                                        <asp:TextBox ID="txtSalida" Text='<%# Eval("Salida","{0:t}") %>' runat="server"  MaxLength="5"/>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño" Visible="false" HeaderText="No. Biométrico">
                                    <ItemTemplate>
                                       <asp:Label ID="lblbiometrico" Text='<%# Eval("Device") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField ControlStyle-CssClass="diseño" Visible="false" HeaderText="Observaciones">
                                    <ItemTemplate>
                                       <asp:Label ID="lblobservaciones" Text='<%# Eval("Observaciones") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField ControlStyle-CssClass="diseño" Visible="false"  HeaderText="Motivo">
                                    <ItemTemplate>
                                       <asp:Label ID="lblmotivo" Text='<%# Eval("Motivo") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="../../Imagenes/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
                        </EditItemTemplate>
          
                    </asp:TemplateField>
                            </Columns>
                             <HeaderStyle CssClass="prueba"  ForeColor="White" BackColor="#0069C4"></HeaderStyle>
                        </asp:GridView>
                    </div>
                <br /><br />
            
                    
                </div>
                 <div class="linea"></div><br /><br />
                </div>
        </div>

                <script>
            $(document).ready(function () {
                $('.menu').load('MenuPrincipal.aspx');
            });
                </script>

        <script>
            $(document).ready(function () {
                $("#Buscar").on("keyup", function () {
                    var value = $(this).val().toLowerCase();
                    $("#gridViewColaboradores tr").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            });
        </script>

        <script>
            var texto1 = document.querySelector('#txtEntrada');
            var texto2 = document.querySelector('#txtSalida');

            texto1.addEventListener('keypress', function (e) {
                // keyCode del punto decimal, también se puede cambiar por la coma que sería el 44
                const decimalCode = 46;
                // chequeo que el keyCode corresponda a las teclas de los números y al punto decimal
                if ((e.keyCode < 48 || e.keyCode > 57) && e.keyCode != decimalCode) {
                    e.preventDefault();
                }
                // chequeo que sólo exista un punto decimal
                else if (e.keyCode == decimalCode && /\./.test(this.value)) {
                    event.preventDefault();
                }
            }, true)

            texto2.addEventListener('keypress', function (e) {
                // keyCode del punto decimal, también se puede cambiar por la coma que sería el 44
                const decimalCode = 46;
                // chequeo que el keyCode corresponda a las teclas de los números y al punto decimal
                if ((e.keyCode < 48 || e.keyCode > 57) && e.keyCode != decimalCode) {
                    e.preventDefault();
                }
                // chequeo que sólo exista un punto decimal
                else if (e.keyCode == decimalCode && /\./.test(this.value)) {
                    event.preventDefault();
                }
            }, true)
        </script>

        <script type="text/javascript">
            window.onload = function () {
                var strCook = document.cookie;
                if (strCook.indexOf("!~") != 0) {
                    var intS = strCook.indexOf("!~");
                    var intE = strCook.indexOf("~!");
                    var strPos = strCook.substring(intS + 2, intE);
                    document.getElementById("gridViewColaboradores").scrollTop = strPos;
                }
            }
            function SetDivPosition() {
                var intY = document.getElementById("gridViewColaboradores").scrollTop;
                document.title = intY;
                document.cookie = "yPos=!~" + intY + "~!";

            }
        </script>

    </form>
</body>
</html>
