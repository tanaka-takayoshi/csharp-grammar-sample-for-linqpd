<Query Kind="Program" />

void Main()
{
	//a b c z
	MyCollection.GetSamples().Dump();
	//1, 9, 25, 49, 81
    foreach (var element in new MyCollection())
	{
		Console.WriteLine(element);
	}
}

public class MyCollection : IEnumerable<int>
{
	public static IEnumerable<string> GetSamples()
	{
		yield return "a";
		yield return "b";
		yield return "c";
		yield return "z";
	}

	public IEnumerator<int> GetEnumerator()
	{
		for (int i = 0; i < 10; i++)
		{
			if (i % 2 == 0)
				continue;
				
			yield return i * i;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}