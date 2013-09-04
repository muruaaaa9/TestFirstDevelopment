using System.Collections.Generic;

namespace Domain.ShoppingCart
{
    public class SaleRules
    {
        private readonly Dictionary<string, int> _rules;

        public SaleRules(Dictionary<string, int> rules)
        {
            _rules = rules;
        }

        public double? GetPrice(string productId,int quantity)
        {
            string key = string.Format("{0}_{1}", productId, quantity);
            return _rules.ContainsKey(key) ? (double?) _rules[key] : null;
        }
    }
}