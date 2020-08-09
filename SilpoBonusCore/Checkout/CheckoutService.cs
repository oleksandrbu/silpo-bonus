using System.Collections.Generic;

namespace SilpoBonusCore
{
    public class CheckoutService
    {
        private Check check;
        private List<Offer> offersList;
        public void OpenCheck()
        {
            check = new Check();
            offersList = new List<Offer>();
        }

        public Check CloseCheck(){
            if (offersList.Count > 0)
            {
                foreach (Offer offer in offersList)
                    offer.ApplyOffer(check);
            }
            
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
            offersList.Add(offer);
        }
    }
}