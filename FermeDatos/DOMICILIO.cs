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
    
    public partial class DOMICILIO
    {
        public decimal ID_DOMICILIO { get; set; }
        public string REGION { get; set; }
        public string COMUNA { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<decimal> ID_USUARIO { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}