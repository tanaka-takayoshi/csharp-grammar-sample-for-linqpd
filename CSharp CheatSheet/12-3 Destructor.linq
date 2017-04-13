<Query Kind="Program" />

void Main()
{
	var my = new MyClass();
	my = null;
	GC.Collect();
	GC.WaitForPendingFinalizers(); // Destruct
}

public class MyClass
{
	// デストラクター
	~MyClass()
	{
		Console.WriteLine("Destruct");
	}
}

public class MyClass2
{
	private static int counter = 0;
	//C#7.0からは式形式で記述可能
	~MyClass2() => --counter;
}