<Query Kind="Program" />

void Main()
{
	var i = 1;
	var j = 2;
	Swap(ref i, ref j);
	//2
	i.Dump();
	//1
	j.Dump();
	
	var k = 0;
	int l;
	//初期化済みの値、未初期化の値両方利用できる
	Out(out k, out l);
	//1
	k.Dump();
	//2
	l.Dump();
}

static void Swap(ref int x, ref int y)
{
	var temp = x;
	x = y;
	y = temp;
}

static void Out(out int x, out int y)
{
	x = 1;
	y = 2;
}
