<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroAlumnos.aspx.cs" Inherits="WebApplication1.RegistroAlumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="scripts/jquery-3.0.0.min.js"></script>
    <script src="scripts/popper.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 229px;
        }
        .auto-style2 {
            height: 62px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <b>Registo de Alumno</b>
        <b/>

        <b/>

        <b/>

        <table class="auto-style1">
            
            <tr>
                <td>Nombre</td>
                <td>
                    <asp:TextBox ID="tbxNombre" runat="server"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="* Campo Obligatorio" ControlToValidate="tbxNombre" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator> 
                    <asp:CompareValidator ID="cvNombre" runat="server" ErrorMessage="* Ingrese nombre valido" ControlToValidate="tbxNombre" Display="Dynamic" ForeColor="Red" Type="String" Operator="DataTypeCheck"></asp:CompareValidator>
                
                </td>
            </tr>
            <tr>
                <td>Apellido Paterno</td>
                <td>
                    <asp:TextBox ID="tbxApellidoP" runat="server"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ID="rfvApellidoP" runat="server" ErrorMessage="* Campo Obligatorio" ControlToValidate="tbxApellidoP" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvApellidoP" runat="server" ErrorMessage="* Ingrese un Apellido valido" ControlToValidate="tbxApellidoP" Display="Dynamic" ForeColor="Red" Type="String" Operator="DataTypeCheck"></asp:CompareValidator>
                
                </td>
            </tr>
            <tr>
                <td>Apellido Materno</td>
                <td>
                    <asp:TextBox ID="tbxApellidoM" runat="server"></asp:TextBox></td>
                <td><asp:CompareValidator ID="cvApellidoM" runat="server" ErrorMessage="* Ingrese un Apellido valido" ControlToValidate="tbxApellidoM" Display="Dynamic" ForeColor="Red" Type="String" Operator="DataTypeCheck"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>RUT</td>
                <td>
                    <asp:TextBox ID="tbxRut" runat="server"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="* Campo Obligatorio" ControlToValidate="tbxRut" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator> </td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha Nacimiento</td>
                <td class="auto-style2"> 
                    <asp:TextBox ID="tbxFecha" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Colegio</td>
                <td><asp:TextBox ID="tbxColegio" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btnBuscarCursos" runat="server" Text="Buscar Cursos" OnClick="btnBuscarCursos_Click" />
                </td>



            </tr>
            <tr>
                <td>Curso</td>
                <td><asp:DropDownList ID="ddlCursos" runat="server"></asp:DropDownList></td>
                <td> 
                   

                </td>
                </tr>
           
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" Width="128px" OnClick="btnRegistrar_Click" /></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:HyperLink ID="hlAlumno" runat="server" NavigateUrl="Apoderado.aspx">Volver</asp:HyperLink></td>
                <td>
                    <asp:Label ID="Estado" runat="server" Text="Label"></asp:Label></td>
            </tr>


        </table>
        
    </div>
    </form>
</body>
</html>
