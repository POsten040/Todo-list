using System.Collections.Generic;
using System;

namespace Prime_shift
{
  public class Prime
  {
    public List<int> MakeList (int userInput)
    {
      List<int> list = new List<int>();
      for(int i =2; i<=userInput; i++)
      {
        list.Add(i);
      }
      return list;
    }
    public List<int> SortList (List<int> list, int prime)
    {
      while(prime <= userInput)
      {
        foreach (int number in list)
        {
          if (number % prime == 0)
          {
            list.Remove(number);
          }
          else
          {
            continue;
          }
        }
        prime++;
      }
      return list;
    }
  }
}