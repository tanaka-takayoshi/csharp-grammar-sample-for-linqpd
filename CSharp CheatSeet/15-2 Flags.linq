<Query Kind="Program" />

void Main()
{
	var colors = Color.Red | Color.Blue;
	colors.HasFlag(Color.Red).Dump(); //True
	(colors == Color.Red).Dump(); // False
	colors.HasFlag(Color.Yellow).Dump(); // False
}

[Flags]
public enum Color
{
	Red,
	Blue,
	Yellow
}
