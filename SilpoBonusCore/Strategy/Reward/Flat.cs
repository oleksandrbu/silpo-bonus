namespace SilpoBonusCore
{
    public class Flat : IReward
    {
        private int value;

        public Flat(int value)
        {
            this.value = value;
        }
        
        public int GetDiscount(Product product)
        {
            return 0;
        }
        public int GetPoints(Product product)
        {
            return value;
        }
    }
}