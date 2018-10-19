using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALC;
using Negocio;
namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtPassword.Text;

           var consulta = (from u in Conexion.Entidades.APODERADO
                            where u.USERNAME == user && u.PASSWORD == pass
                            select u );


            var consulta2 = (from u in Conexion.Entidades.ADMINISTRADOR
                            where u.USERNAME == user && u.PASSWORD == pass
                            select u);

            var consulta3 = (from u in Conexion.Entidades.AGENTE
                            where u.USERNAME == user && u.PASSWORD == pass
                            select u);

            var consulta4 = (from u in Conexion.Entidades.ENCARGADO
                            where u.USERNAME == user && u.PASSWORD == pass
                            select u);

            foreach (var x in consulta) {

                if (x.USERNAME == user && x.PASSWORD == pass) {

                    Session["user"] = x.USERNAME;

                    if (x.ROLES_ROLES_ID == 2) {
                        Response.Redirect("ApoderadoTemp.aspx");

                    }


                }


            }
            
        }
    }
}