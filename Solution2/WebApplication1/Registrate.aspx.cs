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

        public void RegistrarApoderado() {


            Apoderado ap = new Apoderado();

            //buscar ultimo registro

            var a = (from p in Conexion.Entidades.APODERADO select p.APODERADO_ID).Max();
            

            decimal id = a + 1;
            string username = tbxUsername.Text.ToUpper();
            string password = tbxPassword.Text.ToUpper();
            string email = tbxEmail.Text.ToUpper();
            string nombre = tbxNombre.Text.ToUpper();
            string apellidoP = tbxApellidoP.Text.ToUpper();
            string apellidoM = tbxApellidoM.Text.ToUpper();
            string telefono = tbxTelefono.Text.ToUpper();
            string celular = tbxCelular.Text.ToUpper();
            decimal rol = 2;
            string tipo = ddlTipoUsuario.SelectedItem.ToString();

          

            ap.InsertarApoderado(id, username, email, apellidoP, apellidoM, nombre, telefono, celular, password, rol);
            lblMensaje.Text = "Agregado Con Exito";
            lblMensaje.Visible = true;



        }

        protected void btnGuardarColegio_Click(object sender, EventArgs e)
        {

        }

        protected void btnGuardarCurso_Click(object sender, EventArgs e)
        {
           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue == "No")
            {
                lblNombreColegio.Enabled = true;
                lblNombreColegio.Visible = true;
                tbxNombreColegio.Enabled = true;
                tbxNombreColegio.Visible = true;
                rfvNombreColegio.Enabled = true;
                rfvNombreColegio.Visible = true;
                lblDireccion.Enabled = true;
                lblDireccion.Visible = true;
                tbxDireccion.Enabled = true;
                tbxDireccion.Visible = true;
                rfvDireccion.Enabled = true;
                rfvDireccion.Visible = true;
                lblTelefonoColegio.Enabled = true;
                lblTelefonoColegio.Visible = true;
                tbxTelefonoColegio.Enabled = true;
                tbxTelefonoColegio.Visible = true;
                rfvFonoColegio.Enabled = true;
                rfvFonoColegio.Visible = true;
                btnGuardarColegio.Enabled = true;
                btnGuardarColegio.Visible = true;
                lblMensajeC.Enabled = true;
                lblMensajeC.Visible = true;



            }
            else {

                lblNombreColegio.Enabled = false;
                lblNombreColegio.Visible = false;
                tbxNombreColegio.Enabled = false;
                tbxNombreColegio.Visible = false;
                rfvNombreColegio.Enabled = false;
                rfvNombreColegio.Visible = false;
                lblDireccion.Enabled = false;
                lblDireccion.Visible = false;
                tbxDireccion.Enabled = false;
                tbxDireccion.Visible = false;
                rfvDireccion.Enabled = false;
                rfvDireccion.Visible = false;
                lblTelefonoColegio.Enabled = false;
                lblTelefonoColegio.Visible = false;
                tbxTelefonoColegio.Enabled = false;
                tbxTelefonoColegio.Visible = false;
                rfvFonoColegio.Enabled = false;
                rfvFonoColegio.Visible = false;
                btnGuardarColegio.Enabled = false;
                btnGuardarColegio.Visible = false;
                lblMensajeC.Enabled = false;
                lblMensajeC.Visible = false;



            }
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedValue == "No") {
                lblNombreCurso.Enabled = true;
                lblNombreCurso.Visible = true;
                tbxNombreCurso.Enabled = true;
                tbxNombreCurso.Visible = true;
                rfvNombreCurso.Enabled = true;
                rfvNombreCurso.Visible = true;
                btnGuardarCurso.Enabled = true;
                btnGuardarCurso.Visible = true;
                lblMensajeCu.Enabled = true;
                lblMensajeCu.Visible = true;



            } else {

                lblNombreCurso.Enabled = false;
                lblNombreCurso.Visible = false;
                tbxNombreCurso.Enabled = false;
                tbxNombreCurso.Visible = false;
                rfvNombreCurso.Enabled = false;
                rfvNombreCurso.Visible = false;
                btnGuardarCurso.Enabled = false;
                btnGuardarCurso.Visible = false;
                lblMensajeCu.Enabled = false;
                lblMensajeCu.Visible = false;


            }
        }

        protected void ddlTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlTipoUsuario.SelectedValue == "2")
            {


                lblColegio.Enabled = true;
                lblColegio.Visible = true;
                ddlColegio.Enabled = true;
                ddlColegio.Visible = true;
                rfvColegio.Enabled = true;
                rfvColegio.Visible = true;
                Pregunta1.Enabled = true;
                Pregunta1.Visible = true;
                RadioButtonList1.Enabled = true;
                RadioButtonList1.Visible = true;
                rfvListaColegio.Enabled = true;
                rfvListaColegio.Visible = true;


                lblCurso.Enabled = true;
                lblCurso.Visible = true;
                ddlCurso.Enabled = true;
                ddlCurso.Visible = true;
                rfvCurso.Enabled = true;
                rfvCurso.Visible = true;
                Pregunta2.Enabled = true;
                Pregunta2.Visible = true;
                RadioButtonList2.Enabled = true;
                RadioButtonList2.Visible = true;
                rfvListaCurso.Enabled = true;
                rfvListaCurso.Visible = true;
            }
            else {
                lblColegio.Enabled = false;
                lblColegio.Visible = false;
                ddlColegio.Enabled = false;
                ddlColegio.Visible = false;
                rfvColegio.Enabled = false;
                rfvColegio.Visible = false;
                Pregunta1.Enabled = false;
                Pregunta1.Visible = false;
                RadioButtonList1.Enabled = false;
                RadioButtonList1.Visible = false;
                rfvListaColegio.Enabled = false;
                rfvListaColegio.Visible = false;


                lblCurso.Enabled = false;
                lblCurso.Visible = false;
                ddlCurso.Enabled = false;
                ddlCurso.Visible = false;
                rfvCurso.Enabled = false;
                rfvCurso.Visible = false;
                Pregunta2.Enabled = false;
                Pregunta2.Visible = false;
                RadioButtonList2.Enabled = false;
                RadioButtonList2.Visible = false;
                rfvListaCurso.Enabled = false;
                rfvListaCurso.Visible = false;




            }
        }
    }
}