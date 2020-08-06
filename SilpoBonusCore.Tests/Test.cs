using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class SilpoBonusTest
    {
        private Product bred_3;
        private Product milk_7;
        private CheckoutService checkoutService;

        public SilpoBonusTest()
        {
            this.checkoutService = new CheckoutService();
            this.checkoutService.OpenCheck();

            this.milk_7 = new Product(7, "Milk", Category.MILK);
            this.bred_3 = new Product(3, "Bred");
        }

        [Fact]
        public void closeCheck__withOneProduct() {
            checkoutService.AddProduct(milk_7);
            Check check = checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());
        }

        [Fact]
        public void closeCheck__withTwoProduct() {
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bred_3);
            Check check = checkoutService.CloseCheck();

            Assert.Equal(10, check.GetTotalCost());
        }

        [Fact]
        void addProduct__whenCheckIsClosed__opensNewCheck() {
            checkoutService.AddProduct(milk_7);
            Check milkCheck = checkoutService.CloseCheck();
            Assert.Equal(7, milkCheck.GetTotalCost());

            checkoutService.AddProduct(bred_3);
            Check bredCheck = checkoutService.CloseCheck();
            Assert.Equal(3, bredCheck.GetTotalCost());
        }

        [Fact]
        void closeCheck__calcTotalPoints() 
        {
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bred_3);
            Check check = checkoutService.CloseCheck();
        
            Assert.Equal(10, check.GetTotalPoints());
        }

        [Fact]
        void useOffer_addOfferPoint()
        {
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bred_3);

            checkoutService.UseOffer( new AnyGoodOffer(6,2));
            Check check= checkoutService.CloseCheck();

            Assert.Equal(12, check.GetTotalPoints());
        }

        [Fact]
        void useOffer__whenCostLessThanRequired__doNothing()
        {
            checkoutService.AddProduct(bred_3);

            checkoutService.UseOffer(new AnyGoodOffer(6, 2));
            Check check = checkoutService.CloseCheck();
            
            Assert.Equal(3, check.GetTotalPoints());
        }

        [Fact]
        void useOffer__factorByCategory() {
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bred_3);

            checkoutService.UseOffer(new FactorByCategoryOffer(Category.MILK, 2));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(31, check.GetTotalPoints());
        }

    }
}
