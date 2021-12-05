using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAsp.Models
{
    public class BasketItems
    {
        public int id { get; set; }

        public  Products product { get; set; }

        public Baskets basket { get; set; }
    }
}
