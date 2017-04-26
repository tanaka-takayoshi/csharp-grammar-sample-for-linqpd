using System;

namespace CheatSheetConsoleApp
{
  class Ex7_2_Ref_Out
  {
    internal static void Run()
    {
      var i = 1;
      var j = 2;
      Swap(ref i, ref j);
      //2
      i.Dump();
      //1
      j.Dump();
      
      var k = 0;
      int l;
      //初期化済みの値、未初期化の値両方利用できる
      Out(out k, out l);
      //1
      k.Dump();
      //2
      l.Dump();
      
      var str = "1";
      //m.Dump();
      if (int.TryParse(str, out var m))
        m.Dump();
      m.Dump();

      var str2 = "123";
      if (int.TryParse(str, out var _))
        Console.WriteLine($"{str2} is integer.");
    }

    static void Swap(ref int x, ref int y)
    {
      var temp = x;
      x = y;
      y = temp;
    }

    static void Out(out int x, out int y)
    {
      x = 1;
      y = 2;
    }
  }
}
