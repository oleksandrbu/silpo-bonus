namespace SilpoBonusCore
{
    public class Special : IReward
    {
        public Special()
        {
        }
        
        public int GetDiscount(Product product)
        {
            return product.GetPrice() - 1;
        }
        public int GetPoints(Product product)
        {
            return 1 - product.GetPrice();
        }
    }
}