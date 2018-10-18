using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using DALC;
using Oracle.ManagedDataAccess;


namespace WebApplication1
{
    public partial class Registrate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            RegistrarApoderado();

        }

        private void RegistrarApoderado() {


            Apoderado ap = new Apoderado();

            //buscar ultimo registro

            var a = (from p in Conexion.Entidades.APODERADO select p.APODERADO_ID).Max();
            

            decimal id = a + 1;
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            string email = tbxEmail.Text;
            string nombre = tbxNombre.Text;
            string apellidoP = tbxApellidoP.Text;
            string apellidoM = tbxApellidoM.Text;
            string telefono = tbxTelefono.Text;
            string celular = tbxCelular.Text;
            decimal rol = 2;
            string tipo = ddlTipoUsuario.SelectedItem.ToString();



            ap.InsertarApoderado(id, username, email, apellidoP, apellidoM, nombre, telefono, celular, password, rol);
            lblMensaje.Text = "Agregado Con Exito";
            lblMensaje.Visible = true;



        }
    }
}