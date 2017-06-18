using ASP_OnlineShopConnection;
using OnlineShop.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace OnlineShop.Controllers
{
    public class APIBinhLuanController : ApiController
    {
        // GET: api/APIBinhLuan
        public IEnumerable<BinhLuan> Get(int MaSanPham)
        {
            return BinhLuanBUS.DanhSach(MaSanPham);
        }

        // GET: api/APIBinhLuan/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/APIBinhLuan
        public void Post([FromBody]BinhLuan bl)
        {
            BinhLuanBUS.Them(bl.NoiDungBinhLuan, bl.MaSanPham, User.Identity.GetUserId(), User.Identity.Name);
        }

        // PUT: api/APIBinhLuan/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/APIBinhLuan/5
        public void Delete(int id)
        {
        }
    }
}
