namespace BookShop.Models
{
    public class Article : BaseEntity
    {
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
