using System;
namespace Application
{
    public class Checkout : ICheckout
    {
        //Testing function
        public void Print()
        {
            Console.WriteLine("Scanning item");
        }
        //Returning one item
        public int CalculatePrice(int item)
        {
            return item;
        }
        //Calculating price of A
        public int CalculatePriceA(int itemA, int priceA)
        {
            return itemA * priceA;
        }
        //Calculating price of A with discount
        public int CalculateTotalPriceWithDiscountA(int itemA, int priceA)
        {
            int totalPrice = 0;

            totalPrice = itemA * priceA;
            if (itemA == 3)
            {
                totalPrice -= 20;
            }
            return totalPrice;
        }
    }
}