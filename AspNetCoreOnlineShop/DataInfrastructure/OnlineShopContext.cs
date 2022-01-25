using AspNetCoreOnlineShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreOnlineShop.DataInfrastructure
{
    public class OnlineShopContext : DbContext
    {
        public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; } 

    }
}
