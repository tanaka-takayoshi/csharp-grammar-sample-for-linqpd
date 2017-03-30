<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	async Task Inner()
	{
		var res = await SearchAsync(100);
		Console.WriteLine(res);
		res = await SearchAsync(1);
		Console.WriteLine(res);
	}
	Inner().GetAwaiter().GetResult();
}

async ValueTask<int> SearchAsync(int a)
{
	if (a != 100)
		return 0;
	await Task.Delay(1000);
	return 1;
}