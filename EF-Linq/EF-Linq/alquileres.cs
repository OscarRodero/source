//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Linq
{
    using System;
    using System.Collections.Generic;
    
    public partial class alquileres
    {
        public int codAlquiler { get; set; }
        public Nullable<System.DateTime> fechaAlquiler { get; set; }
        public int socio { get; set; }
        public int pelicula { get; set; }
        public Nullable<System.DateTime> fechaDevolucion { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        public virtual peliculas peliculas { get; set; }
        public virtual socios socios { get; set; }
    }
}
