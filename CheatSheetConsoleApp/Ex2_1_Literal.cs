using System;

namespace CheatSheetConsoleApp
{
  class Ex2_1_Literal
  {
    internal static void Run()
    {
      //bool型
      var flg1 = true;
      var flg2 = false;

      //int, uint, long, ulong のうち表現できる最初の型。この場合はint型
      var int1 = 1;
      //uまたはUサフィックスを付けた場合はuintもしくはulongのうち表現できる最初の型。この場合はuint型
      var int2 = 1U;
      //lまたはLサフィックスを付けた場合はlongもしくはulongのうち表現できる最初の型。この場合はuint型
      var int3 = 1L;
      //ulもしくはULサフィックスを付けた場合はulong型
      var int4 = 1UL;

      //単精度浮動小数点
      var number1 = 1f;
      //指数表記
      var number2 = 1.2e-3f;
      //倍精度浮動小数点
      var number3 = 1d;
      //指数表記
      var number4 = 1.2e-3d;
      //高精度小数(decimal型)
      var number5 = 0.1m;

      var char1 = '1';
      var char2 = '\'';
      var char3 = '\xFFFF';
      char2.Dump();

      //C# 7.0で導入された桁区切り
      var int5 = 1_000_000;
      //_は先頭と最後以外であれば任意の場所に任意の数だけ使える
      var int6 = 1_000__00000_0UL;
      //小数部にも使える
      var number6 = 0.00_00__01f;
      var numbder7 = 100__00_0.0__1m;

      //16進数表記は従来から利用可能
      var int7 = 0xdeadbeaf;
      //C# 7.0より2進表記が利用可能に
      var int8 = 0b10011100;
      //C# 7.0より16進表記や2進表記と桁区切りも併せて利用可能
      var int9 = 0xdead_beaf;
      var int10 = 0b1001_1000_1111;
    }
  }
}
