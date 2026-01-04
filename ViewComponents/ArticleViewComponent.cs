using BookShop.Services.Interfaces;
using BookShop.ViewModels.Articles;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        private readonly IArticleService _articleService;
        public ArticleViewComponent(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<ArticleUIVM> articles = await _articleService.GetAllAsync();
            return View(articles);
        }
    }
}
