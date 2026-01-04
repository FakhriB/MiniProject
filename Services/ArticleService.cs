using BookShop.Data;
using BookShop.Services.Interfaces;
using BookShop.ViewModels.Articles;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Services
{
    public class ArticleService : IArticleService
    {
        private readonly AppDbContext _context;
        public ArticleService(AppDbContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<ArticleVM>> GetAllAdminAsync()
        {
            IEnumerable<ArticleVM> articles = await _context.Articles
               .Select(a => new ArticleVM
               {
                   Image = a.Image,
                   Description = a.Description,
                   CreatedDate = a.CreatedDate
               }).ToListAsync();
            return articles;
        }

        public async Task<IEnumerable<ArticleUIVM>> GetAllAsync()
        {
            IEnumerable<ArticleUIVM> articles =await _context.Articles
                .Select(a => new ArticleUIVM
                {
                    Image = a.Image,
                    Description = a.Description,
                    CreatedDate = a.CreatedDate

                }).ToListAsync();
            return articles;

        }
    }
}
