using System;

namespace CheatSheetConsoleApp
{
  class Ex15_2_Flags
  {
    internal static void Run()
    {
      var colors = Ex15_2_Flags_Color.Red | Ex15_2_Flags_Color.Blue;
      colors.HasFlag(Ex15_2_Flags_Color.Red).Dump(); //True
      (colors == Ex15_2_Flags_Color.Red).Dump(); // False
      colors.HasFlag(Ex15_2_Flags_Color.Yellow).Dump(); // False
    }
  }
}

[Flags]
public enum Ex15_2_Flags_Color
{
	Red,
	Blue,
	Yellow
}