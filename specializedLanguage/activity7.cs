using System;

namespace MyApplication
{
  class Program
  {
    static float EbayFee(float sellPrice)
    {
    	float feeTotal;
        
        // Base listing fee
        feeTotal = 0.50f;
        if (sellPrice <= 50.00f)
      {
        	// $50.00 or lower
        	feeTotal = feeTotal + (sellPrice * 0.13f);
      }
      	else if (sellPrice <= 1000.00f)
      {
        	// $50.01...$1000.00
        	feeTotal = feeTotal + (50.0f * 0.13f);
        	feeTotal = feeTotal + ((sellPrice - 50.0f) * 0.05f);	
      }
      	else
      {
        	// $1000.01 and higher
        	feeTotal = feeTotal + (50.0f * 0.13f);
        	feeTotal = feeTotal + ((1000.0f - 50.0f) * 0.05f);
        	feeTotal = feeTotal + ((sellPrice - 100.0f) * 0.02f);
      }
      	return feeTotal;
      }
      
     static void Main()
     {
     	float sellingPrice;
        
        sellingPrice = 9.95f;
        Console.WriteLine("eBay fee: $" + EbayFee(sellingPrice));
     }
  }
}