using ASP_OnlineShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.BUS
{
    public class BinhLuanBUS
    {
        public static void Them(string NoiDungBinhLuan, int? MaSanPham, string MaTaiKhoan, string TenTaiKhoan)
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                //BinhLuan bl = new BinhLuan();
                //bl.MaSanPham = MaSanPham;
                //bl.MaTaiKhoan = MaTaiKhoan;
                //bl.NoiDungBinhLuan = NoiDung;
                //bl.MaThanhVien = 2;
                db.Execute("INSERT INTO [dbo].[BinhLuan] ([NoiDungBinhLuan], [MaSanPham],[MaTaiKhoan],[TenTaiKhoan]) VALUES(@0,@1,@2,@3)", NoiDungBinhLuan, MaSanPham, MaTaiKhoan, TenTaiKhoan);
            }
        }

        public static IEnumerable<BinhLuan> DanhSach(int MaSanPham)
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                return db.Query<BinhLuan>("select * from BinhLuan where MaSanPham = @0 order by Ngay desc", MaSanPham);
            }
        }
    }
}