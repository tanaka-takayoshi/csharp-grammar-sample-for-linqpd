using System;

namespace CheatSheetConsoleApp
{
  class Ex4_2b_SwitchWithPattern
  {
    internal static void Run()
    {
      object shape = new Circle(4);
      switch (shape)
      {
        // C# 6.0以前のcase節
        case 0:
          Console.WriteLine("should not be '0'");
          break;
        // C# 6.0以前のcaseにガード節追加
        case 1 when IsDebug(shape):
          Console.WriteLine("should not be '1' if debug is enabled");
          break;
        // type pattern
        // case Circle: のようにプリミティブでない型をC# 6.0以前のように記述するとコンパイルエラー。変数宣言として記述しないといけない
        case Circle c:
          Console.WriteLine($"circle with radius {c.Radius}");
          break;
        // type patternにガード節
        case Rectangle s when (s.Length == s.Height):
          Console.WriteLine($"{s.Length} x {s.Height} square");
          break;
        // 上のガード節に一致しない場合のtype pattern
        case Rectangle r:
          Console.WriteLine($"{r.Length} x {r.Height} rectangle");
          break;
        // var パターンも利用可能
        case var i when IsDebug(i):
          Console.WriteLine("debug is enabled.");
          break;
        default:
          Console.WriteLine("<unknown shape>");
          break;
      }
    }

    private static bool IsDebug(object i) => i is 1;
  }

  class Circle
  {
    public int Radius { get; set; }
    public Circle(int r)
    {
      Radius = r;
    }
  }

  class Point
  {
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y) { X = x; Y = y; }
  }

  class Rectangle
  {
    public int Height { get; }
    public int Length { get; }
    public Rectangle(int h, int l)
    {
      Height = h;
      Length = l;
    }
  }
}