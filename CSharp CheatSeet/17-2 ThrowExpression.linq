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