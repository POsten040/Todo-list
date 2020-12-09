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
    public List<int> SortList (List<int> list, int prime, int userInput)
    {
      while(prime <= userInput)
      {
        for (int i = 0; i < list.Count; i++)
        {
          if (i % prime == 0)
          {
            list.Remove(list[i]);
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

// foreach (int number in list)
//         {
//           if (number % prime == 0)
//           {
//             list.Remove(number);
//           }
//           else
//           {
//             continue;
//           }
//         }