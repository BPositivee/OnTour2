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
    
    public partial class ACTIVIDAD_TOUR
    {
        public ACTIVIDAD_TOUR()
        {
            this.CONTRATO = new HashSet<CONTRATO>();
        }
    
        public decimal ACTIVIDAD_ID { get; set; }
        public string NOMBRE_ACTIVIDAD { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<CONTRATO> CONTRATO { get; set; }
    }
}
