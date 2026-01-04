using BookShop.ViewModels.Articles;

namespace BookShop.Services.Interfaces
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleUIVM>> GetAllAsync();
        Task<IEnumerable<ArticleVM>> GetAllAdminAsync();
    }
}
