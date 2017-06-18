using ASP_OnlineShopConnection;
using OnlineShop.BUS;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineShop.Controllers
{
    [RoutePrefix("api/product")]
    public class APIProductController : ApiController
    {
        // GET api/<controller>
        [Route("")]
        [HttpGet]
        public Page<SanPham> Get(int page = 1)
        {
            return ProductBUS.ListProduct(page, 4);
        }

        //GET api/<controller>/5
        //public Page<SanPham> Get(int id, int page = 1)
        //{
        //    return ProductBUS.ListProductType(1, 4, id);
        //}

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}