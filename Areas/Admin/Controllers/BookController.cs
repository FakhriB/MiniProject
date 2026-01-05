using BookShop.Services.Interfaces;
using BookShop.ViewModels.Book;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetAllAdminAsync();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookCreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _bookService.CreateAsync(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
