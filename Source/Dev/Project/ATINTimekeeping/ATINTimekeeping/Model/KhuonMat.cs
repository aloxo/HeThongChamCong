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
    
    public partial class KhuonMat
    {
        public int MaKhuonMat { get; set; }
        public int MaNguoi { get; set; }
        public string AnhKhuonMat { get; set; }
        public byte[] ThuocTinhKhuonMat { get; set; }
        public System.DateTime ThoiGianDangKy { get; set; }
        public int TrangThai { get; set; }
    
        public virtual Nguoi Nguoi { get; set; }
    }
}
