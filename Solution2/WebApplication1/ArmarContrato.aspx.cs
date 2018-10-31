using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace WebApplication1
{
    public partial class ArmarContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
          
       
           
            if (!IsPostBack)
            {
             
                CargarDdlColegio();
                CargarDdlDestino();
                CargarDdlSeguro();
                lblSubTotal.Text = "MAMAMA CAMBIA";
            }

            String user = Session["user"].ToString();
            String id = Session["id"].ToString();
            lblUser.Text = user;

        }

        protected void btnRegistrarContrato_Click(object sender, EventArgs e)
        {

        }

        public void CargarDdlColegio() {
            String id = Session["id"].ToString();
            decimal encargado_id = Convert.ToDecimal(id);

            var en = (from x in Conexion.Entidades.ENCARGADO
                      where x.ENCARGADO_ID == encargado_id
                      select x.CURSO_ID_CURSO).First();

            var col = (from y in Conexion.Entidades.CURSO
                       where y.ID_CURSO == en
                       select y.COLEGIO_COLEGIO_ID).First();

            var nCol = (from z in Conexion.Entidades.COLEGIO
                        where z.COLEGIO_ID == col
                        select  z.NOMBRE_COLEGIO );

            DdlColegio.DataSource = nCol.ToList();
            DdlColegio.DataBind();
            DdlColegio.Items.Insert(0, "SELECIONE");
        }
        public void CargarDdlDestino() {
            var des = from x in Conexion.Entidades.DESTINO
                       select x.PAIS ;

            DdlDestino.DataSource = des.ToList();
            DdlDestino.DataBind();
            DdlDestino.Items.Insert(0, "SELECIONE");


        }
        protected void DdlDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDestino = DdlDestino.SelectedValue;

            var col = (from x in Conexion.Entidades.DESTINO
                      where x.PAIS == nombreDestino
                      select x.DESTINO_ID).First();
        
            
            var cur = from c in Conexion.Entidades.TOUR
                       where c.TOUR_ID == col
                       select c.NOMBRE_TOURS;





            
            DdlTour.DataSource = cur.ToList();
            DdlTour.DataBind();
            DdlTour.Items.Insert(0, "SELECIONE");

        }
        public void CargarDdlSeguro (){

            var ser = from x in Conexion.Entidades.POLIZA
                      select x.NOMBRE_POLIZA;

            DdlSeguro.DataSource = ser.ToList();
            DdlSeguro.DataBind();
            DdlSeguro.Items.Insert(0, "SELECIONE");


        }

        protected void DdlSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombrePol = DdlSeguro.SelectedValue;

            var ser = (from x in Conexion.Entidades.POLIZA
                      where x.NOMBRE_POLIZA == nombrePol
                      select x.DESCRIPCION).First();


           lblInfoSeguro.Text = ser;
        }

        protected void DdlTour_SelectedIndexChanged(object sender, EventArgs e)
        {

            // decimal valorSubTotal = ValorSeguro() + ValorTour();

            string nombreTour = DdlTour.SelectedValue;
            var val = (from x in Conexion.Entidades.TOUR
                       where x.NOMBRE_TOURS == nombreTour
                       select x.PRECIO_TOTAL).First();

           tbxPrecioTour.Text = val.ToString();








        }

        //metodo para poner en el selected index changed
        public Decimal ValorTour() {
            string nombreTour = DdlTour.SelectedValue;

            var val = (from x in Conexion.Entidades.TOUR
                      where x.NOMBRE_TOURS == nombreTour
                      select  x.PRECIO_TOTAL).First();

            return val;

        }

        //metodo para sacar valor $$ del seguro 

        public Decimal ValorSeguro() {
            string nombreSeguro = DdlSeguro.SelectedValue;

            var val = (from x in Conexion.Entidades.POLIZA
                       where x.NOMBRE_POLIZA == nombreSeguro
                       select x.PRIMA).First();

            return val;



        }
    }
}