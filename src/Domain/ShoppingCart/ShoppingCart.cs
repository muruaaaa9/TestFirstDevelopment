using System.Collections.Generic;
using System.Linq;

namespace Domain.Tests.Shopping_Cart_Tests
{
    public class ShoppingCart : IShoppingCart
    {
        private static List<CartItem> CartItems = null;
        private double _total;

        public ShoppingCart()
        {
            CartItems = new List<CartItem>();
        }

        public void AddToCart(CartItem item)
        {
            CheckItemExistThenAddToCart(item);
        }

        private void AddIndividualItemToCart(CartItem item)
        {
            CartItems.Add(item);
        }

        private void CheckItemExistThenAddToCart(CartItem item)
        {
            var cartItem = CartItems.FirstOrDefault(ci => ci.ProductId == item.ProductId);
            _total += item.Price;
            if (cartItem == null)
                AddIndividualItemToCart(item);
            else
                cartItem.Qty += item.Qty;
            
        }

        public double GetTotal()
        {
            return _total;
        }

        public List<CartItem> GetCartItems()
        {
            return CartItems;
        }

       
    }
}