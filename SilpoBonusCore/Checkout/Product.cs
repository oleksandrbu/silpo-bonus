using System;

namespace SilpoBonusCore
{
    public class Product
    {
        private int price;
        private string name;
        private Category category;
        private string producer;

        public Product(int price, String name, Category category = Category.EMPTY, string producer = "Unknown")
        {
            this.price = price;
            this.name = name;
            this.category = category;
            this.producer = producer;
        }

        public int GetPrice(){
            return price;
        }

        public string GetName(){
            return name;
        }

        public Category GetCategory(){
            return category;
        }

        public string GetProducer(){
            return producer;
        }
    } 
}