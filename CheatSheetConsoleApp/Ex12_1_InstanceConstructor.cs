using System;

namespace CheatSheetConsoleApp
{
  class Ex12_1_InstanceConstructor
  {
    internal static void Run()
    {
      var my1 = new Ex12_1_InstanceConstructor_MyClass();
      //0
      my1.Value.Dump();

      var my2 = new Ex12_1_InstanceConstructor_MyClass(2);
      //2
      my2.Value.Dump();
    }
  }

  public class Ex12_1_InstanceConstructor_MyClass
  {
    public int Value { get; set; }
    
    public Ex12_1_InstanceConstructor_MyClass() : this(0)
    {}

    public Ex12_1_InstanceConstructor_MyClass(int v)
    {
      Value = v;
    }
    
  }

  //singletonパターンなど、コンストラクタ呼び出しを公開したくない場合はprivateにできる
  public class Ex12_1_InstanceConstructor_MyClass2
  {
    public static Ex12_1_InstanceConstructor_MyClass2 Instance = new Ex12_1_InstanceConstructor_MyClass2();

    private Ex12_1_InstanceConstructor_MyClass2()
    {}
  }

  public class Ex12_1_InstanceConstructor_MyClass3
  {
    private static int counter = 0;
    public Ex12_1_InstanceConstructor_MyClass3() => ++counter;
  }
}
