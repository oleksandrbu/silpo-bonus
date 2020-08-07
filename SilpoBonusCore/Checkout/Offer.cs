using System.Collections.Generic;
using System;

namespace SilpoBonusCore
{
    public abstract class Offer
    {
        private DateTime date;

        public DateTime GetDate()
        {
            return this.date;
        }

        public Offer(DateTime date)
        {
            this.date = date;
        }

        static internal List<Offer> GetValid(List<Offer> offersList)
        {
            List<Offer> offers = new List<Offer>();
            foreach (Offer offer in offersList)
            {
                if (offer.GetDate().CompareTo(DateTime.Now) >= 0)
                {
                    offers.Add(offer);
                }

            }
            return offers;
        }
        internal abstract void Apply(Check check);

        static public void ApplyOffers(Check check, List<Offer> offersList)
        {
            if (offersList.Count > 0)
                offersList = GetValid(offersList);
            foreach (Offer offer in offersList)
            {
                offer.Apply(check);
            }
        }
    }
}