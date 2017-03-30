<Query Kind="Program" />

void Main()
{
	if (Out(out var x1, out var y1))
		Console.WriteLine($"x={x1}, y={y1}"); //x=1, y=2
	//x1とy1のスコープはifを含むステートメント内
	Console.WriteLine($"x={x1}, y={y1}"); //x=1, y=2
	
	//_で使わない変数を読み捨てることができる
	if (Out(out int x2, out var _))
		Console.WriteLine($"x={x1}"); //x=1
	//読み捨てに利用する識別子_は明示的に宣言した変数の識別子_とは別物
	var _ = 1;
	Console.WriteLine($"_={_}"); //_=1
}

static bool Out(out int x, out int y)
{
	x = 1;
	y = 2;
	return true;
}