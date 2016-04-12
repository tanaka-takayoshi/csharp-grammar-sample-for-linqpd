<Query Kind="Program" />

void Main()
{
	var b = new B();
	var c = new C();
	
	var f0 = b is B; //True
	f0.Dump();
	var f1 = b is A; //True
	f1.Dump();
	var f2 = c is A; //False
	f2.Dump();
	
	//A型の変数として宣言
	A a = new B();

	// is で型チェック後キャストする
	if (a is B)
	{
		((B)a).Test(); //I'm B
    }

	//is+キャストはas+nullチェックで代用可能。
	//なお、asの方が効率的なコードをコンパイラが出力する
	var b2 = a as B;
	if (b2 != null)
	{
		b2.Test(); //I'm B
	}
	
	//nullチェックはnull条件演算子で置き換えることも可能
	(a as B)?.Test(); //I'm B
}

class A { }
class B : A { public void Test() { Console.WriteLine("I'm B."); } }
class C { }