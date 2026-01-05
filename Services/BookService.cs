using BookShop.Data;
using BookShop.Models;
using BookShop.Services.Interfaces;
using BookShop.ViewModels.Book;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Services
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(BookCreateVM model)
        {
            await _context.Books.AddAsync(new Book 
            { BookName = model.Name,
                Author = model.Author,
                Price = model.Price,
                Image = model.Image
            });
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BookVM>> GetAllAdminAsync()
        {
            IEnumerable<BookVM> books = await _context.Books
               .Select(b => new BookVM
               {
                   Id = b.Id,
                   BookName = b.BookName,
                   Author = b.Author,
                   Price = b.Price,
                   Image = b.Image
               }).ToListAsync();
            return books;
        }

        public async Task<IEnumerable<BookUIVM>> GetAllAsync()
        {
            var books =await _context.Books.Select(b => new BookUIVM
            {
                Id = b.Id,
                BookName = b.BookName,
                Author = b.Author,
                Price = b.Price,
                Image = b.Image

            }).ToListAsync();
            return books;

        }
    }
}
