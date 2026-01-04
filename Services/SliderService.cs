using BookShop.Data;
using BookShop.Services.Interfaces;
using BookShop.ViewModels.Slider;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Services
{
    public class SliderService : ISliderService
    {
        public readonly AppDbContext _context;
        public SliderService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SliderVM>> GetAllAdminAsync()
        {
            IEnumerable<SliderVM> sliders = await _context.Sliders
               .Select(s => new SliderVM
               {
                   Title = s.Title,
                   Description = s.Description,
                   Image = s.Image
               }).ToListAsync();
            return sliders;

        }

        public async Task<IEnumerable<SliderUIVM>> GetAllAsync()
        {
            IEnumerable<SliderUIVM> sliders = await _context.Sliders
                .Select(s => new SliderUIVM
                {
                    Title = s.Title,
                    Description = s.Description,
                    Image = s.Image
                }).ToListAsync();
            return sliders;

        }
    }
}
