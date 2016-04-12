<Query Kind="Program" />

void Main()
{
	var my = new MyClass();
	my[1] = 100;
	my[1].Dump();
	my["test"].Dump();
}

public class MyClass
{
	private int[] array = new int[100];
	private Dictionary<string, int> dict = new Dictionary<string, int>();
     
	public int this[int i]
	{
		get
		{
			return array[i];
		}
		set
		{
			array[i] = value;
		}
	}
	
	public int this[string s] => dict.ContainsKey(s) ? dict[s] : 0;
}