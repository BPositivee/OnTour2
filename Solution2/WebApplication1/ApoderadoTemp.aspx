<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApoderadoTemp.aspx.cs" Inherits="WebApplication1.ApoderadoTemp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width:100%;">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>Bienvenido Apoderado</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>Mis Alumnos:</td>
        <td>&nbsp;</td>
    </tr>    
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:GridView ID="gvApoderados" runat="server"></asp:GridView>
            <asp:EntityDataSource ID="edsApoderados" runat="server"></asp:EntityDataSource>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td> <asp:Button ID="btnRegistroAlumnos" runat="server" Text="Registrar Alumno" OnClick="btnRegistroAlumnos_Click" /> </td>
        <td>&nbsp;</td>
    </tr>
        
</table>
    </div>
    </form>
</body>
</html>
