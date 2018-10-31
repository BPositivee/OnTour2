using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApplication1
{
    public partial class EncargadoTemp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String user = Session["user"].ToString();
            String id = Session["id"].ToString();

            txtUser.Text = "Bienvenido " + user;
            CargarAlumnos();
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["user"] = "";
            Session["id"] = "";
            Response.Redirect("Login.aspx");
        }

     

        protected void btnRealizarPago_Click(object sender, EventArgs e)
        {

        }

        protected void btnRevisarContrato_Click(object sender, EventArgs e)
        {

        }

        protected void btnArmaContrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArmarContrato.aspx");
        }

        public void CargarAlumnos() {
            String id = Session["id"].ToString();

            decimal encargado_id = Convert.ToDecimal(id);

            var en = (from x in Conexion.Entidades.ENCARGADO
                      where x.ENCARGADO_ID == encargado_id
                      select x.CURSO_ID_CURSO).First();

            var al = (from y in Conexion.Entidades.ALUMNO
                      where y.CURSO_ID_CURSO == en
                      select new
                      {
                        y.AP_PATERNO,
                        y.AP_MATERNO,
                        y.NOMBRE,
                        y.RUT,
                        y.FECH_NAC,
                        y.DEUDA
                      });

            gvAlumnos.DataSource = al.ToList();
            gvAlumnos.DataBind();


        }
    }
}