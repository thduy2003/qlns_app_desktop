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
    
    public partial class LichLamViec
    {
        public int MaLichLamViec { get; set; }
        public Nullable<int> MaLoaiCa { get; set; }
        public string Thu { get; set; }
        public Nullable<int> MaNhanVien { get; set; }
    
        public virtual LoaiCa LoaiCa { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}