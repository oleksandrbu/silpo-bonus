using System.Collections.Generic;
using System;

namespace SilpoBonusCore
{
    public class Main
    {
        public static int Run()
        {
            return 0;
        }
    }

    public class CheckoutService
    {
        Check check;

        public void openCheck()
        {
            check = new Check();
        }

        public Check closeCheck(){
            return check;
        }

        public void addProduct(Product product) {
            check.addProduct(product);
        }
    }

        public class Check
    {
        List<Product> products = new List<Product>();

        public int getTotalCost()
        {
            int totalCost = 0;
            foreach (Product product in this.products) {
                totalCost += product.GetPrice();
            }
            return totalCost;
        }

        internal void addProduct(Product product)
        {
            products.Add(product);
        }
    }

    public class Product
    {
        int price;
        string  name;

        public Product(int price, String name)
        {
            this.price = price;
            this.name = name;
        }

        public int GetPrice(){
            return price;
        }
    }
}
