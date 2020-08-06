using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class SilpoBonusTest
    {
        CheckoutService checkoutService = new CheckoutService();
        Product milk_7 = new Product(7, "Milk");
        Product bred_3 = new Product(3, "Bred");

        [Fact]
        public void closeCheck__withOneProduct() {
            checkoutService.addProduct(milk_7);
            Check check = checkoutService.closeCheck();

            Assert.Equal(7, check.getTotalCost());
        }

        [Fact]
        public void closeCheck__withTwoProduct() {
            checkoutService.addProduct(milk_7);
            checkoutService.addProduct(bred_3);
            Check check = checkoutService.closeCheck();

            Assert.Equal(10, check.getTotalCost());
        }

        [Fact]
        void addProduct__whenCheckIsClosed__opensNewCheck() {
            checkoutService.addProduct(milk_7);
            Check milkCheck = checkoutService.closeCheck();
            Assert.Equal(7, milkCheck.getTotalCost());

            checkoutService.addProduct(bred_3);
            Check bredCheck = checkoutService.closeCheck();
            Assert.Equal(3, bredCheck.getTotalCost());
        }

        [Fact]
        void closeCheck__calcTotalPoints() 
        {
            checkoutService.addProduct(milk_7);
            checkoutService.addProduct(bred_3);
            Check check = checkoutService.closeCheck();
        
            Assert.Equal(10, check.getTotalPoints());
        }

    }
}
