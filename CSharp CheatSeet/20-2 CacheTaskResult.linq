<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	//Mainメソッドはasyncにできない
	//非同期メソッドを同期的に待機する場合、GetAwaiter().GetResult() が使える
	ExecuteAsync().GetAwaiter().GetResult();
}

static async Task ExecuteAsync()
{
	//"Executing time consuming method..." は最初の１回のみ表示され
	//２回目以降はキャッシュされたTaskをすぐに返している
	var r1 = await GetAsync();
	var r2 = await GetAsync();
	var r3 = await GetAsync();
}

static Task<int> cache;

static Task<int> GetAsync()
{
	async Task<int> inner()
	{
		Console.WriteLine("Executing time consuming method...");
		await Task.Delay(3000);
		return 1;
	}
	cache = cache ?? inner();
	return cache;
}