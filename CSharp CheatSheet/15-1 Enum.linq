<Query Kind="Program" />

void Main()
{
	var t1 = Color.Red;
	t1.Dump();

	var t2 = Color.Blue;
	t2.Dump();
	
	//定義されていない値をキャストすることが可能だが、非推奨
	var t3 = (LongType)23;
	t3.Dump();
}

public enum Color
{
	Red,
	Blue,
	Orange
}

public enum LongType : long
{
	Solid = int.MaxValue + 1L,
	Soft = 1,
	Hard = Solid
}