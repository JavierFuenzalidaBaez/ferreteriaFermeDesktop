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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.BOLETA = new HashSet<BOLETA>();
            this.CLIENTE = new HashSet<CLIENTE>();
            this.DOMICILIO = new HashSet<DOMICILIO>();
            this.EMPLEADO = new HashSet<EMPLEADO>();
            this.FACTURA = new HashSet<FACTURA>();
            this.ORDEN_COMPRA = new HashSet<ORDEN_COMPRA>();
            this.PRODUCTO = new HashSet<PRODUCTO>();
            this.PROVEEDOR = new HashSet<PROVEEDOR>();
        }
    
        public decimal ID_USUARIO { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
    
        public virtual ICollection<BOLETA> BOLETA { get; set; }
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual ICollection<DOMICILIO> DOMICILIO { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADO { get; set; }
        public virtual ICollection<FACTURA> FACTURA { get; set; }
        public virtual ICollection<ORDEN_COMPRA> ORDEN_COMPRA { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
        public virtual ICollection<PROVEEDOR> PROVEEDOR { get; set; }
    }
}
