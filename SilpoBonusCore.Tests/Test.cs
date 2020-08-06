using System;
using Xunit;
using SilpoBonusCore;

namespace SilpoBonusCore.Tests
{
    public class SilpoBonusTest
    {
        [Fact]
        public void closeCheck__withOneProduct() {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.openCheck();

            checkoutService.addProduct(new Product(7, "Milk"));
            Check check = checkoutService.closeCheck();

            Assert.Equal(7, check.totalCost);
        }

        [Fact]
        public void closeCheck__withTwoProduct() {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.openCheck();

            checkoutService.addProduct(new Product(7, "Milk"));
            checkoutService.addProduct(new Product(3, "Bred"));
            Check check = checkoutService.closeCheck();

            Assert.Equal(10, check.totalCost);
        }


    }
}
