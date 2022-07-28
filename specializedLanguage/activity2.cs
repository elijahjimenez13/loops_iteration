using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      float initialSavings = 10000;
      float interestRate = 0.05f;
      float currSavings = initialSavings;
      // Loop variable initialization
      int i = 0;
      
      
      Console.WriteLine("Annual Savings for 10 years: \n");
      
      // Loop expression
      while (i < 10)
      {
      	Console.WriteLine("$" + currSavings + "\n");
        currSavings = currSavings + (currSavings * interestRate);
        // Loops variable update
        i++;
      }
    }
  }
}