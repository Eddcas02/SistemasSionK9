<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RMarcaje.aspx.cs" Inherits="SistemaSionF1.Views.Sesion.RMarcaje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />


<link href="../../EstaticosMDI/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>




<link rel="preconnect" href="https://fonts.gstatic.com"/>
<link href="https://fonts.googleapis.com/css2?family=Nunito:wght@400;600&display=swap" rel="stylesheet"/>
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.min.css" rel="stylesheet"/>
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
         <div class="col-4" style="margin-top:1% ; margin-left:1%">
           
               
             
  <a href="../Sesion/MenuBarra.aspx" ><i style="color:black" class="fa fa-home fa-3x"></i></a>


                    </div>
        <div class="general">
            <p id="color" runat="server" hidden="hidden"></p>
            <div class="formularioCobros">
                 
                  <div style="display:flex; justify-content:center">
                    <label style="font-size:18px" class="titulos"><b>Recuperación de Marcajes</b></label>
                 </div><br />

                
                  <div class="linea"></div>
            <div class="encabezado">
              <div class="formatoTitulo" style="margin-bottom:5px">
                <label class="titulos" ><b>Fecha inicial</b></label>
                               </div>
                <div class="formato">
                         <asp:TextBox  ID="FechaInicial" runat="server" type="date" class="formatoinput"/>
                                              </div><br />
             
            <div class="formatoTitulo" style="margin-bottom:5px">
                        <label class="titulos"><b>Empresa</b></label>
                         <label class="titulos" style="margin-left:57%"><b>Finca</b></label>
                       
                  </div>
                <div class="comboboxs">
                        <asp:DropDownList id="Empresa" runat="server" class="formatoinput4" AutoPostBack="true" OnSelectedIndexChanged="Empresa_SelectedIndexChanged"></asp:DropDownList>
                         <asp:DropDownList id="Finca" runat="server" class="formatoinput4" AutoPostBack="false" style="margin-right:39%"></asp:DropDownList>
                </div><br />

               <br /><br />
            
                    <div class="formato2">
                        <asp:Button ID="Procesar" runat="server" CssClass="boton" Text="Procesar" OnClick="Procesar_Cick" />
                    </div>
                </div>
                 <div class="linea"></div><br /><br />
                </div>
        </div>

                <script>
            $(document).ready(function () {
                $('.menu').load('MenuPrincipal.aspx');
            });
                </script>

    </form>
</body>
</html>
