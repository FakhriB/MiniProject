using BookShop.ViewModels.Book;

namespace BookShop.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookUIVM>> GetAllAsync();  
        Task<IEnumerable<BookVM>> GetAllAdminAsync();
    }
}
