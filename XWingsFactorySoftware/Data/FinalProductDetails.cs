//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XWingsFactorySoftware.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class FinalProductDetails
    {
        public short idFinalProductDetail { get; set; }
        public short idFinalProduct { get; set; }
        public short idIntermediateProduct { get; set; }
    
        public virtual FinalProduct FinalProduct { get; set; }
        public virtual IntermediateProduct IntermediateProduct { get; set; }
    }
}
