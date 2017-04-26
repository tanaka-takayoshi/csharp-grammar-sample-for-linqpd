<Query Kind="Program" />

void Main()
{
	try
	{	        
		ThrowException();
	}
	catch (MyException ex) when (ex.Value >= 1)
	{
		Console.WriteLine("Catch MyException");
	}
	catch (Exception ex)
	{
		Console.WriteLine("Catch Exception: " + ex.Message);
		throw;   // 再スロー
	}
	
}

void ThrowException()
{
	throw new MyException() {Value = 1};
}

public class MyException : Exception
{
	public int Value { get; set; }
}

//C# 7.0より例外を式としてスローできるようになった箇所
public class MyClass
{
	public string Name { get; }
	//ラムダ式や式形式メンバの=>の後
	public MyClass() => throw new Exception();
	//null合算演算子の第2オペランド
	public MyClass(string name) => Name = name ?? throw new Exception();
	//三項演算子の第2,第3オペランド
	public MyClass(int i) => Name = i > 0 ? GetNameById(i) : throw new Exception();
	private string GetNameById(int i) => $"name-{i}";
}