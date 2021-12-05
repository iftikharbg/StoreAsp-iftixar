using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAsp.Models
{
    public class Orders
    {
        public int id { get; set; }

        public Users users { get; set; }

        public Products products { get; set; }
    }
}
