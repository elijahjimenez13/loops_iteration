using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] currValue = {0, -1, 9, 0, 3};
      int maxSoFar = 0;
      int numValues = 4;
      // Loop variable initialization
      int i = 0;
      
      // Loop expression
      while (i < numValues)
      {
      	// Loops variable update
        i++;
      	// First iteration
        if (i == 0)
        {
        	maxSoFar = currValue[i];
        }
        else if ((currValue[i] > maxSoFar))
        {
        	maxSoFar = currValue[i];
        }
      }

      Console.WriteLine("Max: " + maxSoFar);
    }
  }
}