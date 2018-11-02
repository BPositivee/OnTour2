using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using DALC;
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
            CargarContrato();
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["user"] = "";
            Session["id"] = "";
            Response.Redirect("Login.aspx");
        }



        protected void btnRealizarPago_Click(object sender, EventArgs e)
        {
            lblFormulario.Enabled = true;
            lblMonto.Enabled = true;
            lblDescripcion.Enabled = true;
            tbxDescripcion.Enabled = true;
            rfvDescripcion.Enabled = true;
            tbxMonto.Enabled = true;
            rfvPago.Enabled = true;
            btnPagar.Enabled = true;
            

            lblFormulario.Visible = true;
            lblMonto.Visible = true;
            tbxMonto.Visible = true;
            rfvPago.Visible = true;
            btnPagar.Visible = true;
            lblDescripcion.Visible = true;
            tbxDescripcion.Visible = true;
            rfvDescripcion.Visible = true;

        }

        protected void btnRevisarContrato_Click(object sender, EventArgs e)
        {
            lblContrato.Enabled = true;
            gvContrato.Enabled = true;
            lblContrato.Visible = true;
            gvContrato.Visible = true;
        }

        protected void btnArmaContrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArmarContrato.aspx");
        }

        public void CargarAlumnos()
        {
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
        public void CargarContrato() {
            String id = Session["id"].ToString();
            decimal encargado_id = Convert.ToDecimal(id);
            var con = (from x in Conexion.Entidades.CONTRATO
                       where x.ENCARGADO_ENCARGADO_ID == encargado_id
                       select new {

                           x.DESTINO.PAIS,
                           x.TOUR.NOMBRE_TOURS,
                           x.POLIZA.NOMBRE_POLIZA,
                           x.SER_ADICIONAL.NOMBRE_SER,
                           x.FECHA,
                           x.TOTAL

                       });


            gvContrato.DataSource = con.ToList();
            gvContrato.DataBind();


        }
        protected void btnPagar_Click(object sender, EventArgs e)
        {
            String id = Session["id"].ToString();
            decimal encargado_id = Convert.ToDecimal(id);//encargado_id
            var en = (from x in Conexion.Entidades.ENCARGADO            //id del curso del encargado
                      where x.ENCARGADO_ID == encargado_id
                      select x.CURSO_ID_CURSO).First();

            var con =(from j in Conexion.Entidades.CONTRATO
                      where j.ENCARGADO_ENCARGADO_ID == en
                      select j.CONTRATO_ID).First();


            var cant_al = (from y in Conexion.Entidades.ALUMNO               //cantidad de alumnos asignados al curso del encargado
                      where y.CURSO_ID_CURSO == en
                      select y).Count();

            var al = (from k in Conexion.Entidades.ALUMNO           //lista objeto ALUMNO
                      where k.CURSO_ID_CURSO == en
                      select k);

            int montoTotal = Int32.Parse(tbxMonto.Text); //monto pago

            int montoRepartir = montoTotal / cant_al;

            foreach (var i in al)
            {
                i.DEUDA = i.DEUDA - montoRepartir;
            }
            //REGISTRO EN TABLA PAGO
            var pagId = (from p in Conexion.Entidades.PAGO select p.PAGO_ID).Max();
            decimal pago_id = pagId + 1;  //pago id

            //fecha pago
            DateTime fecha = System.DateTime.Today;

            Nullable<Decimal> apoderado_id = null;


            //descripcion
            string descripcion = tbxDescripcion.Text;
            PAGO pago = new PAGO();

            pago.PAGO_ID = pago_id;
            pago.FECHA_PAGO = fecha;
            pago.MONTO_PAGO = montoTotal;
            pago.CONTRATO_CONTRATO_ID = con;
            pago.APODERADO_APODERADO_ID = apoderado_id;
            pago.ENCARGADO_ENCARGADO_ID = encargado_id;
            pago.DESCRIPCION = descripcion;

            Conexion.Entidades.PAGO.Add(pago);




            Conexion.Entidades.SaveChanges();


            Response.Redirect("EncargadoTemp.aspx");
        }
    }
}