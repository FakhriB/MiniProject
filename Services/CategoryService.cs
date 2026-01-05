using BookShop.Data;
using BookShop.Models;
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

        public async Task CreateAsync(CategoryCreateVM model)
        {
            await _context.Categories.AddAsync(new()
            {
                Name = model.Name,
            });
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category is not null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CategoryVM>> GetAllAdminCateories()
        {
            var categories = await _context.Categories.Select(c => new CategoryVM
            {
                Id = c.Id,
                Name = c.Name
            }).ToListAsync();
            return categories;
        }

        public async Task<IEnumerable<CategoryUIVM>> GetAllAsync()
        {
            var categories = await _context.Categories.Select(c => new CategoryUIVM
            {
                Id = c.Id,
                Name = c.Name,
            }).ToListAsync();
            return categories;
        }
    }
}
