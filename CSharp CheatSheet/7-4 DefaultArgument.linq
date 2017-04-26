<Query Kind="Program" />

void Main()
{
	//x=1 y=a
	Test(1);
	//x=2 y=b
	Test(2, "b");
}

static void Test(int x, string y = "a")
{
	Console.WriteLine($"x={x} y={y}");
}