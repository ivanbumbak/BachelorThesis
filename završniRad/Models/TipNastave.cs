//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace završniRad.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipNastave
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipNastave()
        {
            this.Nastavas = new HashSet<Nastava>();
        }
    
        public int tipID { get; set; }
        public string Tip { get; set; }
        public int BrojSati { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nastava> Nastavas { get; set; }
    }
}
