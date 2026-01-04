using BookShop.ViewModels.Slider;

namespace BookShop.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<SliderUIVM>> GetAllAsync();
        Task<IEnumerable<SliderVM>> GetAllAdminAsync();

    }
}
