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