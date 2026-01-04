using BookShop.ViewModels.BestSelling;

namespace BookShop.Services.Interfaces
{
    public interface IBestSellingService
    {
        Task<IEnumerable<BestSellingUIVM>> GetAllAsync();
    }
}
