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
    [RoutePrefix("api/product/type")]
    public class APIProductTypeController : ApiController
    {
        // GET api/<controller>
        
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>
        [Route("")]
        [HttpGet]
        public Page<SanPham> Get(int id, int page=1)
        {
            return ProductBUS.ListProductType(page, 4, id);
        }

        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
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