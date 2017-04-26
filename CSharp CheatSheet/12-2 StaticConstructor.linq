<Query Kind="Program" />

void Main()
{
	var my = new MyClass();
	//5
	my.Value.Dump();
}

public class MyClass
{
	static int DefaultValue;
	static MyClass()
	{
		//代入するだけであればフィールドの初期化子として書けるが
		//より複雑な初期化も可能
		DefaultValue = 5;
	}

	public int Value { get; set; } = DefaultValue;
}

public static class MyClass2
{
	private static int counter = 0;
	private static string counterValue;
	//C#7.0からは式形式で記述可能
	static MyClass2() => counterValue = counter.ToString();
}