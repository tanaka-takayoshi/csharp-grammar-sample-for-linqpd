<Query Kind="Program" />

void Main()
{
	var f1 = 1 > 1; // False
	f1.Dump();
	var f2 = 1 >= 1; // True
	f2.Dump();
	var f3 = 1 < 2; // True
	f3.Dump();
	var f4 = 1 <= 2; // True
	f4.Dump();
}

// Define other methods and classes here
