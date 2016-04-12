<Query Kind="Program" />

void Main()
{
	var f1 = 1 == 2; //False
	f1.Dump();
	var f2 = 1 != 1; //False
	f2.Dump();
	var f3 = new object() == new object(); //False
	f3.Dump();
	var f4 = "abc" == string.Copy("a") + "bc"; //True
	f4.Dump();
}

// Define other methods and classes here