namespace BookShop.Models
{
    public class Featured : BaseEntity
    {
        public string Image { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

    }
}
