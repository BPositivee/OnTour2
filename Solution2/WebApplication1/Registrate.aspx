<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrate.aspx.cs" Inherits="WebApplication1.Registrate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="scripts/jquery-3.0.0.min.js"></script>
    <script src="scripts/popper.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="Estilos/estiloRegistro.css" rel="stylesheet" />

</head>
<body style="background-image: url('images/banner.jpg'); background-size: cover">
  
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
                            
                                    <a class="nav-link text-white" href="Login.aspx" >LogIn </a>
                              
                        </div>
                    </nav>
                </td>
            </tr>
            </table>
            <br />

            <br />

            <br />
              <form id="form1" runat="server">
                  <table align="center">
            <tr>
                <td>Registo de Cuenta</td>
            </tr>


            <tr>

                <td>Tipo de usuario</td>
                <td>
                    <asp:DropDownList ID="ddlTipoUsuario" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True" Value="Seleccione">Seleccione </asp:ListItem>
                        <asp:ListItem Value="Encargado">Encargado Curso</asp:ListItem>
                        <asp:ListItem>Apoderado</asp:ListItem>
                    </asp:DropDownList></td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="rfvTipoUsuario" runat="server" ErrorMessage="* Debe seleccionar un Tipo de usuario" ControlToValidate="ddlTipoUsuario" ForeColor="Red" InitialValue="Seleccione"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td >Nombre</td>
                <td>
                    <asp:TextBox ID="tbxNombre" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="* Campo Obligatorio" ControlToValidate="tbxNombre" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvNombre" runat="server" ErrorMessage="* Ingrese nombre valido" ControlToValidate="tbxNombre" Display="Dynamic" ForeColor="Red" Type="String" Operator="DataTypeCheck"></asp:CompareValidator>

                </td>
            </tr>
            <tr>
                <td>Apellido Paterno</td>
                <td>
                    <asp:TextBox ID="tbxApellidoP" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="rfvApellidoP" runat="server" ErrorMessage="* Campo Obligatorio" ControlToValidate="tbxApellidoP" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvApellidoP" runat="server" ErrorMessage="* Ingrese un Apellido valido" ControlToValidate="tbxApellidoP" Display="Dynamic" ForeColor="Red" Type="String" Operator="DataTypeCheck"></asp:CompareValidator>

                </td>
            </tr>
            <tr>
                <td>Apellido Materno</td>
                <td>
                    <asp:TextBox ID="tbxApellidoM" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style1">
                    <asp:CompareValidator ID="cvApellidoM" runat="server" ErrorMessage="* Ingrese un Apellido valido" ControlToValidate="tbxApellidoM" Display="Dynamic" ForeColor="Red" Type="String" Operator="DataTypeCheck"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Nombre Usuario</td>
                <td>
                    <asp:TextBox ID="tbxUsername" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="* Campo Obligatorio" ControlToValidate="tbxUsername" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Contraseña</td>
                <td>
                    <asp:TextBox ID="tbxPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="* Campo Obligatorio" ControlToValidate="tbxPassword" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Correo</td>
                <td>
                    <asp:TextBox ID="tbxEmail" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="* Campo Obligatorio" ControlToValidate="tbxEmail" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* Ingrese un correo valido" ControlToValidate="tbxEmail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td>Celular</td>
                <td>
                    <asp:TextBox ID="tbxCelular" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="rfvCelular" runat="server" ErrorMessage="* Campo Obligatorio" ControlToValidate="tbxCelular" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>Telefono Fijo</td>
                <td>
                    <asp:TextBox ID="tbxTelefono" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>

                    <asp:HyperLink ID="hlLogin" runat="server" NavigateUrl="Inicio.aspx">Volver</asp:HyperLink>
                </td>
                <td>
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrarse" Width="128px" OnClick="btnRegistrar_Click" class="btn btn-success" />

                </td>
                <td class="auto-style1">
                    
                    <asp:Label ID="lblMensaje" runat="server" Text="" ></asp:Label>
                </td>
            </tr>


        </table>




    </form>
</body>
</html>
