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
    
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            this.DETALLE_BOLETA = new HashSet<DETALLE_BOLETA>();
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
            this.DETALLE_ORDEN = new HashSet<DETALLE_ORDEN>();
            this.FOTO_PROD = new HashSet<FOTO_PROD>();
        }
    
        public decimal ID_PRODUCTO { get; set; }
        public string DESCRIPCION { get; set; }
        public string VENCIMIENTO { get; set; }
        public decimal PRECIO { get; set; }
        public decimal STOCK { get; set; }
        public decimal STOCK_CRITICO { get; set; }
        public decimal ID_USUARIO { get; set; }
        public decimal ID_FAMILIA { get; set; }
        public Nullable<decimal> ID_TIPO { get; set; }
        public Nullable<decimal> ACTIVO { get; set; }
    
        public virtual ICollection<DETALLE_BOLETA> DETALLE_BOLETA { get; set; }
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
        public virtual ICollection<DETALLE_ORDEN> DETALLE_ORDEN { get; set; }
        public virtual FAMILIA_PROD FAMILIA_PROD { get; set; }
        public virtual ICollection<FOTO_PROD> FOTO_PROD { get; set; }
        public virtual TIPO_PROD TIPO_PROD { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
