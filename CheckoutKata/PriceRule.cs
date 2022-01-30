using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
	public class PricingRule
	{
		public string ItemName { get; }
		public int ItemCount { get; }
		public int TotalDiscount { get; }
		public PricingRule(string itemName, int itemCount, int totalDiscount)
		{
			ItemName = itemName;
			ItemCount = itemCount;
			TotalDiscount = totalDiscount;
		}
	}
}