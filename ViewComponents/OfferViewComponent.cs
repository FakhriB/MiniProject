using BookShop.Services.Interfaces;
using BookShop.ViewModels.Offer;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.ViewComponents
{
    public class OfferViewComponent : ViewComponent
    {
        private readonly IOfferService _offerService;
        public OfferViewComponent(IOfferService offerService)
        {
            _offerService = offerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<OfferUIVM> offers = await _offerService.GetAllAsync();


            return View(offers);
        }
    }
}
