using System;

namespace CheatSheetConsoleApp
{
  class Ex3_8_NullConditionOperator
  {
    internal static void Run()
    {
      string[] array = null;
      var length = array?.Length; //null
      length.Dump();
      var i1 = array?[1]; //null。i1は int?型
      i1.Dump();
      
      Func<int> func = null;
      var i2 = func?.Invoke(); //null。i2は int?型
      i2.Dump();
    }
  }
}
