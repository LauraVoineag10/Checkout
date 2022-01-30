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

        //Calculating price of A using object. Object Oriented Programming 

        public int CalculateTotalPriceWithDiscountARefactored (int itemA, Product productA, int discountRuleA, int discountValueA)
        {
            int totalPrice = itemA * productA.Price;
            if (itemA % discountRuleA == 0)
            {
                totalPrice -= (itemA/discountRuleA)*discountValueA;
            }
            return totalPrice;
        }

        //Calculating pricingRuleA.Object Oriented Programming

        public int CalcTotalDiscPricingRule(int item, Product product, PricingRule pricingRule)
        {
            int totalPrice = item * product.Price;
            if (item% pricingRule.ItemCount==0)
            {
                totalPrice -= (item / pricingRule.ItemCount) * pricingRule.TotalDiscount;
            }
            return (totalPrice);
        }
    }
}

//Notes for completing kata
            /* varA =[ProductA1, ProductA2, ProductA3].CalculateTotalPriceWithDiscountARefactored

            varB =[ProductB1, ProductB2, ProductB3].CalculateTotalPriceWithDiscountARefactored

            varC = [ProductC1, ProductC2, ProductC3].CalculateTotalPriceWithDiscountARefactored

            total_price = varA + var B + var C
            
             Scan - how to save a list in memory, scan items and the program to remember what's scanned?
            Total price using a for loop?*/