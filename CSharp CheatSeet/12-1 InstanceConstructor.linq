<Query Kind="Program" />

void Main()
{
	var my1 = new MyClass();
	//0
	my1.Value.Dump();

	var my2 = new MyClass(2);
	//2
	my2.Value.Dump();
}

public class MyClass
{
	public int Value { get; set; }
	
	public MyClass() : this(0)
	{}

	public MyClass(int v)
	{
		Value = v;
	}
	
}

//singletonパターンなど、コンストラクタ呼び出しを公開したくない場合はprivateにできる
public class MyClass2
{
	public static MyClass2 Instance = new MyClass2();

	private MyClass2()
	{}
}
