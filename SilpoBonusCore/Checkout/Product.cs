using System;

namespace SilpoBonusCore
{
    public class Product
    {
        private int price;
        private string name;
        private Category category;

        public Product(int price, String name, Category category = Category.EMPTY)
        {
            this.price = price;
            this.name = name;
            this.category = category;
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
    } 
}