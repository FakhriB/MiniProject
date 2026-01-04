namespace BookShop.ViewModels.Book
{
    public class BookVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
