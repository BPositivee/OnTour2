//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class AGENTE
    {
        public AGENTE()
        {
            this.CONTRATO = new HashSet<CONTRATO>();
            this.ENCARGADO = new HashSet<ENCARGADO>();
        }
    
        public decimal AGENTE_ID { get; set; }
        public string NOMBRE { get; set; }
        public string AP_PATERNO { get; set; }
        public string AP_MATERNO { get; set; }
        public string USERNAME { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public decimal ROLES_ROLES_ID { get; set; }
    
        public virtual ROLES ROLES { get; set; }
        public virtual ICollection<CONTRATO> CONTRATO { get; set; }
        public virtual ICollection<ENCARGADO> ENCARGADO { get; set; }
    }
}
