using System;

namespace CheatSheetConsoleApp
{
  class Ex2_3_StringInterpolation
  {
    internal static void Run()
    {
      var name = "テスト";
      var s1 = $@"名前は
{name}";
      s1.Dump();
      
      var s2 = $"Now: {DateTime.Now :f}";
      s2.Dump();
    }
  }
}
