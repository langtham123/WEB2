using OnlineShop.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult ProductType()
        {
            return View(ProductTypeBUS.ListProductType());
        }

        public ActionResult Producer()
        {
            return View(ProductTypeBUS.ListProducer());
        }
    }
}