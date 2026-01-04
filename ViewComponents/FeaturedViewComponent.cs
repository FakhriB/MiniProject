using BookShop.Services.Interfaces;
using BookShop.ViewModels.Featured;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.ViewComponents
{
    public class FeaturedViewComponent : ViewComponent
    {
        private readonly IFeaturedService _featuredService;
        public FeaturedViewComponent(IFeaturedService featuredService)
        {
            _featuredService = featuredService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<FeaturedUIVM> featureds = await _featuredService.GetAllAsync();


            return View(featureds);
        }
    }
}
