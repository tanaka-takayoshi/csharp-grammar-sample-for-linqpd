<Query Kind="Program" />

void Main()
{
	new MyClass().Try();
}

public class MyClass
{
	public static readonly int DefaultLimit = 10;
	
	private int term;

	public MyClass() : this(DefaultLimit)
	{}

	public MyClass(int limit)
	{
		Limit = limit;
	}
	
	public int Limit { get; }

	public void Try()
	{
		term = 0;
		while (term < Limit)
		{
			Console.WriteLine($"{term}回目");
			++term;
		}
	}
}