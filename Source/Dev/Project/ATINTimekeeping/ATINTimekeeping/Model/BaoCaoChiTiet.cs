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
    
    public partial class BaoCaoChiTiet
    {
        public System.Guid id { get; set; }
        public Nullable<System.DateTime> reportDate { get; set; }
        public Nullable<System.DateTime> checkInTime { get; set; }
        public Nullable<System.DateTime> checkOutTime { get; set; }
        public Nullable<int> status { get; set; }
    }
}
