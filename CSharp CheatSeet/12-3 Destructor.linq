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
