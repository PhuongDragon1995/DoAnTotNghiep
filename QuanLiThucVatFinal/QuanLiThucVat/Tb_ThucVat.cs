//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiThucVat
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_ThucVat
    {
        public int ID { get; set; }
        public string TenVietNam { get; set; }
        public string TenLaTinh { get; set; }
        public string MoTa { get; set; }
        public Nullable<double> DoDayLa { get; set; }
        public Nullable<double> DoDayVo { get; set; }
        public Nullable<double> LuongNuocTrongLa { get; set; }
        public Nullable<double> LuongNuocTrongVo { get; set; }
        public Nullable<double> LuongTroThoTrongLa { get; set; }
        public Nullable<double> LuongTroThoTrongVo { get; set; }
        public Nullable<double> ThoiGianChayTrenLa { get; set; }
        public Nullable<double> ThoiGianChayTrenVo { get; set; }
        public Nullable<int> IDKhaNangSinhTruong { get; set; }
        public Nullable<int> IDKhaNangTaiSinh { get; set; }
        public Nullable<int> IDGiaTriKinhTe { get; set; }
        public Nullable<int> IDHInhAnh { get; set; }
        public Nullable<int> IDHo { get; set; }
    
        public virtual Tb_GiaTriKinhTe Tb_GiaTriKinhTe { get; set; }
        public virtual Tb_HinhAnh Tb_HinhAnh { get; set; }
        public virtual Tb_Ho Tb_Ho { get; set; }
        public virtual Tb_Ho Tb_Ho1 { get; set; }
        public virtual Tb_KhaNangSinhTruong Tb_KhaNangSinhTruong { get; set; }
        public virtual Tb_KhaNangTaiSinh Tb_KhaNangTaiSinh { get; set; }
    }
}