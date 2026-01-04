using BookShop.Data;
using BookShop.Services.Interfaces;
using BookShop.ViewModels.Offer;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Services
{
    public class OfferService : IOfferService
    {
        private readonly AppDbContext _context;
        public OfferService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OfferVM>> GetAllAdminAsync()
        {
            IEnumerable<OfferVM> offers = await _context.Offers
               .Select(o => new OfferVM
               {
                   Id = o.Id,
                   Image = o.Image,
                   BookName = o.BookName,
                   Author = o.Author,
                   Price = o.Price
               }).ToListAsync();
            return offers;

        }

        public async Task<IEnumerable<OfferUIVM>> GetAllAsync()
        {
            IEnumerable<OfferUIVM> offers =await  _context.Offers
                .Select(o => new OfferUIVM
                {
                    Id = o.Id,
                    Image = o.Image,
                    BookName = o.BookName,
                    Author = o.Author,
                    Price = o.Price

                }).ToListAsync();
            return offers;
        }
    }
}
