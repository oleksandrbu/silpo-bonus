using System;
using System.Collections.Generic;

namespace SilpoBonusCore
{
    public class Main
    {
        public static int Run()
        {
            return 0;
        }
    }

    public class Check
    {
        public List<Product> products;
        public int totalCost;

        public int getTotalCost()
        {
            return totalCost;
        }
    }

    public class CheckoutService
    {
        private Check check;

        public void openCheck()
        {
            check = new Check();
            check.products = new List<Product>();
            check.totalCost = 0;
        }

        public void addProduct(Product product)
        {
            check.products.Add(product);
        }

        public Check closeCheck(){
            foreach (Product product in check.products)
            {
                check.totalCost += product.price;
            }
            return check;
        }
    }

    public class Product
    {
        internal int price;
        string  name;

        public Product(int price, String name)
        {
            this.price = price;
            this.name = name;
        }
    }
}
