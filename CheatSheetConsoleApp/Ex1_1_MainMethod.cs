using System;

namespace CheatSheetConsoleApp
{
  class Ex1_1_MainMethod
  {
    internal static void Run()
    {
      // 標準出力。Console.Out.WriteLineも同じ
      Console.WriteLine("こんにちは、C#!");
      // 標準エラー出力
      Console.Error.WriteLine("こんにちは、C#!");
      // Visual Studioなどからデバッグ実行するときなどは、コンソールウインドウがすぐに閉じるのを防ぐために入力を待つとよい
      //Console.ReadLine();
    }
  }
}
