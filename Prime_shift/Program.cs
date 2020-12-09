using System.Collections.Generic;
using System;

namespace Prime_shift
{
  public class Program
  {
    public static void Main()
    {
      Prime method = new Prime();
      int userInput =21;
      List<int> arr = method.MakeList(userInput);
      int prime = 2;
      
      foreach (int number in arr){
        Console.WriteLine(number);
      }
    }
  }
}
