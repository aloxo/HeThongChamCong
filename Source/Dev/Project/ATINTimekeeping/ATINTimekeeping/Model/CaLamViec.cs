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
    
    public partial class CaLamViec
    {
        public int MaCaLamViec { get; set; }
        public string TenCaLamViec { get; set; }
        public System.TimeSpan GioVaoLamViec { get; set; }
        public System.TimeSpan GioBatDauGiaiLao { get; set; }
        public System.TimeSpan GioKetThucGiaiLao { get; set; }
        public int DiemCong { get; set; }
        public System.TimeSpan GioBatDauVaoDuocTinhCa { get; set; }
        public System.TimeSpan GioKetThucDuocTinhCa { get; set; }
        public int KhongCoGioVao { get; set; }
        public int KhongCoGioRa { get; set; }
        public Nullable<int> TruGioDiTre { get; set; }
        public Nullable<int> ThoiGianDiTreChoPhep { get; set; }
        public Nullable<int> TinhThoiGianDiTre { get; set; }
        public Nullable<int> TruGioVeSom { get; set; }
        public Nullable<int> ThoiGianVeSomChoPhep { get; set; }
        public Nullable<int> TinhThoiGianVeSom { get; set; }
        public Nullable<int> MucTangCaHienTai { get; set; }
        public Nullable<int> MucTangCaCuoiTuan { get; set; }
        public Nullable<int> MucTangCaNgayLe { get; set; }
        public Nullable<int> TangCaTruocGioLamViec { get; set; }
        public Nullable<int> TangCaSauGioLamViec { get; set; }
        public Nullable<int> TongGioLamViecSeTinhTangCa { get; set; }
        public Nullable<int> GioiHanTangCaMucMot { get; set; }
        public Nullable<int> GioiHanTangCaMucHai { get; set; }
        public Nullable<int> GioiHanToiDaTangCaTruocGioLamViec { get; set; }
        public Nullable<int> GioiHanToiDaTangCaSauGioLamViec { get; set; }
        public Nullable<System.TimeSpan> TachGioCaDemTu { get; set; }
        public Nullable<System.TimeSpan> TachGioCaDemDen { get; set; }
        public Nullable<int> BuGioDiTreBangVeTre { get; set; }
        public Nullable<int> BuGioVeSomBangDiSom { get; set; }
    }
}
