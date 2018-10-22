using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace WebApplication1
{
    public partial class ApoderadoTemp : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            String user = Session["user"].ToString();
            String id = Session["id"].ToString();
            txtUser.Text = "Bienvenido " + user;
            CargarAlumnos();
           // gvApoderados.HeaderRow.Cells[0].Text = "APELLIDO PATERNO";
           // gvApoderados.HeaderRow.Cells[1].Text = "APELLIDO MATERNO";
           // gvApoderados.HeaderRow.Cells[2].Text = "NOMBRE";
           // gvApoderados.HeaderRow.Cells[3].Text = "RUT";
            //gvApoderados.HeaderRow.Cells[4].Text = "FECHA NACIMIENTO";
        }

        protected void btnRegistroAlumnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroAlumnos.aspx");
        }

        protected void RealizarPago_Click(object sender, EventArgs e)
        {

        }

        protected void RevisarContrato_Click(object sender, EventArgs e)
        {

        }

        protected void CerrarSesion_Click(object sender, EventArgs e)
        {

        }

        public void CargarAlumnos() {
            String id = Session["id"].ToString();
            int idApo = Int32.Parse(id);

            var alum = (from a in Conexion.Entidades.ALUMNO
                        where a.APODERADO_APODERADO_ID == idApo
                        select new {
                            a.AP_PATERNO,
                            a.AP_MATERNO,
                            a.NOMBRE,
                            a.RUT,
                            a.FECH_NAC
                        }
                        );

            gvApoderados.DataSource = alum.ToList();
            gvApoderados.DataBind();

        }

    }
}