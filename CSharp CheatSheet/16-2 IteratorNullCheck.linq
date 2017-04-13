<Query Kind="Program" />

void Main()
{
	IEnumerable<int> input = null;
	var old = input.ApplyOld(x => x.ToString()); //ここではまだnullチェックされない
	try
	{	        
		//列挙が実行されて初めてApplyOld内の処理が実行され、nullチェックされる
		var array = old.ToArray();
	}
	catch (ArgumentNullException)
	{
		Console.WriteLine("NullCheck");
	}

	try
	{
		//イテレーターを返すローカル関数の場合は、メソッドを呼び出した時点でnullチェックが実行される
		var newApply = input.Apply(x => x.ToString());
	}
	catch (ArgumentNullException)
	{
		Console.WriteLine("NullCheck");
	}
}

// LINQのSelectメソッドで同一のことができるが、サンプルとして記述
static class Extensions
{
	public static IEnumerable<string> ApplyOld(this IEnumerable<int> source, Func<int, string> converter)
	{
		if (source == null) throw new ArgumentNullException(nameof(source));
		if (converter == null) throw new ArgumentNullException(nameof(converter));

		foreach (var x in source)
			yield return converter(x);
	}

	public static IEnumerable<string> Apply(this IEnumerable<int> source, Func<int, string> converter)
	{
		if (source == null) throw new ArgumentNullException(nameof(source));
		if (converter == null) throw new ArgumentNullException(nameof(converter));

		IEnumerable<string> Inner()
		{
			foreach (var x in source)
				yield return converter(x);
		}
		return Inner();
	}
}