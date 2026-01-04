using BookShop.Services.Interfaces;
using BookShop.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderService _sliderService;
        public SliderViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<SliderUIVM> sliders = await _sliderService.GetAllAsync();
           

            return View(sliders);
        }
    }
}
