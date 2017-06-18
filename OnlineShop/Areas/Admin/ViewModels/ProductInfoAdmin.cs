using ASP_OnlineShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.ViewModels
{
    public class ProductInfoAdmin
    {
        public SanPham SanPhamInfoAdmim { get; set; }
        public string TenLoaiSanPham { get; set; }
        public string TenNhaCungCap { get; set; }
        public string TenNhaSanXuat { get; set; }
    }
}