//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FermeDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class METODO_PAGO
    {
        public METODO_PAGO()
        {
            this.BOLETA = new HashSet<BOLETA>();
            this.FACTURA = new HashSet<FACTURA>();
        }
    
        public decimal ID_PAGO { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<BOLETA> BOLETA { get; set; }
        public virtual ICollection<FACTURA> FACTURA { get; set; }
    }
}