
// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `ASP_OnlineShopConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=DESKTOP-L1A4B4I;Initial Catalog=OnlineShop;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `True`

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace ASP_OnlineShopConnection
{
	public partial class ASP_OnlineShopConnectionDB : Database
	{
		public ASP_OnlineShopConnectionDB() 
			: base("ASP_OnlineShopConnection")
		{
			CommonConstruct();
		}

		public ASP_OnlineShopConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			ASP_OnlineShopConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static ASP_OnlineShopConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new ASP_OnlineShopConnectionDB();
        }

		[ThreadStatic] static ASP_OnlineShopConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        
		public class Record<T> where T:new()
		{
			public static ASP_OnlineShopConnectionDB repo { get { return ASP_OnlineShopConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }
			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }
			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }
		}
	}
	

    
	[TableName("dbo.__MigrationHistory")]
	[PrimaryKey("MigrationId", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class __MigrationHistory : ASP_OnlineShopConnectionDB.Record<__MigrationHistory>  
    {
		[Column] public string MigrationId { get; set; }
		[Column] public string ContextKey { get; set; }
		[Column] public byte[] Model { get; set; }
		[Column] public string ProductVersion { get; set; }
	}
    
	[TableName("dbo.AspNetRoles")]
	[PrimaryKey("Id", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class AspNetRole : ASP_OnlineShopConnectionDB.Record<AspNetRole>  
    {
		[Column] public string Id { get; set; }
		[Column] public string Name { get; set; }
	}
    
	[TableName("dbo.AspNetUserClaims")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class AspNetUserClaim : ASP_OnlineShopConnectionDB.Record<AspNetUserClaim>  
    {
		[Column] public int Id { get; set; }
		[Column] public string UserId { get; set; }
		[Column] public string ClaimType { get; set; }
		[Column] public string ClaimValue { get; set; }
	}
    
	[TableName("dbo.AspNetUserLogins")]
	[PrimaryKey("LoginProvider", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class AspNetUserLogin : ASP_OnlineShopConnectionDB.Record<AspNetUserLogin>  
    {
		[Column] public string LoginProvider { get; set; }
		[Column] public string ProviderKey { get; set; }
		[Column] public string UserId { get; set; }
	}
    
	[TableName("dbo.AspNetUserRoles")]
	[PrimaryKey("UserId", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class AspNetUserRole : ASP_OnlineShopConnectionDB.Record<AspNetUserRole>  
    {
		[Column] public string UserId { get; set; }
		[Column] public string RoleId { get; set; }
	}
    
	[TableName("dbo.AspNetUsers")]
	[PrimaryKey("Id", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class AspNetUser : ASP_OnlineShopConnectionDB.Record<AspNetUser>  
    {
		[Column] public string Id { get; set; }
		[Column] public string Email { get; set; }
		[Column] public bool EmailConfirmed { get; set; }
		[Column] public string PasswordHash { get; set; }
		[Column] public string SecurityStamp { get; set; }
		[Column] public string PhoneNumber { get; set; }
		[Column] public bool PhoneNumberConfirmed { get; set; }
		[Column] public bool TwoFactorEnabled { get; set; }
		[Column] public DateTime? LockoutEndDateUtc { get; set; }
		[Column] public bool LockoutEnabled { get; set; }
		[Column] public int AccessFailedCount { get; set; }
		[Column] public string UserName { get; set; }
	}
    
	[TableName("dbo.BinhLuan")]
	[PrimaryKey("MaBinhLuan")]
	[ExplicitColumns]
    public partial class BinhLuan : ASP_OnlineShopConnectionDB.Record<BinhLuan>  
    {
		[Column] public int MaBinhLuan { get; set; }
		[Column] public string NoiDungBinhLuan { get; set; }
		[Column] public int? MaSanPham { get; set; }
		[Column] public string MaTaiKhoan { get; set; }
		[Column] public string TenTaiKhoan { get; set; }
		[Column] public int? TinhTrang { get; set; }
		[Column] public DateTime? Ngay { get; set; }
	}
    
	[TableName("dbo.ChiTietDonDatHang")]
	[PrimaryKey("MaDonDatHang")]
	[ExplicitColumns]
    public partial class ChiTietDonDatHang : ASP_OnlineShopConnectionDB.Record<ChiTietDonDatHang>  
    {
		[Column] public int MaDonDatHang { get; set; }
		[Column] public int MaSanPham { get; set; }
		[Column] public int SoLuong { get; set; }
		[Column] public int? DonGia { get; set; }
	}
    
	[TableName("dbo.ChiTietGioHang")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class ChiTietGioHang : ASP_OnlineShopConnectionDB.Record<ChiTietGioHang>  
    {
		[Column] public int Id { get; set; }
		[Column] public int SoLuong { get; set; }
		[Column] public int DonGia { get; set; }
		[Column] public int MaSanPham { get; set; }
		[Column] public string MaTaiKhoan { get; set; }
	}
    
	[TableName("dbo.ChiTietPhieuNhap")]
	[PrimaryKey("MaPhieuNhap", AutoIncrement=false)]
	[ExplicitColumns]
    public partial class ChiTietPhieuNhap : ASP_OnlineShopConnectionDB.Record<ChiTietPhieuNhap>  
    {
		[Column] public int MaPhieuNhap { get; set; }
		[Column] public int MaSanPham { get; set; }
		[Column] public int? DonGiaNhap { get; set; }
		[Column] public int? SoLuongNhap { get; set; }
	}
    
	[TableName("dbo.DonDatHang")]
	[PrimaryKey("MaDonHang")]
	[ExplicitColumns]
    public partial class DonDatHang : ASP_OnlineShopConnectionDB.Record<DonDatHang>  
    {
		[Column] public int MaDonHang { get; set; }
		[Column] public DateTime? NgayDat { get; set; }
		[Column] public string TinhTrangGiao { get; set; }
		[Column] public DateTime? NgayGiao { get; set; }
		[Column] public long? DaThanhToan { get; set; }
		[Column] public int? MaKhachHang { get; set; }
	}
    
	[TableName("dbo.GioHang")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class GioHang : ASP_OnlineShopConnectionDB.Record<GioHang>  
    {
		[Column] public int Id { get; set; }
		[Column] public string MaTaiKhoan { get; set; }
		[Column] public int MaSanPham { get; set; }
		[Column] public int SoLuong { get; set; }
	}
    
	[TableName("dbo.HinhAnh")]
	[PrimaryKey("MaHinhAnh")]
	[ExplicitColumns]
    public partial class HinhAnh : ASP_OnlineShopConnectionDB.Record<HinhAnh>  
    {
		[Column] public int MaHinhAnh { get; set; }
		[Column] public string TenHinhAnh { get; set; }
		[Column] public int? MaSanPham { get; set; }
	}
    
	[TableName("dbo.KhachHang")]
	[PrimaryKey("MaKhachHang")]
	[ExplicitColumns]
    public partial class KhachHang : ASP_OnlineShopConnectionDB.Record<KhachHang>  
    {
		[Column] public int MaKhachHang { get; set; }
		[Column] public string TenKhachHang { get; set; }
		[Column] public string DiaChi { get; set; }
		[Column] public string SoDienThoai { get; set; }
	}
    
	[TableName("dbo.LoaiSanPham")]
	[PrimaryKey("MaLoaiSanPham")]
	[ExplicitColumns]
    public partial class LoaiSanPham : ASP_OnlineShopConnectionDB.Record<LoaiSanPham>  
    {
		[Column] public int MaLoaiSanPham { get; set; }
		[Column] public string TenLoaiSanPham { get; set; }
		[Column] public string Icon { get; set; }
		[Column] public long? DaXoa { get; set; }
	}
    
	[TableName("dbo.NhaCungCap")]
	[PrimaryKey("MaNhaCungCap")]
	[ExplicitColumns]
    public partial class NhaCungCap : ASP_OnlineShopConnectionDB.Record<NhaCungCap>  
    {
		[Column] public int MaNhaCungCap { get; set; }
		[Column] public string TenNhaCungCap { get; set; }
		[Column] public string DiaChi { get; set; }
		[Column] public string Email { get; set; }
		[Column] public string DienThoai { get; set; }
	}
    
	[TableName("dbo.NhaSanXuat")]
	[PrimaryKey("MaNhaSanXuat")]
	[ExplicitColumns]
    public partial class NhaSanXuat : ASP_OnlineShopConnectionDB.Record<NhaSanXuat>  
    {
		[Column] public int MaNhaSanXuat { get; set; }
		[Column] public string TenNhaSanXuat { get; set; }
		[Column] public string ThongTin { get; set; }
		[Column] public string Logo { get; set; }
		[Column] public int? DaXoa { get; set; }
	}
    
	[TableName("dbo.PhieuNhap")]
	[PrimaryKey("MaPhieuNhap")]
	[ExplicitColumns]
    public partial class PhieuNhap : ASP_OnlineShopConnectionDB.Record<PhieuNhap>  
    {
		[Column] public int MaPhieuNhap { get; set; }
		[Column] public int? MaNhaCungCap { get; set; }
		[Column] public DateTime? NgayNhap { get; set; }
	}
    
	[TableName("dbo.SanPham")]
	[PrimaryKey("MaSanPham")]
	[ExplicitColumns]
    public partial class SanPham : ASP_OnlineShopConnectionDB.Record<SanPham>  
    {
		[Column] public int MaSanPham { get; set; }
		[Column] public string TenSanPham { get; set; }
		[Column] public int? GiaBan { get; set; }
		[Column] public int? SoLuong { get; set; }
		[Column] public int? LuotBinhChon { get; set; }
		[Column] public int? LuotBinhLuan { get; set; }
		[Column] public int? LuotXem { get; set; }
		[Column] public DateTime? NgayNhap { get; set; }
		[Column] public string HinhUrl { get; set; }
		[Column] public string MoTa { get; set; }
		[Column] public int? MaLoaiSanPham { get; set; }
		[Column] public int? MaNhaCungCap { get; set; }
		[Column] public int? MaNhaSanXuat { get; set; }
		[Column] public long? DaXoa { get; set; }
	}
    
	[TableName("dbo.V_GioHang")]
	[ExplicitColumns]
    public partial class V_GioHang : ASP_OnlineShopConnectionDB.Record<V_GioHang>  
    {
		[Column] public int Id { get; set; }
		[Column] public string MaTaiKhoan { get; set; }
		[Column] public int MaSanPham { get; set; }
		[Column] public int SoLuong { get; set; }
		[Column] public string TenSanPham { get; set; }
		[Column] public string HinhUrl { get; set; }
		[Column] public string MoTa { get; set; }
		[Column] public int? GiaBan { get; set; }
	}
}
