using System;

namespace CheatSheetConsoleApp
{
  class Ex6_3_Partial
  {
    internal static void Run()
    {
      var my = new Ex6_3_Partial_MyClass();
      my.Test();
      my.Test2();
    }
  }

  public partial class Ex6_3_Partial_MyClass
  {
    public void Test()
    {
      Console.WriteLine("Test");
    }
  }

  public partial class Ex6_3_Partial_MyClass
  {
    public void Test2()
    {
      Console.WriteLine("Test2");
    }
  }
}
