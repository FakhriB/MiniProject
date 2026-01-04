namespace BookShop.Models
{
    public class BookImage : BaseEntity
    {
        public string Image { get; set; }
        public bool IsMain { get; set; } = false;
        public int ProductId { get; set; }
        public Book Book { get; set; }
    }
}
