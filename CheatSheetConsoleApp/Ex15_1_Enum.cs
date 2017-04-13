using System;

namespace CheatSheetConsoleApp
{
  class Ex15_1_Enum
  {
    internal static void Run()
    {
      var t1 = Ex15_1_Enum_Color.Red;
      t1.Dump();

      var t2 = Ex15_1_Enum_Color.Blue;
      t2.Dump();
      
      //定義されていない値をキャストすることが可能だが、非推奨
      var t3 = (Ex15_1_Enum_LongType)23;
      t3.Dump();
    }
  }
  
  public enum Ex15_1_Enum_Color
  {
    Red,
    Blue,
    Orange
  }

  public enum Ex15_1_Enum_LongType : long
  {
    Solid = int.MaxValue + 1L,
    Soft = 1,
    Hard = Solid
  }
}
