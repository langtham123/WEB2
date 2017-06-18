using ASP_OnlineShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.BUS
{
    public class ProductCartBUS
    {
        public static void AddToCart(int maSanPham, string maTaiKhoan)
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                var rs = db.Query<GioHang>("select * from GioHang where MaSanPham=@0", maSanPham);
                if (rs.Count() == 0)
                {
                    GioHang gh = new GioHang()
                    {
                        MaSanPham = maSanPham,
                        MaTaiKhoan = maTaiKhoan,
                        SoLuong = 1
                    };
                    db.Insert(gh);
                }
                else
                {
                    foreach (var item in rs)
                    {
                        UpdatePlus(item.Id, item.SoLuong);
                    }
                }
            }
        }

        public static IEnumerable<V_GioHang> ListProductCart(string maTaiKhoan)
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                return db.Query<V_GioHang>("select * from V_GioHang where MaTaiKhoan=@0", maTaiKhoan);
            }
        }

        public static void UpdateMinus(int id, int soLuong)
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                if(soLuong == 1)
                {
                    db.Execute("update GioHang set [SoLuong] = @0 where Id=@1", 1, id);
                }else
                {
                    db.Execute("update GioHang set [SoLuong] = @0 where Id=@1", soLuong - 1, id);
                }
                
            }
        }

        public static void UpdatePlus(int id, int soLuong)
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                db.Execute("update GioHang set [SoLuong] = @0 where Id=@1", soLuong + 1, id);
            }
        }

        public static void Delete(int id)
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                db.Execute("delete GioHang where Id=@0", id);
            }
        }

        public static void BuyNow(string mataikhoan)
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                db.Execute("EXEC usp_InsertChiTietDonHang @@mataikhoan = @0", mataikhoan);
                //db.Fetch<dynamic>("EXEC usp_InsertChiTietDonHang @0", mataikhoan);
            }
        }
    }
}