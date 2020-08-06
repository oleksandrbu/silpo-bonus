namespace SilpoBonusCore
{
    public class FactorByCategoryOffer : AnyGoodOffer {
        private Category category;
        private int factor;

        public FactorByCategoryOffer(Category category, int factor) : base(0,0){
            this.category = category;
            this.factor = factor;
        }

        public Category GetCategory(){
            return this.category;
        }

        public int GetFactor(){
            return factor;
        }
    }

}