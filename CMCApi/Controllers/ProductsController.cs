using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using CMCApi.Models;
using System.IO;
using Newtonsoft.Json;

namespace CMCApi.Controllers
{
    public class ProductsController : ApiController
    {
        [HttpGet]
        [Route("api/products/")]
        public IHttpActionResult GetAllProducts()
        {
            using (StreamReader r = new StreamReader(HttpContext.Current.Server.MapPath(@"~/App_Data/productdata.json")))
            {
                string json = r.ReadToEnd();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);
                return Ok(products);
            }
        }

        [HttpGet]
        [Route("api/products/shipping/{centstotal}")]
        public IHttpActionResult CalculateShipping(int centstotal)
        {
            int shippingcents = 1000;
            if (centstotal >= 5000)
                shippingcents = 2000;
            return Ok(shippingcents);
        }

        [HttpPost]
        [Route("api/products/placeorder/")]
        public IHttpActionResult PlaceOrder([FromBody] List<Product> products)
        {
            if (products.Count() == 0)
                return NotFound();
            else
            {
                foreach (Product product in products)
                {
                    //do something
                }
                return Ok();
            }
        }



    }
}
