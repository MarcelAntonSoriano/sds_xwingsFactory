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
    
    public partial class FinalProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinalProduct()
        {
            this.FinalProductDetails = new HashSet<FinalProductDetails>();
        }
    
        public short idFinalProduct { get; set; }
        public short idReference { get; set; }
        public string codeProduct { get; set; }
        public short idStatus { get; set; }
        public short idLOPDetail { get; set; }
    
        public virtual LOPDetails LOPDetails { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinalProductDetails> FinalProductDetails { get; set; }
    }
}
