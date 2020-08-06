using System.Collections.Generic;

namespace SilpoBonusCore
{
    public class Check
    {
        private List<Product> products = new List<Product>();
        private int points;
        public int GetTotalCost()
        {
            int totalCost = 0;
            foreach (Product product in this.products) {    
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
    }
}