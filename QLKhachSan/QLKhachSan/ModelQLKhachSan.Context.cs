﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKhachSan
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLKhachSanEntities : DbContext
    {
        public QLKhachSanEntities()
            : base("name=QLKhachSanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblctdatphong> tblctdatphong { get; set; }
        public virtual DbSet<tblctthuephong> tblctthuephong { get; set; }
        public virtual DbSet<tbldichvu> tbldichvu { get; set; }
        public virtual DbSet<tblhoadon> tblhoadon { get; set; }
        public virtual DbSet<tblkhachhang> tblkhachhang { get; set; }
        public virtual DbSet<tblloaiphong> tblloaiphong { get; set; }
        public virtual DbSet<tblnhanvien> tblnhanvien { get; set; }
        public virtual DbSet<tblphieudatphong> tblphieudatphong { get; set; }
        public virtual DbSet<tblphieuthuephong> tblphieuthuephong { get; set; }
        public virtual DbSet<tblphong> tblphong { get; set; }
        public virtual DbSet<tbltrangthaiphong> tbltrangthaiphong { get; set; }
        public virtual DbSet<tbluser> tbluser { get; set; }
        public virtual DbSet<tblvattu> tblvattu { get; set; }
    
        public virtual int CTDatPhong(string mapd, string maphong)
        {
            var mapdParameter = mapd != null ?
                new ObjectParameter("mapd", mapd) :
                new ObjectParameter("mapd", typeof(string));
    
            var maphongParameter = maphong != null ?
                new ObjectParameter("maphong", maphong) :
                new ObjectParameter("maphong", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CTDatPhong", mapdParameter, maphongParameter);
        }
    
        public virtual int ChangePass(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangePass", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<CheckLogin_Result> CheckLogin(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CheckLogin_Result>("CheckLogin", usernameParameter, passwordParameter);
        }
    
        public virtual int DatPhong(string mapd, string makh, string ngayden, string ngaydi, string sotiendat, string tinhtrang, string songuoi)
        {
            var mapdParameter = mapd != null ?
                new ObjectParameter("mapd", mapd) :
                new ObjectParameter("mapd", typeof(string));
    
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var ngaydenParameter = ngayden != null ?
                new ObjectParameter("ngayden", ngayden) :
                new ObjectParameter("ngayden", typeof(string));
    
            var ngaydiParameter = ngaydi != null ?
                new ObjectParameter("ngaydi", ngaydi) :
                new ObjectParameter("ngaydi", typeof(string));
    
            var sotiendatParameter = sotiendat != null ?
                new ObjectParameter("sotiendat", sotiendat) :
                new ObjectParameter("sotiendat", typeof(string));
    
            var tinhtrangParameter = tinhtrang != null ?
                new ObjectParameter("tinhtrang", tinhtrang) :
                new ObjectParameter("tinhtrang", typeof(string));
    
            var songuoiParameter = songuoi != null ?
                new ObjectParameter("songuoi", songuoi) :
                new ObjectParameter("songuoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DatPhong", mapdParameter, makhParameter, ngaydenParameter, ngaydiParameter, sotiendatParameter, tinhtrangParameter, songuoiParameter);
        }
    
        public virtual ObjectResult<DSHoaDon_Result> DSHoaDon()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DSHoaDon_Result>("DSHoaDon");
        }
    
        public virtual ObjectResult<DSKhachHang_Result> DSKhachHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DSKhachHang_Result>("DSKhachHang");
        }
    
        public virtual ObjectResult<dsKhachHang_SeclectAll_Result> dsKhachHang_SeclectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dsKhachHang_SeclectAll_Result>("dsKhachHang_SeclectAll");
        }
    
        public virtual ObjectResult<DSLoaiPhong_Result> DSLoaiPhong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DSLoaiPhong_Result>("DSLoaiPhong");
        }
    
        public virtual ObjectResult<DSPhieuDatPhong_Result> DSPhieuDatPhong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DSPhieuDatPhong_Result>("DSPhieuDatPhong");
        }
    
        public virtual ObjectResult<DSPhong_Result> DSPhong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DSPhong_Result>("DSPhong");
        }
    
        public virtual int NhanPhong(string maphong)
        {
            var maphongParameter = maphong != null ?
                new ObjectParameter("maphong", maphong) :
                new ObjectParameter("maphong", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("NhanPhong", maphongParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int SuaKH(string makh, string tenkh, string gioitinh, string ngaysinh, string cmnd, string diachi, string sdt, string ghichu, string makhcu)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var ngaysinhParameter = ngaysinh != null ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(string));
    
            var cmndParameter = cmnd != null ?
                new ObjectParameter("cmnd", cmnd) :
                new ObjectParameter("cmnd", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var ghichuParameter = ghichu != null ?
                new ObjectParameter("ghichu", ghichu) :
                new ObjectParameter("ghichu", typeof(string));
    
            var makhcuParameter = makhcu != null ?
                new ObjectParameter("makhcu", makhcu) :
                new ObjectParameter("makhcu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaKH", makhParameter, tenkhParameter, gioitinhParameter, ngaysinhParameter, cmndParameter, diachiParameter, sdtParameter, ghichuParameter, makhcuParameter);
        }
    
        public virtual ObjectResult<TimKH_Result> TimKH(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKH_Result>("TimKH", makhParameter);
        }
    
        public virtual ObjectResult<TimKHMa_Result> TimKHMa(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKHMa_Result>("TimKHMa", makhParameter);
        }
    
        public virtual ObjectResult<TimKHTen_Result> TimKHTen(string tenkh)
        {
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKHTen_Result>("TimKHTen", tenkhParameter);
        }
    
        public virtual ObjectResult<string> TimPhongN(string maphieu)
        {
            var maphieuParameter = maphieu != null ?
                new ObjectParameter("maphieu", maphieu) :
                new ObjectParameter("maphieu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TimPhongN", maphieuParameter);
        }
    
        public virtual ObjectResult<TimPhongTrong_Result> TimPhongTrong(string songuoi)
        {
            var songuoiParameter = songuoi != null ?
                new ObjectParameter("songuoi", songuoi) :
                new ObjectParameter("songuoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimPhongTrong_Result>("TimPhongTrong", songuoiParameter);
        }
    
        public virtual int ThemKH(string makh, string tenkh, string gioitinh, string ngaysinh, string cmnd, string diachi, string sdt, string ghichu)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var ngaysinhParameter = ngaysinh != null ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(string));
    
            var cmndParameter = cmnd != null ?
                new ObjectParameter("cmnd", cmnd) :
                new ObjectParameter("cmnd", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var ghichuParameter = ghichu != null ?
                new ObjectParameter("ghichu", ghichu) :
                new ObjectParameter("ghichu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemKH", makhParameter, tenkhParameter, gioitinhParameter, ngaysinhParameter, cmndParameter, diachiParameter, sdtParameter, ghichuParameter);
        }
    
        public virtual ObjectResult<ThongKe_Result> ThongKe()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ThongKe_Result>("ThongKe");
        }
    
        public virtual int UpdateDatPhong(string maphong)
        {
            var maphongParameter = maphong != null ?
                new ObjectParameter("maphong", maphong) :
                new ObjectParameter("maphong", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDatPhong", maphongParameter);
        }
    
        public virtual int XoaKH(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaKH", makhParameter);
        }
    }
}