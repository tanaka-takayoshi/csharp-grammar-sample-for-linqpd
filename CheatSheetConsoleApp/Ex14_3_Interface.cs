using System;

namespace CheatSheetConsoleApp
{
  class Ex14_3_Interface
  {
    internal static void Run()
    {
      var s1 = new Surface();
      s1.Name = "a";
      s1.Paint(); // Paint
      ((ISurface)s1).Paint(); // Paint
      ((IPaintable)s1).Paint(); // Paint

      var s2 = new Surface2();
      s2.Paint(); // Paint
      ((ISurface)s2).Paint(); // Paint
      ((IPaintable)s2).Paint(); // IPaintable.Paint
    }
  }
  
  interface IPaintable
  {
    void Paint();
  }

  interface ISurface
  {
    string Name { get; set; }
    void Paint();
  }

  public class Surface : ISurface, IPaintable
  {
    public string Name { get; set; }
    public void Paint()
    {
      Console.WriteLine("Paint");
    }
  }

  public class Surface2 : ISurface, IPaintable
  {
    public string Name { get; set; }
    public void Paint()
    {
      Console.WriteLine("Paint");
    }

    void IPaintable.Paint()
    {
      Console.WriteLine("IPaintable.Paint");
    }
  }
}
