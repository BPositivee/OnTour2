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
    public partial class AgregarPolizas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarPoliza_Click(object sender, EventArgs e)
        {
            //obtener poliza con idMayor
            var buscarPoliza = (from x in Conexion.Entidades.POLIZA
                                select x.POLIZA_ID).Max();
            decimal idPoliza = buscarPoliza +  1; //poliza id


            DateTime fecha = DateTime.Parse(txtFecha.Text);
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal prima = Decimal.Parse(txtPrima.Text);
            decimal suma = Decimal.Parse(txtSuma.Text);

            POLIZA poliza = new POLIZA();
            poliza.POLIZA_ID = idPoliza;
            poliza.FECHA_COBERTURA = fecha;
            poliza.NOMBRE_POLIZA = nombre;
            poliza.DESCRIPCION = descripcion;
            poliza.PRIMA = prima;
            poliza.SUMA_ASEGURADA = suma;

            Conexion.Entidades.POLIZA.Add(poliza);
            Conexion.Entidades.SaveChanges();
            lblEstado.Text = "Poliza Agregada";
            Response.AddHeader("REFRESH", "3;URL=AgenteTemp.aspx");


        }
    }
}