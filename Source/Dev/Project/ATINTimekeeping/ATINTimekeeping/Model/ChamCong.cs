//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATINTimekeeping.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChamCong
    {
        public int MaChamCong { get; set; }
        public int MaNhanVien { get; set; }
        public Nullable<int> MaDinhDanh { get; set; }
        public System.DateTime NgayChamCong { get; set; }
        public int MaCaLamViec { get; set; }
        public Nullable<System.DateTime> GioVaoDauTien { get; set; }
        public Nullable<System.DateTime> GioRaCuoiCung { get; set; }
        public double SoGioLamViec { get; set; }
        public double SoCongLamViec { get; set; }
        public int SoPhutDiTre { get; set; }
        public int SoPhutVeSom { get; set; }
        public double SoPhutBuGio { get; set; }
        public int TangCa1 { get; set; }
        public int TangCa2 { get; set; }
        public int TangCa3 { get; set; }
        public double TongSoGioLamViec { get; set; }
        public double TongSoCongLamViec { get; set; }
    }
}
