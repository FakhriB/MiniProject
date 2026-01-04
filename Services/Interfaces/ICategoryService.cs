using BookShop.ViewModels.Category;

namespace BookShop.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryUIVM>> GetAllAsync();
    }
}
