<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioUsuarios.aspx.cs" Inherits="SistemaSionF1.Views.Procesos.Reportes.FormularioUsuarios" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="margin-top: 10%;">
            <rsweb:ReportViewer ID="FormularioUsuarios2" runat="server" style="min-width:833px; max-width:937px;"></rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
