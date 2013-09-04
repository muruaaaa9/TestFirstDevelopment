using System.Collections.Generic;

namespace Domain.Tests.Shopping_Cart_Tests
{
    public interface IShoppingCart
    {
        void AddToCart(CartItem item);
        List<CartItem> GetCartItems();
        double GetTotal();
    }
}