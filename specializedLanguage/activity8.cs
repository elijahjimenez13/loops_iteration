using System;

namespace MyApplication
{
  class Program
  {
  	static int FindLCM(int aVal, int bVal)
    {
    	int lcmVal;
        
    	lcmVal = (Math.Abs(aVal * bVal / FindGCD(aVal, bVal)));
        
        return lcmVal;
    }
    
    static int FindGCD(int aVal, int bVal)
    {
    	int numA;
        int numB;
        int gcdVal;
        
        numA = aVal;
        numB = bVal;
        
        // Eucid's algorithm
        while (numA != numB)
        {
        	if (numB > numA)
            {
            	numB = numB - numA;
            }
            else
            {
            	numA = numA - numB;
            }
        }
        gcdVal = numA;
        
        return gcdVal;
    }
    
    static void Main()
    {
    	int usrNumA;
        int usrNumB;
        int lcmResult;
        
        usrNumA = 13;
        usrNumB = 7;
        
        lcmResult = FindLCM(usrNumA, usrNumB);
        
        Console.WriteLine("Least common multiple of " + usrNumA + " and " + usrNumB + " is " + lcmResult);
    }
    
  }
}