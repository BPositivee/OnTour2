﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EncargadoTemp.aspx.cs" Inherits="WebApplication1.EncargadoTemp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="scripts/jquery-3.0.0.min.js"></script>
    <script src="scripts/popper.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="Estilos/estiloRegistro.css" rel="stylesheet" />
</head>
<body  style="background-image: url('images/rovinj.jpg'); background-size: cover">

      <table>
                <tr>
                    <td class="auto-style2">
                        <nav class="navbar navbar-expand-md navbar-dark bg-dark fixed-top">
                            <a class="navbar-brand" href="Inicio.aspx">OnTour - Viajes de Estudio</a>
                            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
                                <span class="navbar-toggler-icon"></span>
                            </button>

                            <div class="collapse navbar-collapse" id="navbarsExampleDefault">
                                <ul class="navbar-nav mr-auto">
                                    <li class="nav-item active">
                                        <a class="nav-link" href="DestinosPreferidos.aspx">Destinos Preferidos <span class="sr-only">(current)</span></a>
                                    </li>

                                </ul>
                               
                            </div>
                        </nav>
                    </td>
                </tr>
            </table>
    <form id="form1" runat="server">
    <div>
   <table style="width: 100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <div align="right">
                            <asp:Button ID="btnCerraSesion" runat="server" Text="Cerrar Sesion" OnClick="btnCerrarSesion_Click" class="btn btn-outline-dark" />
                        </div>
                        <asp:Label ID="txtUser" runat="server" Text="Bienvenido"></asp:Label>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>Mis Alumnos:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                      
                            <asp:GridView ID="gvAlumnos" runat="server" HeaderStyle-BackColor="Green" HeaderStyle-CssClass="text-white" CssClass="gv1"></asp:GridView>


                        

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
                    <td>
                        <asp:Button ID="btnArmaContrato" runat="server" Text="Arma tu Contrato" class="btn btn-outline-success" OnClick="btnArmaContrato_Click"/>
                        <asp:Button ID="btnRealizarPago" runat="server" Text="Realizar Pago" class="btn btn-outline-danger" OnClick="btnRealizarPago_Click"/>
                        <asp:Button ID="btnRevisarContrato" runat="server" Text="Revisar Contrato" class="btn btn-outline-info" OnClick="btnRevisarContrato_Click"/>
                    </td>
                    <td>&nbsp;</td>
                </tr>

            </table>
    </div>
    </form>
</body>
</html>
