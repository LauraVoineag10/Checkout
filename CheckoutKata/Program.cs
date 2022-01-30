namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkout checkout = new Checkout();
            checkout.Print();

            var itemPrice = checkout.CalculatePrice(12);
            Console.WriteLine(itemPrice);

            var itemPriceA = checkout.CalculatePriceA(1, 50);
            Console.WriteLine(itemPriceA);

            var itemPriceAByTwo = checkout.CalculatePriceA(2, 50);
            Console.WriteLine(itemPriceAByTwo);

            var totalPriceAWithDiscountA = checkout.CalculateTotalPriceWithDiscountA(3, 50);
            Console.WriteLine(totalPriceAWithDiscountA);

            //calculating A total with Discount for 6 items of A using hard numbers
            //var totalPriceWithDiscountARefactored = checkout.CalculateTotalPriceWithDiscountARefactored(6, 50, 3, 20);
            //Console.WriteLine(totalPriceWithDiscountARefactored);


            //calculating A total with Discount for 6 items of A using object instead of 50
            Product productA = new Product("A", 50);

            var totalPriceWithDiscountARefactored = checkout.CalculateTotalPriceWithDiscountARefactored(6, productA, 3, 20);
            Console.WriteLine(totalPriceWithDiscountARefactored);

            //calculating A total with Discount for 6 items of A using object instead of 50,3,20
            PricingRule pricingRuleA = new PricingRule("A", 3, 20);
            var totalPriceDiscountObject = checkout.CalcTotalDiscPricingRule(6, productA, pricingRuleA);
            Console.WriteLine(totalPriceDiscountObject);








            

        }
    }
}