//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PathOrder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacturaMercaderia
    {
        public int IdFacturaMercaderia { get; set; }
        public int IdMercaderia { get; set; }
        public int IdFactura { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Mercaderia Mercaderia { get; set; }
    }
}