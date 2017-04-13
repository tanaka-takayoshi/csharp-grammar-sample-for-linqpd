using System;

namespace CheatSheetConsoleApp
{
  class Ex13_1_Struct
  {
    internal static void Run()
    {
      var p1 = new Ex13_1_Struct_Point(10);
      //参照ではなく、コピーした値がp2に割り当てられる
      var p2 = p1;
      //p1のプロパティを更新してもp2には影響がない
      p1.X = 1;
      p1.Dump(); //p1.X=1
      p2.Dump(); //p2.X=10

      //構造体をデフォルト値はnullではない
      var points = new Point[10];
      //point[0].X=0
      points[0].Dump();
    }
  }
  
  struct Ex13_1_Struct_Point
  {
    private int x;
    public int X
    {
      get { return x; }
      set { x = value; }
    }
    public Ex13_1_Struct_Point(int x)
    {
      this.x = x;
    }
  }

}
