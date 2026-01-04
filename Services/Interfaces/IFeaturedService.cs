using BookShop.ViewModels.Featured;

namespace BookShop.Services.Interfaces
{
    public interface IFeaturedService
    {
        Task<IEnumerable<FeaturedUIVM>> GetAllAsync(); 
        Task<IEnumerable<FeaturedVM>> GetAllAdminAsync();

    }
}
