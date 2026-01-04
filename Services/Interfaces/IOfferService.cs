using BookShop.ViewModels.Offer;

namespace BookShop.Services.Interfaces
{
    public interface IOfferService
    {
        Task<IEnumerable<OfferUIVM>> GetAllAsync();
        Task<IEnumerable<OfferVM>> GetAllAdminAsync();
    }
}
