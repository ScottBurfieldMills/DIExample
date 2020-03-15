using DIExample.Models;

namespace DIExample.Services
{
    public class CartService : ICartService
    {
        private readonly PriceService _priceService;

        public CartService(PriceService priceService)
        {
            _priceService = priceService;
        }

        public void Add(Product product)
        {

        }
    }
}
