namespace SilpoBonusCore
{
    public class ByProducer : ICondition
    {
        string name;

        public ByProducer(string name)
        {
            this.name = name;
        }
        public void ApplyCondition(Check check, IReward reward)
        {
            foreach (Product product in check.GetProducts())
            {
                if (product.GetProducer() == name)
                {
                    check.AddPoints(reward.GetPoints(product));
                    check.AddDiscount(reward.GetDiscount(product));
                }
            }
        }
    }
}