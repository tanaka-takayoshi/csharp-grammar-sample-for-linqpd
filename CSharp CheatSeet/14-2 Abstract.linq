<Query Kind="Program" />

void Main()
{
	var my = new MyClass();
	my.Test1(); // MyAbstractClass.Test1
	my.Test2(); // MyClass.Test2
	my.Test3(); // MyClass.Test3

	var my2 = new MyClass2();
	my2.Test1(); // MyAbstractClass.Test1
	my2.Test2(); // MyClass2.Test2
	my2.Test3(); // MyClass.Test3
}

public abstract class MyAbstractClass
{
	public void Test1()
	{
		Console.WriteLine("MyAbstractClass.Test1");
	}
	
	public abstract void Test2();
	
	public abstract void Test3();
}

public class MyClass : MyAbstractClass
{
	public override void Test2()
	{
		Console.WriteLine("MyClass.Test2");
	}

	public sealed override void Test3()
	{
		Console.WriteLine("MyClass.Test3");
	}
}

public sealed class MyClass2 : MyClass
{
	public override void Test2()
	{
		Console.WriteLine("MyClass2.Test2");
	}
}