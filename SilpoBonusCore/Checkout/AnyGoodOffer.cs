using System;

namespace SilpoBonusCore
{
    public class AnyGoodOffer : Offer
    {
        private int totalCost;
        private int points;

        public AnyGoodOffer(int totalCost, int points, DateTime date) : base(date)
        {
            this.totalCost = totalCost;
            this.points = points;
        }

        public int GetTotalCost(){
            return this.totalCost;
        }

        public int GetPoints(){
            return this.points;
        }

        internal override void Apply(Check check){
            if (this.totalCost <= check.GetTotalCost())
                check.AddPoints(this.points);
        }
    }
}