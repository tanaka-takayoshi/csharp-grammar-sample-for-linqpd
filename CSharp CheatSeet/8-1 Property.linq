<Query Kind="Program" />

void Main()
{
	var my = new MyClass();
	my.Value1 = 3;
}

public class MyClass
{
	private int value1;
	public int Value1
	{
		get
		{
			return value1;
		}
		set
		{
			if (value != value1)
			{
				value1 = value;
				ValueChanged();
			}
		}
	}

	private void ValueChanged()
	{
		Console.WriteLine("ValueChanged");
	}
}