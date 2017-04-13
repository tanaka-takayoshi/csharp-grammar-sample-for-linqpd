using System;

namespace CheatSheetConsoleApp
{
  class Ex7_6_RefLocal
  {
    internal static void Run()
    {
      int[] array = { 1, 15, -39, 0, 7, 14, -12 };
      ref int place = ref Find(7, array);  // 値が7の配列要素の参照を取得
      place = 9;            // 参照先の配列要素の値を書き換える
      Console.WriteLine(array[4]);  // 5番目の要素の値が「7」から「9」に書き換わっている

      var a = 100;
      ref int b = ref a;  // bとaの参照は同じ
      var c = b;          // cにbのその時の値「100」を代入
      ref var d = ref b;  // dとbの参照は同じ。aとも同じ参照
      ++b;   // bに1を足すので、a／b／dとも101
      ++a;   // さらにaに1を足すので、a／b ／dとも102
      ++c;   // cに1を足して、cだけ101
      Console.WriteLine($"{a},{b},{c},{d}"); // 102,102,101,102
    }

    static ref int Find(int number, int[] numbers)
    {
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] == number)
        {
          return ref numbers[i];  // 配列の値ではなく参照を返す
        }
      }
      throw new IndexOutOfRangeException($"{nameof(number)} not found");
    }
  }
}
