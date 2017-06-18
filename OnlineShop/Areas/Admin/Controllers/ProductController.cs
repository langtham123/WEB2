using ASP_OnlineShopConnection;
using OnlineShop.Areas.Admin.BUS;
using OnlineShop.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            var listProduct = ProductBUS.List();
            return View(listProduct);
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiSanPham = new SelectList(ProductBUS.GetListCategogy(), "MaLoaiSanPham", "TenLoaiSanPham");
            ViewBag.MaNhaCungCap = new SelectList(ProductBUS.GetListSupplier(), "MaNhaCungCap", "TenNhaCungCap");
            ViewBag.MaNhaSanXuat = new SelectList(ProductBUS.GetListManufacturer(), "MaNhaSanXuat", "TenNhaSanXuat");
            return View();
        }

        //POST: Admin/Product/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(SanPham sp, HinhAnh ha)
        {
            try
            {
                // TODO: Add update logic here
                using (var db = new ASP_OnlineShopConnectionDB())
                {

                if (HttpContext.Request.Files.Count > 0)
                {
                    if(HttpContext.Request.Files.Count != 3)
                    {
                           return Content("<script language='javascript' type='text/javascript'>alert('Vui lòng chọn 3 hình sp!');</script>");
                     }
                    else
                    {
                            var hpf = HttpContext.Request.Files[0];
                            if (hpf.ContentLength > 0)
                            {
                                string fileName = Guid.NewGuid().ToString();
                                string nameImage = fileName + ".jpg";
                                string fullPathWithFileName = "/images/product/" + nameImage;
                                hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                                sp.HinhUrl = nameImage;
                            }
                            db.Insert(sp);
                            var query = db.Query<SanPham>("SELECT * FROM SanPham ORDER BY MaSanPham DESC");
                            var id = query.First().MaSanPham;
                            for (int i = 0; i < 3; i++)
                            {
                                var hpf2 = HttpContext.Request.Files[i];
                                if (hpf2.ContentLength > 0)
                                {
                                    string fileName = Guid.NewGuid().ToString();
                                    string nameImage = fileName + ".jpg";
                                    string fullPathWithFileName = "/images/products/" + nameImage;
                                    hpf2.SaveAs(Server.MapPath(fullPathWithFileName));
                                    ha.TenHinhAnh = nameImage;
                                    ha.MaSanPham = id;
                                    db.Insert(ha);
                                }
                            }
                        }
                }

                //db.Update<SanPham>("SET TenSanPham=@0, GiaBan=@1, SoLuong=@2 WHERE MaSanPham=@3", sp.TenSanPham, sp.GiaBan, sp.SoLuong, id);
            }
                //Content("<script language='javascript' type='text/javascript'>alert('Thêm thành công!');</script>");
                return RedirectToAction("Index");
        }
        catch
        {
                //Content("<script language='javascript' type='text/javascript'>alert('Xảy ra lỗi!');</script>");
                return View(); //đây
        }
    }


        //public ActionResult Edit(int id)
        //{
        //    var sp = ProductBUS.ProductDetail(id);
        //    return View(sp);
        //}

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.MaLoaiSanPham = new SelectList(ProductBUS.GetListCategogy(), "MaLoaiSanPham", "TenLoaiSanPham");
            ViewBag.MaNhaCungCap = new SelectList(ProductBUS.GetListSupplier(), "MaNhaCungCap", "TenNhaCungCap");
            ViewBag.MaNhaSanXuat = new SelectList(ProductBUS.GetListManufacturer(), "MaNhaSanXuat", "TenNhaSanXuat");
            var sp = ProductBUS.ProductDetail(id);
            return View(sp);
        }

        // POST: Admin/Product/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, SanPham sp)
        {
            // TODO: Add update logic here
            using (var db = new ASP_OnlineShopConnectionDB())
            {
                db.Update<SanPham>("SET TenSanPham=@0, GiaBan=@1, SoLuong=@2, NgayNhap=@3, HinhUrl=@4, MoTa=@5, DaXoa=@6 WHERE MaSanPham=@7", sp.TenSanPham, sp.GiaBan, sp.SoLuong, sp.NgayNhap, sp.HinhUrl, sp.MoTa, sp.DaXoa, id);
            }
            return RedirectToAction("Index");
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            var info = new ProductInfoAdmin()
            {
                SanPhamInfoAdmim = ProductBUS.ProductDetail(id),
                TenLoaiSanPham = ProductBUS.GetTenLoaiSanPham(id),
                TenNhaCungCap = ProductBUS.GetTenNhaCungCap(id),
                TenNhaSanXuat = ProductBUS.GetTenNhaSanXuat(id)
            };
            return View(info);
            //var sp = ProductBUS.ProductDetail(id);
            //return View(sp);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (var db = new ASP_OnlineShopConnectionDB())
                {
                    //db.Delete("SanPham", id.ToString(), sp);
                    db.Update<SanPham>("SET DaXoa=1 WHERE MaSanPham=@0", id);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
