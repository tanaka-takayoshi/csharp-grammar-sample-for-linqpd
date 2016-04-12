<Query Kind="Program" />

void Main()
{
	var s = "abcd";
	var text = "CD";
	//true
	s.ContainsIgnoreCase(text).Dump();
}

public static class MyExtensions
{
	public static bool ContainsIgnoreCase(this string s, string text)
	{
		return s.ToLower().Contains(text.ToLower());
	}
}