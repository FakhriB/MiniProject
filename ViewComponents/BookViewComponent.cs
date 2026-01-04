using BookShop.Services.Interfaces;
using BookShop.ViewModels.Book;
using BookShop.ViewModels.Category;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        public BookViewComponent(IBookService bookService, ICategoryService categoryService)
        {
            _bookService = bookService;
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var books = await _bookService.GetAllAsync();
            var categories = await _categoryService.GetAllAsync();

            BookVMVC model = new BookVMVC()
            {
                Books = books,
                Categories = categories
            };



            return View(model);
        }
    }
    public class  BookVMVC
    {
        public IEnumerable<BookUIVM> Books { get; set; }
        public IEnumerable<CategoryUIVM> Categories { get; set; }


    }
}
