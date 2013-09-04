using System.Collections;
using System.Collections.Generic;
using Domain.ShoppingCart;
using NUnit.Framework;

namespace Domain.Tests.Shopping_Cart_Tests
{
    [TestFixture]
    public class ShoppingCartTest
    {
        private IShoppingCart _shoppingCart;
        private Dictionary<string,int> _discountedItems;

        [SetUp]
        public void SetUp()
        {
            _shoppingCart = new ShoppingCart();
            _discountedItems = new Dictionary<string, int>();
        }

        [Test]
        public void ShouldBeAbleToAddToCart()
        {
            var item1 = new CartItem{ProductId="P1001",Name = "Logitech Mouse", Qty = 1, Price = 5.00};
            var saleRules = new SaleRules(_discountedItems);

            _shoppingCart.AddToCart(item1);

            Assert.AreEqual(_shoppingCart.GetCartItems().Count, 1);
            Assert.AreEqual(_shoppingCart.GetTotal(), 5.00);
        }

        [Test]
        public void ShouldBeAbleToAddToCartMultipleItems()
        {
            var item1 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 1, Price = 5.00 };
            var item2 = new CartItem { ProductId = "P1002", Name = "Logitech Keyboard", Qty = 1, Price = 9.00 };

            var saleRules = new SaleRules(_discountedItems);

            _shoppingCart.AddToCart(item1);
            _shoppingCart.AddToCart(item2);

            Assert.AreEqual(_shoppingCart.GetCartItems().Count, 2);
            Assert.AreEqual(_shoppingCart.GetTotal(), 14.00);
        }
        
        [Test]
        public void ShouldBeAbleToIncrementWhenAddTheSameItem()
        {
            var item1 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 1, Price = 5.00 };
            var item2 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 2, Price = 5.00 };
            var item3 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 3, Price = 5.00 };

            var saleRules = new SaleRules(_discountedItems);

            _shoppingCart.AddToCart(item1);
            Assert.AreEqual(_shoppingCart.GetCartItems().Count, 1);
            _shoppingCart.AddToCart(item2);
            Assert.AreEqual(_shoppingCart.GetCartItems().Count, 1);
            _shoppingCart.AddToCart(item3);
            Assert.AreEqual(_shoppingCart.GetCartItems().Count,1);
            Assert.AreEqual(_shoppingCart.GetTotal(), 15.00);
        }

        [Test]
        public void ShouldBeAbleToCalculateTotalWhenSameItemIsAddToCartMultipleTimes()
        {
            var item2 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 1, Price = 5.00 };
            var item1 = new CartItem { ProductId = "P1001", Name = "Logitech Mouse", Qty = 1, Price = 5.00 };
            _shoppingCart.AddToCart(item1);
            _shoppingCart.AddToCart(item2);
            var total = _shoppingCart.GetTotal();
            Assert.AreEqual(total, 10.00);
        }
    }
}
