<Query Kind="Program" />

void Main()
{
	// 匿名関数で再帰する場合は最初に宣言しないといけない
	Func<int, int> f2 = null;
	f2 = n => (n >= 1) ? (n * f2(n - 1)) : 1;
	var res = f2(3);
	Console.WriteLine(res);

	// ローカル関数は通常の関数同様再帰を記述できる
	int f(int x) => x >= 1 ? x * f(x - 1) : 1;
	// ローカル関数を暗黙的に型宣言するとコンパイルエラー
	//var f3(int x) => x >= 1 ? x * f(x - 1) : 1;
	res = f(3);
	Console.WriteLine(res);

	// ローカル関数内でお互いの関数を呼び出すコードは記述できる
	// が、無限に再帰する場合は実行時エラーとなる
	void Add(int x, int y)
	{
		Console.WriteLine($"{x} + {y} = {x + y}");
		Multiply(x, y);
	}
	void Multiply(int x, int y)
	{
		Console.WriteLine($"{x} * {y} = {x * y}");
		Add(30, 10);
	}
	Add(2, 3);
}

