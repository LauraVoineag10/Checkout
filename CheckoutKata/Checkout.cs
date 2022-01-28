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
        //Calculating price of A with discount - set numbers
        public int CalculateTotalPriceWithDiscountA(int itemA, int priceA)
        {
            int totalPrice = itemA * priceA;
            if (itemA == 3)
            {
                totalPrice -= 20;
            }
            return totalPrice;
        }

        //Calculating price of A using naming variables -refactored

        public int CalculateTotalPriceWithDiscountARefactored (int itemA, int priceA, int discountRuleA, int discountValueA)
        {
            int totalPrice = itemA * priceA;
            if (itemA == discountRuleA)
            {
                totalPrice -= discountValueA;
            }
            return totalPrice;
        }

    }
}