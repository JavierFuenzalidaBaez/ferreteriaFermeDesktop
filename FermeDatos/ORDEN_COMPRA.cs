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
    
    public partial class ORDEN_COMPRA
    {
        public ORDEN_COMPRA()
        {
            this.DETALLE_ORDEN = new HashSet<DETALLE_ORDEN>();
        }
    
        public decimal ID_ORDEN { get; set; }
        public System.DateTime FECHA_INGRESO { get; set; }
        public Nullable<decimal> ID_USUARIO { get; set; }
        public Nullable<decimal> ID_ESTADO { get; set; }
        public Nullable<decimal> ID_PROVEEDOR { get; set; }
    
        public virtual ICollection<DETALLE_ORDEN> DETALLE_ORDEN { get; set; }
        public virtual ESTADO_ORDEN ESTADO_ORDEN { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
