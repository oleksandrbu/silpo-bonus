namespace SilpoBonusCore
{
    public class CheckoutService
    {
        private Check check;

        public void OpenCheck()
        {
            check = new Check();
        }

        public Check CloseCheck(){
            Check closedCheck = check;
            check = null;
            return closedCheck;
        }

        public void AddProduct(Product product)
        {
            if (check == null) {
                OpenCheck();
            }
            check.AddProduct(product);
        }

        public void UseOffer(AnyGoodOffer offer)
        {
            if (offer is FactorByCategoryOffer) {
                FactorByCategoryOffer fbOffer = (FactorByCategoryOffer) offer;
                int points = this.check.GetCostByCategory(fbOffer.GetCategory());
                this.check.AddPoints(points * (fbOffer.GetFactor() - 1));
            } else {
                if (offer.GetTotalCost() <= this.check.GetTotalCost())
                    this.check.AddPoints(offer.GetPoints());
            }
        }
    }
}