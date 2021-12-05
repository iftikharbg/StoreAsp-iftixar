using Microsoft.EntityFrameworkCore;
using StoreAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAsp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Categories> categories { get; set; }

        public DbSet<Products> products { get; set; }
        public DbSet<Orders> orders { get; set; }

        public DbSet<Baskets> baskets { get; set; }

        public DbSet<Favorites> favorites { get; set; }

        public DbSet<FavoritesItems> favoritesItems { get; set; }
        public DbSet<BasketItems> basketItems { get; set; }

    }
}
