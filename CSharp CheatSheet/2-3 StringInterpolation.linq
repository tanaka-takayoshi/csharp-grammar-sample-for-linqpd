<Query Kind="Program" />

void Main()
{
	var name = "テスト";
	var s1 = $@"名前は
{name}";
	s1.Dump();
	
	var s2 = $"Now: {DateTime.Now :f}";
	s2.Dump();
}