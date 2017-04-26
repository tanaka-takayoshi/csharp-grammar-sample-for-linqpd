using System;

namespace CheatSheetConsoleApp
{
  class Ex6_5_NestedType
  {
    internal static void Run()
    {
      //protected internal なOuter1.Inner3にはアクセスできるが、
      //privateなOuter1.Inner2にはアクセスできない
      var inner = new Outer1.Inner3();
      inner.Execute();
      
      var outer = new Outer1();
      outer.Execute();
    }
  }
  
  public class Outer1
  {
    internal static void Run()
    {
      Console.WriteLine("Run");
    }
    
    public void Execute()
    {
      //包含するクラスからなのでprivateなInner2にアクセスできる
      var inner = new Inner2();
      inner.Execute();
    }

    public class Inner1
    {
      public void Execute()
      {
        //入れ子になったクラスから包含する型のprivateメソッドにアクセスできる
        Run();
      }
    }

    private class Inner2 : Inner1
    {}
    
    protected internal class Inner3 : Inner1
    {}
  }
}
