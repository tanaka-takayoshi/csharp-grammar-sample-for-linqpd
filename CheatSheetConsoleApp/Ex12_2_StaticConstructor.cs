using System;

namespace CheatSheetConsoleApp
{
  class Ex12_2_StaticConstructor
  {
    internal static void Run()
    {
      var my = new Ex12_2_StaticConstructor_MyClass();
      //5
      my.Value.Dump();
    }
  }

  public class Ex12_2_StaticConstructor_MyClass
  {
    static int DefaultValue;
    static Ex12_2_StaticConstructor_MyClass()
    {
      //代入するだけであればフィールドの初期化子として書けるが
      //より複雑な初期化も可能
      DefaultValue = 5;
    }

    public int Value { get; set; } = DefaultValue;
  }

  public static class Ex12_2_StaticConstructor_MyClass2
  {
    private static int counter = 0;
    private static string counterValue;
    //C#7.0からは式形式で記述可能
    static Ex12_2_StaticConstructor_MyClass2() => counterValue = counter.ToString();
  }
}
