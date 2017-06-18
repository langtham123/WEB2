using ASP_OnlineShopConnection;
using OnlineShop.ViewModels;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.BUS
{
    public class ProductBUS
    {
        public static IEnumerable<SanPham> List()
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.Query<SanPham>("SELECT * FROM SanPham WHERE DaXoa=0");
        }

        public static Page<SanPham> ListProduct(int pageNumber, int itemPerPage)
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.Page<SanPham>(pageNumber, itemPerPage, "SELECT * FROM SanPham");
        }

        public static Page<SanPham> ListProductType(int pageNumber, int itemPerPage, int id)
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.Page<SanPham>(pageNumber, itemPerPage, "SELECT * FROM SanPham WHERE MaLoaiSanPham=" + id);
        }

        public static Page<SanPham> ListProducer(int pageNumber, int itemPerPage, int id)
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.Page<SanPham>(pageNumber, itemPerPage, "SELECT * FROM SanPham WHERE MaNhaSanXuat=" + id);
        }

        public static SanPham ProductDetail(int id)
        {
            var db = new ASP_OnlineShopConnectionDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0", id);
        }

        public static IEnumerable<HinhAnh> listHinhAnh(int id)
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                return db.Query<HinhAnh>("Select * from HinhAnh where MaSanPham = @0", id);
            }
        }
    }
}