namespace SilpoBonusCore
{
    public class AnyGoodOffer : Offer
    {
        private int totalCost;
        private int points;

        public AnyGoodOffer(int totalCost, int points)
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

        public override void Apply(Check check){
            if (this.totalCost <= check.GetTotalCost())
                check.AddPoints(this.points);
        }
    }
}