using System;

namespace SilpoBonusCore
{
    public class Product
    {
        private int price;
        private string  name;

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