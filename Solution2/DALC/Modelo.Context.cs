﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACTIVIDAD_TOUR> ACTIVIDAD_TOUR { get; set; }
        public DbSet<ADMINISTRADOR> ADMINISTRADOR { get; set; }
        public DbSet<AGENTE> AGENTE { get; set; }
        public DbSet<ALUMNO> ALUMNO { get; set; }
        public DbSet<APODERADO> APODERADO { get; set; }
        public DbSet<COLEGIO> COLEGIO { get; set; }
        public DbSet<CONTRATO> CONTRATO { get; set; }
        public DbSet<CURSO> CURSO { get; set; }
        public DbSet<DESTINO> DESTINO { get; set; }
        public DbSet<ENCARGADO> ENCARGADO { get; set; }
        public DbSet<PAGO> PAGO { get; set; }
        public DbSet<POLIZA> POLIZA { get; set; }
        public DbSet<ROLES> ROLES { get; set; }
        public DbSet<SER_ADICIONAL> SER_ADICIONAL { get; set; }
        public DbSet<TOUR> TOUR { get; set; }
    
        public virtual int InsertarApoderado(Nullable<decimal> a_APODERADO_ID, string a_USERNAME, string a_EMAIL, string a_AP_PATERNO, string a_AP_MATERNO, string a_NOMBRE, string a_TELEFONO, string a_CELULAR, string a_PASSWORD, Nullable<decimal> a_ROLES_ROLES_ID)
        {
            var a_APODERADO_IDParameter = a_APODERADO_ID.HasValue ?
                new ObjectParameter("A_APODERADO_ID", a_APODERADO_ID) :
                new ObjectParameter("A_APODERADO_ID", typeof(decimal));
    
            var a_USERNAMEParameter = a_USERNAME != null ?
                new ObjectParameter("A_USERNAME", a_USERNAME) :
                new ObjectParameter("A_USERNAME", typeof(string));
    
            var a_EMAILParameter = a_EMAIL != null ?
                new ObjectParameter("A_EMAIL", a_EMAIL) :
                new ObjectParameter("A_EMAIL", typeof(string));
    
            var a_AP_PATERNOParameter = a_AP_PATERNO != null ?
                new ObjectParameter("A_AP_PATERNO", a_AP_PATERNO) :
                new ObjectParameter("A_AP_PATERNO", typeof(string));
    
            var a_AP_MATERNOParameter = a_AP_MATERNO != null ?
                new ObjectParameter("A_AP_MATERNO", a_AP_MATERNO) :
                new ObjectParameter("A_AP_MATERNO", typeof(string));
    
            var a_NOMBREParameter = a_NOMBRE != null ?
                new ObjectParameter("A_NOMBRE", a_NOMBRE) :
                new ObjectParameter("A_NOMBRE", typeof(string));
    
            var a_TELEFONOParameter = a_TELEFONO != null ?
                new ObjectParameter("A_TELEFONO", a_TELEFONO) :
                new ObjectParameter("A_TELEFONO", typeof(string));
    
            var a_CELULARParameter = a_CELULAR != null ?
                new ObjectParameter("A_CELULAR", a_CELULAR) :
                new ObjectParameter("A_CELULAR", typeof(string));
    
            var a_PASSWORDParameter = a_PASSWORD != null ?
                new ObjectParameter("A_PASSWORD", a_PASSWORD) :
                new ObjectParameter("A_PASSWORD", typeof(string));
    
            var a_ROLES_ROLES_IDParameter = a_ROLES_ROLES_ID.HasValue ?
                new ObjectParameter("A_ROLES_ROLES_ID", a_ROLES_ROLES_ID) :
                new ObjectParameter("A_ROLES_ROLES_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarApoderado", a_APODERADO_IDParameter, a_USERNAMEParameter, a_EMAILParameter, a_AP_PATERNOParameter, a_AP_MATERNOParameter, a_NOMBREParameter, a_TELEFONOParameter, a_CELULARParameter, a_PASSWORDParameter, a_ROLES_ROLES_IDParameter);
        }
    
        public virtual int AgregarAlumno(Nullable<decimal> a_ALUMNO_ID, string a_AP_PATERNO, string a_AP_MATERNO, string a_NOMBRE, string a_RUT_ALUMNO, Nullable<System.DateTime> a_FECHA_NAC, Nullable<decimal> a_APODERADO_APODERADO_ID, Nullable<decimal> a_CURSO_ID_CURSO)
        {
            var a_ALUMNO_IDParameter = a_ALUMNO_ID.HasValue ?
                new ObjectParameter("A_ALUMNO_ID", a_ALUMNO_ID) :
                new ObjectParameter("A_ALUMNO_ID", typeof(decimal));
    
            var a_AP_PATERNOParameter = a_AP_PATERNO != null ?
                new ObjectParameter("A_AP_PATERNO", a_AP_PATERNO) :
                new ObjectParameter("A_AP_PATERNO", typeof(string));
    
            var a_AP_MATERNOParameter = a_AP_MATERNO != null ?
                new ObjectParameter("A_AP_MATERNO", a_AP_MATERNO) :
                new ObjectParameter("A_AP_MATERNO", typeof(string));
    
            var a_NOMBREParameter = a_NOMBRE != null ?
                new ObjectParameter("A_NOMBRE", a_NOMBRE) :
                new ObjectParameter("A_NOMBRE", typeof(string));
    
            var a_RUT_ALUMNOParameter = a_RUT_ALUMNO != null ?
                new ObjectParameter("A_RUT_ALUMNO", a_RUT_ALUMNO) :
                new ObjectParameter("A_RUT_ALUMNO", typeof(string));
    
            var a_FECHA_NACParameter = a_FECHA_NAC.HasValue ?
                new ObjectParameter("A_FECHA_NAC", a_FECHA_NAC) :
                new ObjectParameter("A_FECHA_NAC", typeof(System.DateTime));
    
            var a_APODERADO_APODERADO_IDParameter = a_APODERADO_APODERADO_ID.HasValue ?
                new ObjectParameter("A_APODERADO_APODERADO_ID", a_APODERADO_APODERADO_ID) :
                new ObjectParameter("A_APODERADO_APODERADO_ID", typeof(decimal));
    
            var a_CURSO_ID_CURSOParameter = a_CURSO_ID_CURSO.HasValue ?
                new ObjectParameter("A_CURSO_ID_CURSO", a_CURSO_ID_CURSO) :
                new ObjectParameter("A_CURSO_ID_CURSO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarAlumno", a_ALUMNO_IDParameter, a_AP_PATERNOParameter, a_AP_MATERNOParameter, a_NOMBREParameter, a_RUT_ALUMNOParameter, a_FECHA_NACParameter, a_APODERADO_APODERADO_IDParameter, a_CURSO_ID_CURSOParameter);
        }
    
        public virtual int InsertarEncargado(Nullable<decimal> e_ENCARGADO_ID, string e_NOMBRE, string e_AP_PATERNO, string e_AP_MATERNO, string e_EMAIL, string e_PASSWORD, string e_TELEFONO, Nullable<decimal> e_AGENTE_AGENTE_ID, string e_USERNAME, Nullable<decimal> e_ROLES_ROLES_ID, Nullable<decimal> e_CURSO_ID_CURSO)
        {
            var e_ENCARGADO_IDParameter = e_ENCARGADO_ID.HasValue ?
                new ObjectParameter("E_ENCARGADO_ID", e_ENCARGADO_ID) :
                new ObjectParameter("E_ENCARGADO_ID", typeof(decimal));
    
            var e_NOMBREParameter = e_NOMBRE != null ?
                new ObjectParameter("E_NOMBRE", e_NOMBRE) :
                new ObjectParameter("E_NOMBRE", typeof(string));
    
            var e_AP_PATERNOParameter = e_AP_PATERNO != null ?
                new ObjectParameter("E_AP_PATERNO", e_AP_PATERNO) :
                new ObjectParameter("E_AP_PATERNO", typeof(string));
    
            var e_AP_MATERNOParameter = e_AP_MATERNO != null ?
                new ObjectParameter("E_AP_MATERNO", e_AP_MATERNO) :
                new ObjectParameter("E_AP_MATERNO", typeof(string));
    
            var e_EMAILParameter = e_EMAIL != null ?
                new ObjectParameter("E_EMAIL", e_EMAIL) :
                new ObjectParameter("E_EMAIL", typeof(string));
    
            var e_PASSWORDParameter = e_PASSWORD != null ?
                new ObjectParameter("E_PASSWORD", e_PASSWORD) :
                new ObjectParameter("E_PASSWORD", typeof(string));
    
            var e_TELEFONOParameter = e_TELEFONO != null ?
                new ObjectParameter("E_TELEFONO", e_TELEFONO) :
                new ObjectParameter("E_TELEFONO", typeof(string));
    
            var e_AGENTE_AGENTE_IDParameter = e_AGENTE_AGENTE_ID.HasValue ?
                new ObjectParameter("E_AGENTE_AGENTE_ID", e_AGENTE_AGENTE_ID) :
                new ObjectParameter("E_AGENTE_AGENTE_ID", typeof(decimal));
    
            var e_USERNAMEParameter = e_USERNAME != null ?
                new ObjectParameter("E_USERNAME", e_USERNAME) :
                new ObjectParameter("E_USERNAME", typeof(string));
    
            var e_ROLES_ROLES_IDParameter = e_ROLES_ROLES_ID.HasValue ?
                new ObjectParameter("E_ROLES_ROLES_ID", e_ROLES_ROLES_ID) :
                new ObjectParameter("E_ROLES_ROLES_ID", typeof(decimal));
    
            var e_CURSO_ID_CURSOParameter = e_CURSO_ID_CURSO.HasValue ?
                new ObjectParameter("E_CURSO_ID_CURSO", e_CURSO_ID_CURSO) :
                new ObjectParameter("E_CURSO_ID_CURSO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarEncargado", e_ENCARGADO_IDParameter, e_NOMBREParameter, e_AP_PATERNOParameter, e_AP_MATERNOParameter, e_EMAILParameter, e_PASSWORDParameter, e_TELEFONOParameter, e_AGENTE_AGENTE_IDParameter, e_USERNAMEParameter, e_ROLES_ROLES_IDParameter, e_CURSO_ID_CURSOParameter);
        }
    }
}
