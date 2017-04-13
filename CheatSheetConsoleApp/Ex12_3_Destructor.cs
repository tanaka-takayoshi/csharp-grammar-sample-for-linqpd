using System;

namespace CheatSheetConsoleApp
{
  class Ex12_3_Destructor
  {
    internal static void Run()
    {
      var my = new Ex12_3_Destructor_MyClass();
      my = null;
      GC.Collect();
      GC.WaitForPendingFinalizers(); // Destruct
    }
  }

  public class Ex12_3_Destructor_MyClass
  {
    // デストラクター
    ~Ex12_3_Destructor_MyClass()
    {
      Console.WriteLine("Destruct");
    }
  }

  public class Ex12_3_Destructor_MyClass2
  {
    private static int counter = 0;
    //C#7.0からは式形式で記述可能
    ~Ex12_3_Destructor_MyClass2() => --counter;
  }
}
