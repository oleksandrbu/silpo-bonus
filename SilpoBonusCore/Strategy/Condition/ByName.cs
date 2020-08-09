namespace SilpoBonusCore
{
    public class ByName : ICondition
    {
        string name;

        public ByName(string name)
        {
            this.name = name;
        }
        public void ApplyCondition(Check check, IReward reward)
        {
            foreach (Product product in check.GetProducts())
            {
                if (product.GetName() == name)
                {
                    check.AddPoints(reward.GetPoints(product));
                    check.AddDiscount(reward.GetDiscount(product));
                }
            }
        }
    }
}