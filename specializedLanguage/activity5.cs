using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Loop variable initialization
      int i = 10;
      
      // Loop expression
      while (i <= 50)
      {
      	Console.WriteLine(i + " ");
        // Loop variable update
        i = i + 5;
      }
    }
  }
}