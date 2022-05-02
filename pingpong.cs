using System;
using System.Collections.Generic;

class Program 
{
  static void Main()  
  {
    Console.WriteLine("Input a number");
    string stringNum = Console.ReadLine();
    int Num = int.Parse(stringNum);
    Console.WriteLine("`````````````````````````");
    for(int i=1; i<Num+1; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("Ping-Pong");
      } 
      else if (i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else 
      {
        Console.WriteLine(i.ToString());
      }

    }
  }
}