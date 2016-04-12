<Query Kind="Program" />

void Main()
{
	var str01 = "Hello World";
	str01.Dump();
	var str02 = @"Hello World";
	str02.Dump();
	
	var str03 = "Hello \t World"; // Hello    World
	str03.Dump();
	var str04 = @"Hello \t World"; // Hello \t World
	str04.Dump();

	var str05 = "\"Hello\" World"; // "Hello" World
	str05.Dump();
	var str06 = @"""Hello"" World"; // "Hello" World
	str06.Dump();

	var str07 = "C:\\tmp\\log.txt"; // C:\tmp\log.txt
	str07.Dump();
	var str08 = @"C:\tmp\log.txt"; // C:\tmp\log.txt
	str08.Dump();

	var str09 = "Hello\r\nWorld";
	str09.Dump();
	var str10 = @"Hello
World";
	str10.Dump();
}