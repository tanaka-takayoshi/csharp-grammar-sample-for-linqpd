using System;

namespace CheatSheetConsoleApp
{
  class Ex4_3_While_Do
  {
    internal static void Run()
    {
      int term = 0;
      while (term <= 3)
      {
        Console.WriteLine(term);
        ++term;
      }
      
      term = 0;
      do
      {
        Console.WriteLine(term);
        ++term;
      } while (term == 0);
    }
  }
}
