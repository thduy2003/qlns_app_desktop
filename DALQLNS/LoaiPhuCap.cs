//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALQLNS
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiPhuCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhuCap()
        {
            this.PhuCaps = new HashSet<PhuCap>();
        }
    
        public int MaLoaiPhuCap { get; set; }
        public string TenPhuCap { get; set; }
        public Nullable<double> SoTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhuCap> PhuCaps { get; set; }
    }
}