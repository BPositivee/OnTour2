<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarPolizas.aspx.cs" Inherits="WebApplication1.AgregarPolizas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="scripts/jquery-3.0.0.min.js"></script>
    <script src="scripts/popper.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="Estilos/estiloRegistro.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body style="background-image: url('images/Greece.jpg'); background-size: cover">
    <div runat="server">
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
                                <li class="nav-item active"></li>

                            </ul>




                        </div>
                    </nav>
                </td>
            </tr>
        </table>
        <br />

        <br />

        <br />
        
        <form id="form1" runat="server">
             Agregar Pólizas
           <table align="center">
               <tr>

                   <td>&nbsp;</td>
                   <td>&nbsp;</td>
                   <td>&nbsp;</td>
               </tr>
                <tr>
                    <td>Fecha de Cobertura</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Nombre Póliza</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>Descripción</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Prima a Pagar</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Suma Asegurada</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                          <asp:HyperLink ID="hlAgente" runat="server" NavigateUrl="AgenteTemp.aspx">Volver</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Button ID="btnGuardarPoliza" runat="server" Text="Agregar Póliza" class="btn btn-success" />
                    </td>
                    <td>&nbsp;</td>
                </tr>

            </table>



        </form>



    </div>
</body>
</html>
