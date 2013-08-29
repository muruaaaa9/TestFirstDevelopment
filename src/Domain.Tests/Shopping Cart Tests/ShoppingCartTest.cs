using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Domain.Tests.Shopping_Cart_Tests
{
    [TestFixture]
    public class ShoppingCartTest
    {
        private IShoppingCart _shoppingCart;

        [SetUp]
        public void SetUp()
        {
            _shoppingCart = new ShoppingCart();
        }

        [Test]
        public void ShouldBeAbleToAddToCart()
        {
            var item1 = new CartItem{ProductId="P1001",Name = "Logitech Mouse", Qty = 1, Price = 5.00};

            _shoppingCart.AddToCart(item1);

            Assert.AreEqual(_shoppingCart.GetCartItems().Count, 1);
        }

        [Test]
        public void ShouldBeAbleToAddToCartMultipleItems()
        {
            var item1 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 1, Price = 5.00 };
            var item2 = new CartItem { ProductId = "P1002", Name = "Logitech Keyboard", Qty = 1, Price = 9.00 };
            
            _shoppingCart.AddToCart(item1);
            _shoppingCart.AddToCart(item2);

            Assert.AreEqual(_shoppingCart.GetCartItems().Count, 2);
        }

        [Test]
        public void ShouldBeAbleToIncrementWhenAddTheSameItem()
        {
            var item1 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 1, Price = 5.00 };
            var item2 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 2, Price = 5.00 };
            var item3 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 3, Price = 5.00 };
            
            
            _shoppingCart.AddToCart(item1);
            Assert.AreEqual(_shoppingCart.GetCartItems().Count, 1);
            _shoppingCart.AddToCart(item2);
            Assert.AreEqual(_shoppingCart.GetCartItems().Count, 1);
            _shoppingCart.AddToCart(item3);
            Assert.AreEqual(_shoppingCart.GetCartItems().Count,1);
        }
    }

    public interface IShoppingCart
    {
        void AddToCart(CartItem item);
        List<CartItem> GetCartItems();
    }

    public class ShoppingCart : IShoppingCart, IEnumerable
    {
        private static List<CartItem> CartItems = null;

        public ShoppingCart()
        {
            CartItems = new List<CartItem>();
        }

        public void AddToCart(CartItem item)
        {
            CartItems.Add(item);
        }

        public void CheckForItemExistInTheShoppingCartAlready(CartItem item)
        {
            if (CartItems.Count > 0)
            {
                bool itemFound = false;
                foreach (var cartItem in CartItems)
                {
                    if (cartItem.ProductId.Equals(item.ProductId))
                    {
                        itemFound = true;
                        cartItem.Qty += item.Qty;
                        break;
                    }
                }

                if (!itemFound)
                {
                   AddToCart(item);
                }
            }
            else
            {
                AddToCart(item);
            }
        }

        public List<CartItem> GetCartItems()
        {
            return CartItems;
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }

    public class CartItem
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Qty { get; set; }

        public string ProductId { get; set; }
    }
}
