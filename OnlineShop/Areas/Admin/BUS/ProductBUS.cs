using ASP_OnlineShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.BUS
{
    public class ProductBUS
    {
        public static IEnumerable<SanPham> List()
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.Query<SanPham>("SELECT * FROM SanPham");
        }

        public static SanPham ProductDetail(int id)
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0", id);
        }

        public static string GetTenLoaiSanPham(int id)
        {
            var db = new ASP_OnlineShopConnectionDB();
            var Ma = db.SingleOrDefault<SanPham>("select MaLoaiSanPham from SanPham where MaSanPham = @0", id).MaLoaiSanPham;
            return db.SingleOrDefault<LoaiSanPham>("select TenLoaiSanPham from LoaiSanPham where MaLoaiSanPham = @0", Ma).TenLoaiSanPham;
        }

        public static string GetTenNhaCungCap(int id)
        {
            var db = new ASP_OnlineShopConnectionDB();
            var Ma = db.SingleOrDefault<SanPham>("select MaNhacungCap from SanPham where MaSanPham = @0", id).MaNhaCungCap;
            return db.SingleOrDefault<NhaCungCap>("select TenNhaCungCap from NhaCungCap where MaNhaCungCap = @0", Ma).TenNhaCungCap;
        }

        public static string GetTenNhaSanXuat(int id)
        {
            var db = new ASP_OnlineShopConnectionDB();
            var Ma = db.SingleOrDefault<SanPham>("select MaNhaSanXuat from SanPham where MaSanPham = @0", id).MaNhaSanXuat;
            return db.SingleOrDefault<NhaSanXuat>("select TenNhaSanXuat from NhaSanXuat where MaNhaSanXuat = @0", Ma).TenNhaSanXuat;
        }

        public static IEnumerable<LoaiSanPham> GetListCategogy()
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.Query<LoaiSanPham>("Select * FROM LoaiSanPham");
        }

        public static IEnumerable<NhaCungCap> GetListSupplier()
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.Query<NhaCungCap>("Select * FROM NhaCungCap");
        }

        public static IEnumerable<NhaSanXuat> GetListManufacturer()
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.Query<NhaSanXuat>("Select * FROM NhaSanXuat");
        }
    }
}