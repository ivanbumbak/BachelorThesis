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
    
    public partial class Godina
    {
        public int godinaID { get; set; }
        public Nullable<int> studijID { get; set; }
    
        public virtual Studij Studij { get; set; }
    }
}
