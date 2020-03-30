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
    
    public partial class Nguoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nguoi()
        {
            this.DangKyNghiPheps = new HashSet<DangKyNghiPhep>();
            this.DangKyTangCas = new HashSet<DangKyTangCa>();
            this.KhuonMats = new HashSet<KhuonMat>();
            this.NhatKies = new HashSet<NhatKy>();
            this.TheTus = new HashSet<TheTu>();
            this.VanTays = new HashSet<VanTay>();
        }
    
        public int MaNguoi { get; set; }
        public string MaDinhDanh { get; set; }
        public string HoTen { get; set; }
        public Nullable<int> PhongBan { get; set; }
        public Nullable<int> ChucVu { get; set; }
        public Nullable<int> KhuVuc { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<int> TrinhDo { get; set; }
        public string SoTheCanCuoc { get; set; }
        public Nullable<System.DateTime> NgayCapTCC { get; set; }
        public string NoiCapTCC { get; set; }
        public Nullable<int> DanToc { get; set; }
        public Nullable<int> TonGiao { get; set; }
        public Nullable<int> QuocTich { get; set; }
        public Nullable<int> TinhTrangHonNhan { get; set; }
        public string SoBangLaiXeMay { get; set; }
        public Nullable<System.DateTime> NgayCapBLXM { get; set; }
        public string NoiCapBLXM { get; set; }
        public string SoBangLaiOto { get; set; }
        public Nullable<System.DateTime> NgayCapBLXO { get; set; }
        public string NoiCapBLXO { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string DiaChiTamTru { get; set; }
        public string Email { get; set; }
        public string Zalo { get; set; }
        public string AnhDaiDien { get; set; }
        public Nullable<System.DateTime> NgayNhanViec { get; set; }
        public Nullable<System.DateTime> NgayThoiViec { get; set; }
        public Nullable<int> SuDungVanTay { get; set; }
        public Nullable<int> SuDungTheTu { get; set; }
        public Nullable<int> SuDungKhuonMat { get; set; }
        public Nullable<System.DateTime> ThoiGianDangKy { get; set; }
        public Nullable<System.DateTime> ThoiGianCapNhat { get; set; }
        public Nullable<int> GhiChu { get; set; }
        public Nullable<int> TrangThaiHoatDong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyNghiPhep> DangKyNghiPheps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyTangCa> DangKyTangCas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhuonMat> KhuonMats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhatKy> NhatKies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheTu> TheTus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VanTay> VanTays { get; set; }
    }
}
