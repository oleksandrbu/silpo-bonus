namespace SilpoBonusCore
{
    public class ByCategory : ICondition
    {
        Category category;

        public ByCategory(Category category)
        {
            this.category = category;
        }
        public void ApplyCondition(Check check, IReward reward)
        {
            foreach (Product product in check.GetProducts())
            {
                if (product.GetCategory() == category)
                {
                    check.AddPoints(reward.GetPoints(product));
                    check.AddDiscount(reward.GetDiscount(product));
                }
            }
        }
    }
}