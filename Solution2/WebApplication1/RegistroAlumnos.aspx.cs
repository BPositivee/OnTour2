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

    public partial class RegistroAlumnos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            //id de apoderado
            String id = Session["id"].ToString();
            decimal idApo = Decimal.Parse(id);



            ALUMNO al = new ALUMNO();
            var a = (from p in Conexion.Entidades.ALUMNO select p.ALUMNO_ID).Max();
            decimal idAlumno = a + 1;
            string nombre = tbxNombre.Text.ToUpper();
            string apellidoP = tbxApellidoP.Text.ToUpper();
            string apellidoM = tbxApellidoM.Text.ToUpper();
            string rut = tbxRut.Text.ToUpper();
            string nombreCur = ddlCursos.SelectedItem.ToString();
           

            DateTime fecha_nac = DateTime.Parse(tbxFecha.Text).Date;



            //sacar id por el nombre del curso
            var i = (from c in Conexion.Entidades.CURSO
                     where c.NOMBRE_CURSO == nombreCur
                     select   c.ID_CURSO).First();


                al.CURSO_ID_CURSO = i;
                al.ALUMNO_ID = idAlumno;
                al.AP_PATERNO = apellidoP;
                al.AP_MATERNO = apellidoM;
                al.NOMBRE = nombre;
                al.RUT = rut;
                al.FECH_NAC = fecha_nac;
                al.APODERADO_APODERADO_ID = idApo;
          
          


            Conexion.Entidades.ALUMNO.Add(al);
            Conexion.Entidades.SaveChanges();
            Estado.Text = "Alumno Agregado";
            Response.AddHeader("REFRESH", "3;URL=ApoderadoTemp.aspx");


        }

        protected void btnBuscarCursos_Click(object sender, EventArgs e)
        {
            string colegio = tbxColegio.Text;
            decimal colegioId;

            var consulta = from c in Conexion.Entidades.COLEGIO
                           where c.NOMBRE_COLEGIO == colegio
                           select new
                           {
                               c.COLEGIO_ID

                           };

            foreach (var x in consulta)
            {

                colegioId = x.COLEGIO_ID;

                var cur = from cu in Conexion.Entidades.CURSO
                          where cu.COLEGIO_COLEGIO_ID == colegioId
                          select cu.NOMBRE_CURSO;




                ddlCursos.DataSource = cur.ToList();
                ddlCursos.DataBind();
            }

        }
    }
}