<Query Kind="Program" />

void Main()
{
	int term = 0;
	while (term <= 3)
	{
		Console.WriteLine(term);
		++term;
	}
	
	term = 0;
	do
	{
		Console.WriteLine(term);
		++term;
	} while (term == 0);
}
