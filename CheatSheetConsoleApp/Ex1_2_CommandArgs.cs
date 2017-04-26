using System;

namespace CheatSheetConsoleApp
{
  class Ex1_2_CommandArgs
  {
    //このメソッドはMainメソッドではないため直接起動されるわけではないが
    //Mainメソッドの引数をそのまま渡される想定
    internal static void Run(string[] args)
    {
      foreach (var arg in args)
      {
        Console.WriteLine(arg);
      }
      //Console.ReadLine();
    }
  }
}
