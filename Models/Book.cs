namespace BookShop.Models
{
    public class Book : BaseEntity
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<BookImage> BookImages { get; set; }
       
    }
}

