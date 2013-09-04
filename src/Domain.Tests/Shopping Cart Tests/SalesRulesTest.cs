using System.Collections.Generic;
using Domain.ShoppingCart;
using NUnit.Framework;

namespace Domain.Tests.Shopping_Cart_Tests
{
    [TestFixture]
    public class SalesRulesTest
    {

        private Dictionary<string, int> _discountedItems;

        [SetUp]
        public void Setup()
        {
            _discountedItems = new Dictionary<string, int>();
        }

        [Test]
        public void ShouldNotGiveAnyDiscountWhenItemIsNotOnSale()
        {
            var saleRules = new SaleRules(_discountedItems);
            
            Assert.AreEqual(saleRules.GetPrice("P10891",  1), null);
        }

        [Test]
        public void ShouldNotGiveAnyDiscountWhenItemIsMatchedButNotQuantity()
        {
            _discountedItems.Add("P10891_3",1500); // "P10891 productid of "samsung", if the customer buys 3 items then it is only 1500£.
            
            var saleRules = new SaleRules(_discountedItems);
           
            Assert.AreEqual(saleRules.GetPrice("P10891",  1), null);
        }

        [Test]
        public void ShouldGiveDiscountedPriceWhenItemIsMatchedAndAlsoQuantity()
        {
            _discountedItems.Add("P10891_3", 1500);

            var saleRules = new SaleRules(_discountedItems);

            Assert.AreEqual(saleRules.GetPrice("P10891",  1500), null);
        }
    }
}