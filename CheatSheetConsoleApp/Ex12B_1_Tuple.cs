using System;
using System.Linq;

namespace CheatSheetConsoleApp
{
  class Ex12B_1_Tuple
  {
    internal static void Run()
    {
      // 文字列を全て小文字にしたものと全て大文字にしたものを取得する
      var texts = new[] { "aaA", "bBb", "cCC" };

      // 匿名オブジェクトを利用	
      foreach (var text in texts.Select(x => new { lower = x.ToLower(), upper = x.ToUpper() }))
      {
        Console.WriteLine(text);
      }

      // Tupleを利用
      foreach (var text in texts.Select(x => new Tuple<string, string>(x.ToLower(), x.ToUpper())))
      {
        Console.WriteLine(text);
      }

      // C# 7.0のタプルを利用
      foreach (var text in texts.Select(Convert))
      {
        Console.WriteLine($"lower={text.lower}, upper={text.upper}");
      }

      var str1 = "aaAA";
      // タプルリテラルで宣言
      var t1 = (str1.ToLower(), str1.ToUpper()); // 要素名は任意なのでつけなくてもよい
      Console.WriteLine($"Item1={t1.Item1}"); //つけない場合はC#6.0以前のタプルと同様のItemNという名前で参照
      var t2 = (lower: str1.ToLower(), upper: str1.ToUpper());
      // new形式はコンパイルエラー
      //var t3 = new (int, int)(0, 1);
      var t4 = (lower: str1.ToLower(), str1.ToUpper()); // 一部のみ要素名を省略することも可
      Console.WriteLine($"{t4.lower}, {t4.Item2}");
      // 同じ要素名で重複するとコンパイルエラー
      //var t5 = (lower: text.ToLower(), lower: text.ToLower());
    }

    static (string lower, string upper) Convert(string text)
    {
      return (lower: text.ToLower(), upper: text.ToUpper());
    }
  }  
}
