<Query Kind="Program" />

void Main()
{
	var my = new MyClass();
	my.Dump();
	my.UpdateValue1();
	my.Value2 = 12;
	my.Dump();
}

public class MyClass
{
	public int Value1 { get; private set; }
	
	public int Value2 { get; set; } = 2;
	
	public int Value3 { get; }

	public MyClass()
	{
		//getter only プロパティはコンストラクタでも代入可能
		Value3 = 3;
	}

	public void UpdateValue1()
	{
		//privateなsetterなのでインスタンス内から変更可能
		//Value3は更新できない
		Value1 = 1;
	}
}