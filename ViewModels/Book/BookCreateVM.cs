using System.ComponentModel.DataAnnotations;

namespace BookShop.ViewModels.Book
{
    public class BookCreateVM
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
