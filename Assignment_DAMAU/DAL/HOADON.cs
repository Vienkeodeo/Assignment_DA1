//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment_DAMAU.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.HOADONCHITIETs = new HashSet<HOADONCHITIET>();
        }
    
        public string MA_HOADON { get; set; }
        public Nullable<System.DateTime> NGAYLAP { get; set; }
        public string MA_NV { get; set; }
        public string MA_KHUYENMAI { get; set; }
        public string MA_KHACHHANG { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public Nullable<decimal> TONGTIEN { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual KHUYENMAI KHUYENMAI { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONCHITIET> HOADONCHITIETs { get; set; }
    }
}
