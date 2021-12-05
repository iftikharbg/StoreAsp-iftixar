using Microsoft.AspNetCore.Mvc;
using StoreAsp.DAL;
using StoreAsp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAsp.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext context { get; set; }
        public HomeController (AppDbContext c)
        {
            context = c;
        }
        public IActionResult Index()
        {
            var users = context.users.ToList();

            var roles = context.roles.ToList();

            var categories = context.categories.ToList();

            var products = context.products.ToList();

            HomeIndexViewModel model = new HomeIndexViewModel
            {
                users = users,
                roles = roles,
                categories = categories,
                products = products

            };
            return View(model);
        }
    }
}
