using System;
using System.Collections.Generic;

namespace CheatSheetConsoleApp
{
  class Ex2_4_Array
  {
    internal static void Run()
    {
      //要素数を指定して配列を初期化
      var array1 = new int[2];
      array1.Dump();
      array1[1].Dump(); // 0 (intのデフォルト値)

      //要素を指定して配列を初期化
      var array2 = new[] { 1, 2, 3 };
      array2.Dump();

      //プロパティ、フィールドなど左辺に型を記述する場合、new[] は不要
      double[] array3 = { 1d, 2.3d };
      array3.Dump();

      //配列は IList<T> を実装している
      IList<string> list3 = new[] { "A", "B" };
      list3.Dump();

      //2次元配列
      var array5 = new[,] { { 1, 2 }, { 3, 4 }};
      array5.Dump();
      array5[1,0].Dump();

      //配列の配列
      var array6 = new[] { new[] { 1, 3, 5 }, new[] { 2, 4, 6, 8 }};
      array6.Dump();
      array6[1][3].Dump();
    }
  }
}
