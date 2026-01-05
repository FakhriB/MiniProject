using BookShop.Models;
using BookShop.ViewModels.Category;

namespace BookShop.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryUIVM>> GetAllAsync();
        Task<IEnumerable<CategoryVM>> GetAllAdminCateories();
        Task CreateAsync(CategoryCreateVM model);
        Task DeleteAsync(int id);
    }
}
