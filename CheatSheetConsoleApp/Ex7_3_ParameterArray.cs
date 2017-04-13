using System;

namespace CheatSheetConsoleApp
{
  class Ex7_3_ParameterArray
  {
    internal static void Run()
    {
      var array = new[] {1,2,3};
      //3個の引数が指定されました
      Param(array);
      //2個の引数が指定されました
      Param(1, 2);
      //0個の引数が指定されました
      Param();
    }

    static void Param(params int[] array)
    {
      Console.WriteLine($"{array.Length}個の引数が指定されました");
    }
  }
}
