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
    
    public partial class DESTINO
    {
        public DESTINO()
        {
            this.CONTRATO = new HashSet<CONTRATO>();
            this.TOUR = new HashSet<TOUR>();
        }
    
        public decimal DESTINO_ID { get; set; }
        public string CIUDAD { get; set; }
        public string PAIS { get; set; }
    
        public virtual ICollection<CONTRATO> CONTRATO { get; set; }
        public virtual ICollection<TOUR> TOUR { get; set; }
    }
}
