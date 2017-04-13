using System;

namespace CheatSheetConsoleApp
{
  class Ex3_1_ArithmeticOperator
  {
    internal static void Run()
    {
      //加算
      var x0 = 1 + 4; // 5
      x0.Dump();
      //int + double は double + doubleとして加算。結果もdouble 
      var x1 = 1 + 2.5d; // = 3.5
      x1.Dump();
      //int - long は long - long 
      var x2 = int.MinValue - 1L; // = -2147483649
      x2.Dump();
      //乗算
      var x3 = 2 * 4; // = 8
      x3.Dump();
      //uncheckedコンテキストではオーバーフローしても処理が続行される
      //int.MaxValue * 2L だと 4294967294L
      unchecked
      {
        var x4 = int.MaxValue * 2; //  = -2
        x4.Dump();
      }
      //整数の除算は演算結果も整数 
      var x5 = 7 / 2; // = 3
      x5.Dump();
      //割られる数がdoubleであれば演算結果もdoubleになる 
      var x6 = 7f / 2; // = 3.5
      x6.Dump();
      //割る数がdoubleの場合もdouble型の除算が行われる 
      var x7 = 7 / 2.0; // = 3.5
      x7.Dump();
      //剰余 
      var x8 = 7 % 2; // = 1
      x8.Dump();
      //浮動小数点 
      var x9 = 7f % 2.1; // = 0.7
      x9.Dump();
    }
  }
}
