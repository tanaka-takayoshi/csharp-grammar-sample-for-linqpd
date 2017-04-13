<Query Kind="Program" />

void Main()
{
	var a = new N1.A();
	var b = new N1.N2.B();
	var c = new N1.N2.C();
	a.Dump(); //for test
	b.Dump();
	c.Dump();
}

} // コンテキストであるUserQeryクラスのスコープを閉じる（※LINQPad実行用）

// ★以下にクラスメソッドなど自由に定義できる★

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

partial class UserQuery { // コンテキストのスコープを再び開く