using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] currValue = {0, 10, 1, 6, 3};
      int valuesSum = 0;
      int numValues = 4;
      float averageValue;
      // Loop variable initialization
      int i = 0;
      
      // Loop expression
      while (i < numValues)
      {
      	// Loops variable update
        i++;
      	valuesSum = valuesSum + currValue[i];
      }
      
      averageValue = (1.0f * valuesSum) / numValues;
      Console.WriteLine("Average: " + averageValue);
    }
  }
}