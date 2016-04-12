<Query Kind="Program" />

void Main()
{
	var flg = true;
	//true
	if (flg)
		Console.WriteLine("true");

	//else if
	if (Check())
	{
		Console.WriteLine("if");
	}
	else if (flg)
	{
		Console.WriteLine("else if");
	}
	else
	{
		Console.WriteLine("else");
	}
}

static bool Check()
{
	return false;
}

// Define other methods and classes here