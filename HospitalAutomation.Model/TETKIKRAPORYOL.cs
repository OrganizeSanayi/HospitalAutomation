//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalAutomation.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TETKIKRAPORYOL
    {
        public TETKIKRAPORYOL()
        {
            this.TETKIKRAPORRESIMLERs = new HashSet<TETKIKRAPORRESIMLER>();
            this.DOSYALAR = new HashSet<DOSYALAR>();
        }
    
        public int TetkikRaporYolID { get; set; }
        public string TetkikRaporYolKayit { get; set; }
    
        public virtual ICollection<TETKIKRAPORRESIMLER> TETKIKRAPORRESIMLERs { get; set; }
        public virtual ICollection<DOSYALAR> DOSYALAR { get; set; }
    }
}
