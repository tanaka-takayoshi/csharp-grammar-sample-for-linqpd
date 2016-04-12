<Query Kind="Program" />

void Main()
{
	var my = new MyClass();
	my.Run("text");
	MyClass.InternalRun();
}

public class MyClass
{

	static internal void InternalRun()
	{
		Console.WriteLine("static internal Run");
	}
	
	public void Run(string text)
	{
		Console.WriteLine(text);
	}

	protected void ProtectedRun()
	{
		Console.WriteLine("ProtectedRun");
	}

	private void PrivateRun()
	{
		Console.WriteLine("InternaRun");
	}
}
