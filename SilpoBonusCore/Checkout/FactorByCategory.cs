using System;

namespace SilpoBonusCore
{
    public class FactorByCategoryOffer : Offer {
        private Category category;
        private int factor;

        public FactorByCategoryOffer(Category category, int factor, DateTime date) : base(date){
            this.category = category;
            this.factor = factor;
        }

        public Category GetCategory(){
            return this.category;
        }

        public int GetFactor(){
            return factor;
        }

        internal override void Apply(Check check){
            int points = check.GetCostByCategory(this.GetCategory());
            check.AddPoints(points * (this.GetFactor() - 1));
        }
    }

}