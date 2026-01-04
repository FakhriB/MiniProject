using System.Diagnostics;
using BookShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        


        public async Task<IActionResult> Index()
        {
            
             


            return View();
        }

      
    }
}
