using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApplication1
{
    public partial class AgenteTemp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarContatos();
        }

        private void CargarContatos()
        {
            string agente = Session["id"].ToString();
            decimal agente_id = Decimal.Parse(agente);

            var contratos = (from x in Conexion.Entidades.CONTRATO
                             where agente_id == x.AGENTE_AGENTE_ID
                             select new
                             {
                                ID = x.CONTRATO_ID,
                                 PAIS = x.DESTINO.PAIS,
                                 x.ENCARGADO.NOMBRE,
                                 x.ENCARGADO.AP_PATERNO,
                                 x.FECHA,
                                 x.NOMBRE_COLEGIO,
                                 x.POLIZA.NOMBRE_POLIZA,
                                 x.TOTAL


                             });

            gvContratos.DataSource = contratos.ToList();
            gvContratos.DataBind();

        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["user"] = "";
            Session["id"] = "";
            Response.Redirect("Login.aspx");
        }
    }
}