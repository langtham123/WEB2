using ASP_OnlineShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.ViewModels
{
    public class ProductInfo
    {
        public SanPham sanPham { get; set; }
        public IEnumerable<HinhAnh> arrHinhAnh { get; set; }
    }
}