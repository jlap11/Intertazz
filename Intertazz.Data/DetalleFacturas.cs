//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intertazz.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFacturas
    {
        public long IdDetalleFacturas { get; set; }
        public double ValorDetalle { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Precio Precio { get; set; }
        public virtual Facturas Facturas { get; set; }
    }
}
