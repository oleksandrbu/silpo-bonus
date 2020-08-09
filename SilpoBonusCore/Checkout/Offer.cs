using System;

namespace SilpoBonusCore
{
    public class Offer
    {
        private DateTime date;
        private ICondition condition;
        private IReward reward;

        public Offer(ICondition condition, IReward reward, DateTime date)
        {
            this.date = date;
            this.condition = condition;
            this.reward = reward;
        }

        public bool CheckValid()
        {
            return (date.CompareTo(DateTime.Now) >= 0);
        }

        public void ApplyOffer(Check check)
        {
            if (CheckValid()) 
            {
                condition.ApplyCondition(check, reward);
            }
        }
    }
}