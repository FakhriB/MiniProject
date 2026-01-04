using BookShop.Data;
using BookShop.Services.Interfaces;
using BookShop.ViewModels.Category;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryUIVM>> GetAllAsync()
        {
            var categories =await _context.Categories
                .Select(c => new CategoryUIVM
                {
                    Id = c.Id,

                    Name = c.Name
                    
                }).ToListAsync();
            return categories;
        }
    }
}
