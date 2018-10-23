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
                            APELLIDOPATERNO = a.AP_PATERNO,
                            APELLIDOMATERNO = a.AP_MATERNO,
                            NOMBRE = a.NOMBRE,
                            RUT = a.RUT,
                            FECHANACIMIENTO = a.FECH_NAC
                        }
                        );
           

           
                gvApoderados.DataSource = alum.ToList();
                gvApoderados.DataBind();
           
          

        }

       

    }
}