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

        public void UseOffer(Offer offer)
        {
            offer.Apply(this.check);
        }
    }
}