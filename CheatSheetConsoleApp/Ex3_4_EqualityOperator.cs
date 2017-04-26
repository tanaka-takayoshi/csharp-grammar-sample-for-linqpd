using System;

namespace CheatSheetConsoleApp
{
  class Ex3_4_EqualityOperator
  {
    internal static void Run()
    {
      var f1 = 1 == 2; //False
      f1.Dump();
      var f2 = 1 != 1; //False
      f2.Dump();
      var f3 = new object() == new object(); //False
      f3.Dump();
      //.NET Coreではstring.Copyメソッドが定義されていないため、文字列結合に変更している
      var f4 = "abc" == "a" + "bc"; //True
      f4.Dump();
    }
  }
}
