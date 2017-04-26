using System;
using System.Threading.Tasks;

namespace CheatSheetConsoleApp
{
  class Ex20_2_ValueTask
  {
    internal static void Run()
    {
      async Task Inner()
      {
        var res = await SearchAsync(100);
        Console.WriteLine(res);
        res = await SearchAsync(1);
        Console.WriteLine(res);
      }
      Inner().GetAwaiter().GetResult();
    }

    static async ValueTask<int> SearchAsync(int a)
    {
      if (a != 100)
        return 0;
      await Task.Delay(1000);
      return 1;
    }
  }
}
