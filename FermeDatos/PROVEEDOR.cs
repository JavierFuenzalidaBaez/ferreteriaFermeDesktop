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
    
    public partial class PROVEEDOR
    {
        public decimal ID_PROVEEDOR { get; set; }
        public string RUT_PROVEE { get; set; }
        public string NOMBRE { get; set; }
        public decimal CELULAR { get; set; }
        public decimal ID_USUARIO { get; set; }
        public decimal ID_RUBRO { get; set; }
    
        public virtual RUBRO RUBRO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}