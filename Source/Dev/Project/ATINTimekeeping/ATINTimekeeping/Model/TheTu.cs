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
    
    public partial class TheTu
    {
        public int MaTheTu { get; set; }
        public int MaNguoi { get; set; }
        public Nullable<int> LoaiTheTu { get; set; }
        public byte[] ThuocTinhThe { get; set; }
        public System.DateTime ThoiGianDangKy { get; set; }
        public int TrangThai { get; set; }
    
        public virtual Nguoi Nguoi { get; set; }
    }
}