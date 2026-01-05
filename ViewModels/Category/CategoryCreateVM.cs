using Microsoft.Build.Framework;

namespace BookShop.ViewModels.Category
{
    public class CategoryCreateVM
    {
        [Required]
        public string Name { get; set; }
    }
}
