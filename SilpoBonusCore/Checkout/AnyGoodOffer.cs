namespace SilpoBonusCore
{
    public class AnyGoodOffer
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
    }
}