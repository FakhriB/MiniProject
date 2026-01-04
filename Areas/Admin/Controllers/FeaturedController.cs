using BookShop.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeaturedController : Controller
    {
        private readonly IFeaturedService _featuredService;
        public FeaturedController(IFeaturedService featuredService)
        {
            _featuredService = featuredService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var featureds = await _featuredService.GetAllAdminAsync();

            return View(featureds);
        }
    }
}
