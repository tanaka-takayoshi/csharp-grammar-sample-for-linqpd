using System;

namespace CheatSheetConsoleApp
{
  class Ex8_1_Property
  {
  internal static void Run()
    {
      var my = new Ex8_1_Property_MyClass();
      my.Value1 = 3;
    }
  }

  public class Ex8_1_Property_MyClass
  {
    private int value1;
    public int Value1
    {
      get
      {
        return value1;
      }
      set
      {
        if (value != value1)
        {
          value1 = value;
          ValueChanged();
        }
      }
    }

    private void ValueChanged()
    {
      Console.WriteLine("ValueChanged");
    }

    private int value2;
    //C# 7.0より式形式で記述可能
    public int Value2
    {
      get => value2;                 // getterはC# 6.0より可能
      set => value2 = value;         // setter
    }
  }
}
