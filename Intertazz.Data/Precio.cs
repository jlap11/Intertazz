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
    
    public partial class Precio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Precio()
        {
            this.Activo = true;
            this.DetalleVentas = new HashSet<DetalleFacturas>();
        }
    
        public int IdPrecio { get; set; }
        public System.DateTime Fecha { get; set; }
        public bool Activo { get; set; }
    
        public virtual Producto Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFacturas> DetalleVentas { get; set; }
    }
}
