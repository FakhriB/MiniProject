using BookShop.Data;
using BookShop.Services.Interfaces;
using BookShop.ViewModels.Featured;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Services
{
    public class FeaturedService : IFeaturedService
    {
        private readonly AppDbContext _context;
        public FeaturedService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FeaturedVM>> GetAllAdminAsync()
        {
            IEnumerable<FeaturedVM> featureds =await  _context.Featureds
               .Select(f => new FeaturedVM
               {
                   Image = f.Image,
                   BookName = f.BookName,
                   Author = f.Author,
                   Price = f.Price
               }).ToListAsync();
            return featureds;
        }

        public async Task<IEnumerable<FeaturedUIVM>> GetAllAsync()
        {
            IEnumerable<FeaturedUIVM> featureds = await _context.Featureds
                .Select(f => new FeaturedUIVM
                {
                    Image = f.Image,
                    BookName = f.BookName,
                    Author = f.Author,
                    Price = f.Price

                }).ToListAsync();
            return featureds;
        }
    }
}
