<Query Kind="Program" />

void Main()
{
	var array = new [] {1,2,3,4,5};
	//奇数の時は次の繰り返しへ
	//4のときにforeachを終了させるため
	//出力されるのは2のみ
	foreach (var e in array)
	{
		if (e % 2 == 1)
			continue;
		if (e == 4)
			break;
		Console.WriteLine(e);
	}
}

