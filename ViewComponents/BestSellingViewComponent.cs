using BookShop.Services.Interfaces;
using BookShop.ViewModels.BestSelling;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.ViewComponents
{
    public class BestSellingViewComponent : ViewComponent
    {
        private readonly IBestSellingService _bestSellingService;
        public BestSellingViewComponent(IBestSellingService bestSellingService)
        {
            _bestSellingService = bestSellingService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<BestSellingUIVM> bestSellings = await _bestSellingService.GetAllAsync();
            return View(bestSellings);
        }
    }
}
