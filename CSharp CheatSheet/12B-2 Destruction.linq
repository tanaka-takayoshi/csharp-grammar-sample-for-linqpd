<Query Kind="Program" />

void Main()
{
	var tuple = (name: "Tom", age: 34);
	string name; int age;
	(name, age) = tuple;       // 宣言済みの変数（＝式）に分解して代入する
	Console.WriteLine(age);

	int x, y;
	(x, y) = new Ex12B_2_Destruction_Point(3, 5);  // Deconstructメソッド（後述）を持つインスタンスを分解する
	Console.WriteLine($"{x} {y}");

	// 分解して新しく宣言した変数に代入する
	(var newName, var newAge) = tuple;
	(var myX, var myY) = new Ex12B_2_Destruction_Point(3, 5);

	// 式と変数宣言の併用はコンパイルエラー
	//(x, var y2) = new Point(3, 4);

	// Out Varと同じく_で読み捨てることができる
	(var x1, var _) = new Ex12B_2_Destruction_Point(4, -3);
	Console.WriteLine($"{x1}");
	// var _ は変数宣言扱いなので変数への代入と併用するとコンパイルエラー
	//(x1, var _) = new Point(4, -3);
}


class Ex12B_2_Destruction_Point
{
	public int X { get; }
	public int Y { get; private set; }

	public Ex12B_2_Destruction_Point(int x, int y) { X = x; Y = y; }
	public void Deconstruct(out int x, out int y)
	{
		x = X;
		y = Y;
	}
}
