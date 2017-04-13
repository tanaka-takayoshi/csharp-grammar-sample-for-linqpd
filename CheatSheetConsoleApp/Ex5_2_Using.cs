using System;
using System.Text;

namespace CheatSheetConsoleApp
{
  using MyDateTime = N2.DateTime;

  class Ex5_2_Using
  {
    internal static void Run()
    {
      // usingによりSystem.Text.StringBuilderを参照
			var sb = new StringBuilder();
			// System.DateTimeを参照
			var now = DateTime.Now;
			// namespace aliasによりCSharpCheatSheet.N2.MyDateTimeを参照
			var dateTime = new MyDateTime();
			// namespace aliasがない場合はこのように全ての参照箇所で完全修飾子が必要になる
			var dateTime2 = new N2.DateTime();
		
			sb.Dump(); // for test
			now.Dump();
			dateTime.Dump();
			dateTime2.Dump();		
    }
  }
}

namespace N2
{
	public class DateTime { }
}
