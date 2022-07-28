using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int currC;
      float equivalentF;
      
      // Loop variable initialization
      currC = -10;
      
      // Loop expression
      while (currC <= 40)
      {
      	equivalentF = (currC * 9.0f/5.0f) + 32.0f;
        Console.WriteLine(currC + " C is " + equivalentF + " F\n");
        
        // Loop variable update
        currC = currC + 5;
      }
    }
  }
}