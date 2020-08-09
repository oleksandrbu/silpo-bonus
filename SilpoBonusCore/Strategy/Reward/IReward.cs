namespace SilpoBonusCore
{
    public interface IReward
    {
        int GetDiscount(Product product);

        int GetPoints(Product product1);
    }    
}