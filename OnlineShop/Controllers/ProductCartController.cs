using OnlineShop.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace OnlineShop.Controllers
{
    [Authorize]
    public class ProductCartController : Controller
    {
        // GET: ProductCart
        public ActionResult Index()
        {
            return View(ProductCartBUS.ListProductCart(User.Identity.GetUserId()));
        }

        [HttpGet]
        public ActionResult AddToCart(int maSanPham)
        {
            var maTaiKhoan = User.Identity.GetUserId();
            ProductCartBUS.AddToCart(maSanPham, maTaiKhoan);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdatePlus(int id, int soLuong)
        {
            ProductCartBUS.UpdatePlus(id, soLuong);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateMinus(int id, int soLuong)
        {
            ProductCartBUS.UpdateMinus(id, soLuong);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            ProductCartBUS.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult BuyNow()
        {
            var mataikhoan = User.Identity.GetUserId();
            ProductCartBUS.BuyNow(mataikhoan);
            return RedirectToAction("Index");
        }
    }
}