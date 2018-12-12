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
    <title>Polizas - OnTour</title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 12px;
        }
        .auto-style3 {
            height: 26px;
            width: 12px;
        }
        .auto-style4 {
            height: 27px;
        }
        .auto-style5 {
            width: 12px;
            height: 27px;
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
                   <td class="auto-style2">&nbsp;</td>
               </tr>
                <tr>
                    <td class="auto-style4">Fecha de Cobertura</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtFecha" runat="server" placeholder="DD/MM/AAAA" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:RequiredFieldValidator ID="rfvFecha" runat="server" ControlToValidate="txtFecha" ErrorMessage="*DatoObligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Nombre Póliza</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="*DatoObligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Descripción</td>
                    <td>
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="*DatoObligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Prima a Pagar</td>
                    <td>
                        <asp:TextBox ID="txtPrima" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="rfvPrima" runat="server" ControlToValidate="txtPrima" ErrorMessage="*DatoObligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Suma Asegurada</td>
                    <td>
                        <asp:TextBox ID="txtSuma" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="rfvSuma" runat="server" ControlToValidate="txtSuma" ErrorMessage="*DatoObligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
               <tr>

                   <td>
                       <asp:Label ID="lblEstado" runat="server" Text=""></asp:Label>
                   </td>
                   <td>&nbsp;</td>
                   <td class="auto-style2">&nbsp;</td>
               </tr>
                <tr>
                    <td>
                          <asp:HyperLink ID="hlAgente" runat="server" NavigateUrl="AgenteTemp.aspx">Volver</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Button ID="btnGuardarPoliza" runat="server" Text="Agregar Póliza" class="btn btn-outline-success" OnClick="btnGuardarPoliza_Click" />
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>

            </table>



        </form>



    </div>
</body>
</html>
