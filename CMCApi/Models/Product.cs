using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMCApi.Models
{
    public class Product
    {
        public int product_id { get; set; }
        public string productname { get; set; }
        public string product_guid { get; set; }
        public decimal price { get; set; }
        public int available { get; set; }

    }
}