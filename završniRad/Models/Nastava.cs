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
    
    public partial class Nastava
    {
        public System.DateTime datumNastave { get; set; }
        public Nullable<int> KolegijID { get; set; }
        public Nullable<int> tipID { get; set; }
        public Nullable<int> ProfID { get; set; }
        public Nullable<int> JMBAG { get; set; }
    
        public virtual Kolegij Kolegij { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Student Student { get; set; }
        public virtual TipNastave TipNastave { get; set; }
    }
}
