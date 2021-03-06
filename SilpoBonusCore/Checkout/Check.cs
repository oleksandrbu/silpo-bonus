using System.Collections.Generic;

namespace SilpoBonusCore
{
    public class Check
    {
        private List<Product> products = new List<Product>();
        private int points;
        private int discount;
        
        public int GetTotalCost()
        {
            int totalCost = 0;
            foreach (Product product in products) {    
                totalCost += product.GetPrice();
            }
            return totalCost;
        }

        internal void AddProduct(Product product)
        {
            products.Add(product);
        }

        public int GetTotalPoints()
        {
            return GetTotalCost() + points;
        }

        internal void AddPoints(int points)
        {
            this.points += points;
        }

        public int GetCostByCategory(Category category)
        {
            int price = 0;
            foreach (Product product in products)
            {
                if (product.GetCategory() == category)
                {
                    price += product.GetPrice();
                }
            }
            return price;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public void AddDiscount(int value)
        {
            discount += value;
        }

        public int GetDiscount()
        {
            return discount;
        }
    }
}