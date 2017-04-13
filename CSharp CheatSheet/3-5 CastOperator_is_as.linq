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

	//C# 7.0で導入されたis演算子の拡張 
	int? i = 1;
	if (i is null) return; // aがnullのときのみtrueとなる constant pattern "null"
	if (i is int.MaxValue) return; // aがint.MaxValueと等しいときのみtrueとなる constant pattern
	if (i is 3) return; 
	if (!(i is int j)) // type pattern "int j"
	{
		//j.Dump(); // is演算子の評価結果がtrueのときのみ変数が割り当てられるので、ここでiを参照するとコンパイルエラー
		return;
	}
	
	new string('*', j).Dump(); // 上のif文でis演算子の評価結果がfalseのときにreturnもしくは例外をスローせずにiを参照すると、確実に代入される保証がないのでコンパイルエラーになる
	
	string str = null;
	if (str is var k) // var patternはnullのときも含め常にtrueとなり割り当てられる
	{
		k.Dump();
	}

	//null合算演算子とtype patternの組み合わせ。nullでないときのみ変数を割り当てられる
	var a2 = new A();
	if (a2?.Inner.Value is int l)
		new string('*', l).Dump();
}

class A { public AnotherObject Inner { get; set; } = new AnotherObject {Value=5}; }
class B : A { public void Test() { Console.WriteLine("I'm B."); } }
class C { }
class AnotherObject { public int Value { get; set; } }