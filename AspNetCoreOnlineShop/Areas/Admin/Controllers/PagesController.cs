using AspNetCoreOnlineShop.DataInfrastructure;
using AspNetCoreOnlineShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreOnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesController : Controller
    {
        private readonly OnlineShopContext context;
        public PagesController(OnlineShopContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            IQueryable<Page> pages = from p in context.Pages orderby p.Sorting select p;

            List<Page> pagesList = await pages.ToListAsync();

            return View(pagesList);
        }
    }
}

