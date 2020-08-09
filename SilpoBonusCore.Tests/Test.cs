using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class SilpoBonusTest
    {
        private Product[] milk =
        {
            new Product(100, "name1", Category.MILK, "prod1"),
            new Product(100, "name2", Category.MILK, "prod1"),
            new Product(200, "name3", Category.MILK, "prod2")
        };
        private Product[] bred =
        {
            new Product(100, "name1", Category.BRED, "prod1"),
            new Product(200, "name2", Category.BRED, "prod3"),
            new Product(100, "name3", Category.BRED, "prod2")
        };        
        private CheckoutService checkoutService;

        public SilpoBonusTest()
        {
            this.checkoutService = new CheckoutService();
            this.checkoutService.OpenCheck();
        }

        [Fact]
        void check__strategy__1() {
            for (int i = 0; i < 3; i++)
            {
                checkoutService.AddProduct(milk[i]);
                checkoutService.AddProduct(bred[i]);
            }
            checkoutService.UseOffer(new Offer(new ByCategory(Category.MILK), new Discount(50), new DateTime(2020, 8, 25)));
            
            Check check = checkoutService.CloseCheck();
        
            Assert.Equal(800, check.GetTotalPoints());
            Assert.Equal(200, check.GetDiscount());
        }

        [Fact]
        void check__strategy__2() {
            for (int i = 0; i < 3; i++)
            {
                checkoutService.AddProduct(milk[i]);
                checkoutService.AddProduct(bred[i]);
            }
            checkoutService.UseOffer(new Offer(new ByName("name1"), new Factor(10), new DateTime(2020, 8, 25)));
            
            Check check = checkoutService.CloseCheck();
        
            Assert.Equal(2600, check.GetTotalPoints());
            Assert.Equal(0, check.GetDiscount());
        }

        [Fact]
        void check__strategy__3() {
            for (int i = 0; i < 3; i++)
            {
                checkoutService.AddProduct(milk[i]);
                checkoutService.AddProduct(bred[i]);
            }
            checkoutService.UseOffer(new Offer(new ByProducer("prod1"), new Flat(1000), new DateTime(2020, 8, 25)));
            
            Check check = checkoutService.CloseCheck();
        
            Assert.Equal(3800, check.GetTotalPoints());
            Assert.Equal(0, check.GetDiscount());
        }

        [Fact]
        void check__strategy__4() {
            for (int i = 0; i < 3; i++)
            {
                checkoutService.AddProduct(milk[i]);
                checkoutService.AddProduct(bred[i]);
            }
            checkoutService.UseOffer(new Offer(new TotalCost(800), new Special(), new DateTime(2020, 8, 25)));
            
            Check check = checkoutService.CloseCheck();
        
            Assert.Equal(6, check.GetTotalPoints());
            Assert.Equal(794, check.GetDiscount());
        }
    }
}
