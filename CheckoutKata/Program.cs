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
        }
    }
}