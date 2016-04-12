<Query Kind="Program" />

void Main()
{
	var my = new MyClass();
	my.Test();
	my.Test2();
}

public partial class MyClass
{
	public void Test()
	{
		Console.WriteLine("Test");
	}
}

public partial class MyClass
{
	public void Test2()
	{
		Console.WriteLine("Test2");
	}
}