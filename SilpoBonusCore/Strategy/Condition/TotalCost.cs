namespace SilpoBonusCore
{
    public class TotalCost : ICondition
    {
        private int totalCost;

        public TotalCost(int totalCost)
        {
            this.totalCost = totalCost;
        }
        public void ApplyCondition(Check check, IReward reward)
        {
            if (check.GetTotalCost() >= totalCost)
            {
                foreach (Product product in check.GetProducts())
                {
                    check.AddPoints(reward.GetPoints(product));
                    check.AddDiscount(reward.GetDiscount(product));
                }
            }
        }
    }
}