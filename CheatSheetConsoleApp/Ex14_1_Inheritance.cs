using System;

namespace CheatSheetConsoleApp
{
  class Ex14_1_Inheritance
  {
    internal static void Run()
    {
      var my = new MyClass1();
      my.Test2(); //MyClass1.Test2

      var my2 = new MyClass2();
      my2.Test2(); //1
    }
  }

  public class MyBase
  {
    public int Value { get; set; } = 0;

    public void Test1()
    {
      Console.WriteLine("MyBase.Test1");
    }

    public virtual void Test2()
    {
      Console.WriteLine("MyBase.Test2");
    }
  }

  public class MyClass1 : MyBase
  {
    public new int Value { get; set; } = 1;

    public override void Test2()
    {
      Console.WriteLine("MyClass1.Test2");
    }
  }

  public class MyClass2 : MyClass1
  {
    public override void Test2()
    {
      Console.WriteLine(Value);
    }
  }
}
