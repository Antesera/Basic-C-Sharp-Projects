using System;

namespace Do Loop
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
    do 
      {
        Console.WriteLine(i);
        i++;
      }
      while (i < 5);
    }
  }
}