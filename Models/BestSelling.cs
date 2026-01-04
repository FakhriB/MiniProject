namespace BookShop.Models
{
    public class BestSelling : BaseEntity
    {
        public string Image { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
