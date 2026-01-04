using BookShop.Data;
using BookShop.Services.Interfaces;
using BookShop.ViewModels.BestSelling;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Services
{
    public class BestSellingService : IBestSellingService
    {
        private readonly AppDbContext _context;
        public BestSellingService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<BestSellingUIVM>> GetAllAsync()
        {
            IEnumerable<BestSellingUIVM> bestSellings = await _context.BestSellings.OrderByDescending(b => b.Price )
                .Select(b => new BestSellingUIVM
                {
                    Image = b.Image,
                    BookName = b.BookName,
                    Author = b.Author,
                    Description = b.Description,
                    Price = b.Price
                }).ToListAsync();
            return bestSellings;


        }
    }
}
