using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CheatSheetConsoleApp
{
  class Ex20_1_Async
  {
    internal static void Run()
    {
      //Mainメソッドはasyncにできない
      //非同期メソッドを同期的に待機する場合、GetAwaiter().GetResult() が使える
      ExecuteAsync().GetAwaiter().GetResult();
    }
    static async Task ExecuteAsync()
    {
      var sw = Stopwatch.StartNew();
      //2秒待機
      await TestAsync();
      sw.Stop();
      //await: 2 [sec]
      Console.WriteLine($"await: {sw.Elapsed.Seconds} [sec]");
      sw.Restart();
      //この時点では待機しない
      var task = TestAsync();
      //未await: 0 [sec]
      Console.WriteLine($"未await: {sw.Elapsed.Seconds} [sec]");
      await task;
      //await: 2 [sec]
      Console.WriteLine($"await: {sw.Elapsed.Seconds} [sec]");
      sw.Restart();
      //一度完了したTaskをawaitすると、すぐに完了する
      await task;
      //再await: 0 [sec]
      Console.WriteLine($"再await: {sw.Elapsed.Seconds} [sec]");
      
      var task2 = TestAsync();
      sw.Restart();
      
      sw.Restart();
      //async void メソッドを呼んでも待機しない
      VoidAsync();
      //async void: 0 [sec]
      Console.WriteLine($"async void: {sw.Elapsed.Seconds} [sec]");
      
      sw.Restart();
      var r1 = await TestAsync2();
      //await Task<int>: Result=1 2 [sec]
      Console.WriteLine($"await Task<int>: Result={r1} {sw.Elapsed.Seconds} [sec]");

      var t2 = TestAsync2();
      sw.Restart();
      //Task<T> のResultプロパティで結果を取得できるが、プロパティアクセスで待機することになる
      var r2 = t2.Result;
      //Get Task<int>.Result: Result=1 2 [sec]
      Console.WriteLine($"Get Task<int>.Result: Result={r2} {sw.Elapsed.Seconds} [sec]");

      sw.Restart();
      //await同様、一度完了したTaskのResultプロパティは待機せずに取得できる
      var r3 = t2.Result;
      //Get Task<int>.Result again: Result=1 0 [sec]
      Console.WriteLine($"Get Task<int>.Result again: Result={r3} {sw.Elapsed.Seconds} [sec]");
    }

    static async Task TestAsync()
    {
      await Task.Delay(TimeSpan.FromSeconds(2));
    }

    static async void VoidAsync()
    {
      await Task.Delay(TimeSpan.FromSeconds(2));
    }

    static async Task<int> TestAsync2()
    {
      await Task.Delay(TimeSpan.FromSeconds(2));
      return 1;
    }
  }
}
