using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAsp.Models
{
    public class Products
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public Categories categories { get; set; }
    }
}
