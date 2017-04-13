using System;

namespace CheatSheetConsoleApp
{
  class Ex7_5_ExtensionMethod
  {
    internal static void Run()
    {
      var s = "abcd";
      var text = "CD";
      //true
      s.ContainsIgnoreCase(text).Dump();  
    }
  }
  
  public static class MyExtensions
  {
    public static bool ContainsIgnoreCase(this string s, string text)
    {
      return s.ToLower().Contains(text.ToLower());
    }
  }
}
