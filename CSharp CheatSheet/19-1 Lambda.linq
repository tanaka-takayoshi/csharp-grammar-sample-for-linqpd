<Query Kind="Program" />

void Main()
{
	Action a1 = () => 
	{
		Console.WriteLine("Action");
	};
	//Action
	a1();
	Action<int> a2 = i => Console.WriteLine(i);
	//2
	a2(2);
	
	Func<int> f1 = () => 1;
	//1
	f1().Dump();
	Func<string, string, int> f2 = (s1, s2) => int.Parse(s1 + s2);
	//54
	f2.Invoke("5", "4").Dump();

	//LINQ
	//9,1
	new[] {1, 3, 5}
	.Where(i => i <= 3)
	.Select(i => i * i)
	.OrderByDescending(i => i)
	.Dump();

	//イベント
	Changed += (s, ea) => {Console.WriteLine("OnChanged");};
}

event EventHandler Changed;
