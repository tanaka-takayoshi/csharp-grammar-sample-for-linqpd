using System;

namespace CheatSheetConsoleApp
{
  class Ex4_1_If
  {
    internal static void Run()
    {
      var flg = true;
      //true
      if (flg)
        Console.WriteLine("true");

      //else if
      if (Check())
      {
        Console.WriteLine("if");
      }
      else if (flg)
      {
        Console.WriteLine("else if");
      }
      else
      {
        Console.WriteLine("else");
      }
    }
    
    static bool Check()
    {
      return false;
    }
  }
}
