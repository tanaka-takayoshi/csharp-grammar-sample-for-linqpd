<Query Kind="Program" />

void Main()
{
	var f1 = true;
	var t1 = f1 ? "true" : "false"; //true
	t1.Dump();

	var f2 = false;
	var t2 = f2 ? "true" : "false"; //false
	t2.Dump();
	
	string v1 = null;
	var t3 = v1 ?? "default"; //default
	t3.Dump();

	string v2 = "text";
	var t4 = v2 ?? "default"; //text
	t4.Dump();
}