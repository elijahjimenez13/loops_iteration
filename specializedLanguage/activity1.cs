using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int curPower = 2;
      int[] userNum = {1, 1, 0};
      int i = 0;
      
      while (userNum[i] == 1)
      {
      	Console.WriteLine(curPower + "\n");
        curPower = curPower * 2;
        i++;
      }
      
      Console.WriteLine("Done");
    }
  }
}