using System;

namespace CheatSheetConsoleApp
{
  class Ex7_1_Method
  {
    internal static void Run()
    {
      var my = new Ex7_1_Method_MyClass();
      my.Run("text");
      Ex7_1_Method_MyClass.InternalRun();
    }
  }

  public class Ex7_1_Method_MyClass
  {
    static internal void InternalRun()
    {
      Console.WriteLine("static internal Run");
    }
    
    public void Run(string text)
    {
      Console.WriteLine(text);
    }

    protected void ProtectedRun()
    {
      Console.WriteLine("ProtectedRun");
    }

    private void PrivateRun()
    {
      Console.WriteLine("InternaRun");
    }
  }
}
