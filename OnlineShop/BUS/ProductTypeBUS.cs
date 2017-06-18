using ASP_OnlineShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.BUS
{
    public class ProductTypeBUS
    {
        public static IEnumerable<LoaiSanPham> ListProductType()
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                return db.Query<LoaiSanPham>("select * from LoaiSanPham where DaXoa=0");
            }
        }

        public static IEnumerable<NhaSanXuat> ListProducer()
        {
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                return db.Query<NhaSanXuat>("select * from NhaSanXuat where DaXoa=0");
            }
        }
    }
}