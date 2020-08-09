namespace SilpoBonusCore
{
    public class Discount : IReward
    {
        private int value;

        public Discount(int value)
        {
            this.value = value;
        }

        public int GetDiscount(Product product)
        {
            int k = (int) ((double) (value * product.GetPrice()) / 100.0);
            return k;
        }
        
        public int GetPoints(Product product)
        {
            return 0;
        }
    }
}