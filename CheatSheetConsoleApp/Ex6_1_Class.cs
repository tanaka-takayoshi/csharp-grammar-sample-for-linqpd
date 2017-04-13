using System;

namespace CheatSheetConsoleApp
{
  class Ex6_1_Class
  {
    internal static void Run()
    {
      new Ex6_1_Class_MyClass().Try();
    }
  }

  public class Ex6_1_Class_MyClass
  {
    public static readonly int DefaultLimit = 10;
    
    private int term;

    public Ex6_1_Class_MyClass() : this(DefaultLimit)
    {}

    public Ex6_1_Class_MyClass(int limit)
    {
      Limit = limit;
    }
    
    public int Limit { get; }

    public void Try()
    {
      term = 0;
      while (term < Limit)
      {
        Console.WriteLine($"{term}回目");
        ++term;
      }
    }
  }
}
