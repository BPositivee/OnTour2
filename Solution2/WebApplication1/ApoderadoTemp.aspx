<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApoderadoTemp.aspx.cs" Inherits="WebApplication1.ApoderadoTemp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Apoderado</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="scripts/jquery-3.0.0.min.js"></script>
    <script src="scripts/popper.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
                                <form class="form-inline my-2 my-lg-0">
                                   <button type="button" id="CerrarSesion">Cerrar Sesion</button>
                                </form>
                            </div>
                        </nav>
                    </td>
                </tr>
            </table>



            <br />

            <br />

            <br />


            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="txtUser" runat="server" Text="Bienvenido"></asp:Label> </td>
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
                        <asp:GridView ID="gvApoderados" runat="server" CssClass="table table-bordered bs-table" HeaderStyle-BackColor="Green" HeaderStyle-CssClass="text-white" ></asp:GridView>
                      
                       
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
                        <asp:Button ID="btnRegistroAlumnos" runat="server" Text="Registrar Alumno" OnClick="btnRegistroAlumnos_Click" />
                        <asp:Button ID="RealizarPago" runat="server" Text="Realizar Pago" />
                        <asp:Button ID="RevisarContrato" runat="server" Text="Revisar Contrato" />
                    </td>
                    <td>&nbsp;</td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
