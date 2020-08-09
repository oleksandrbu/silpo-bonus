namespace SilpoBonusCore
{
    public class Factor : IReward
    {
        private int value;

        public Factor(int value)
        {
            this.value = value;
        }
        
        public int GetDiscount(Product product)
        {
            return 0;
        }
        public int GetPoints(Product product)
        {
            return product.GetPrice() * value - product.GetPrice();
        }
    }
}