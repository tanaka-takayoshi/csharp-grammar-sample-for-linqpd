<Query Kind="Program" />

void Main()
{
	var f1 = True() || False(); //True is called: True
	f1.Dump();
	var f2 = True() | False(); // True is called: False is called: True
	f2.Dump();

	var f3 = False() && True(); // False is called: False
	f3.Dump();
	var f4 = False() & True(); // False is called: True is called: False
	f4.Dump();
}

static bool True()
{
	Console.Write("True is called: ");
	return true;
}

static bool False()
{
	Console.Write("False is called: ");
	return false;
}