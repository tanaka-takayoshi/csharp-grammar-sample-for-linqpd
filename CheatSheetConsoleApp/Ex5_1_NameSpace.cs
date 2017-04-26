using System;

namespace CheatSheetConsoleApp
{
  class Ex5_1_NameSpace
  {
    internal static void Run()
    {
      var a = new N1.A();
      var b = new N1.N2.B();
      var c = new N1.N2.C();
      a.Dump(); //for test
      b.Dump();
      c.Dump();
    }
  }
}


namespace N1
{
	class A {}

	namespace N2
	{
		class C {}
	}
}

namespace N1.N2
{
	class B { }
}

