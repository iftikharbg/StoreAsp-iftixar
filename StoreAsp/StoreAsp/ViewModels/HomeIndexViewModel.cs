using StoreAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAsp.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Users> users { get; set; }
        public List<Roles> roles { get; set; }
        public List<Categories> categories { get; set; }
        public List<Products> products { get; set; }
    }
}
