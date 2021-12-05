using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAsp.Models
{
    public class FavoritesItems
    {
        public int id { get; set; }

        public Products product { get; set; }

        public Favorites favorite { get; set; }
    }
}
