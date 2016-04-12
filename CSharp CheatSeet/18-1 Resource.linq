<Query Kind="Program" />

void Main()
{
	var resource = new MyResource();
	try
	{	        
		resource.Execute();
	}
	finally
	{
		resource.Close();
	}
	
	using (var r1 = new MyDisposableResource())
	using (var r2 = new MyDisposableResource())
	{
		r1.Execute();
		r2.Execute();
	}
}

public class MyResource
{
	public void Execute()
	{
		Console.WriteLine("MyResource.Execute");
	}

	public void Close()
	{
		Console.WriteLine("MyResource.Close");
	}
}

public class MyDisposableResource : IDisposable
{
	public void Execute()
	{
		Console.WriteLine("MyDisposableResource.Execute");
	}

	public void Dispose()
	{
		Console.WriteLine("MyDisposableResource.Dispose");
	}
}

