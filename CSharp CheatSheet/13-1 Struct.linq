<Query Kind="Program" />

void Main()
{
	var p1 = new Point(10);
	//参照ではなく、コピーした値がp2に割り当てられる
	var p2 = p1;
	//p1のプロパティを更新してもp2には影響がない
	p1.X = 1;
	p1.Dump(); //p1.X=1
	p2.Dump(); //p2.X=10

	//構造体をデフォルト値はnullではない
	var points = new Point[10];
	//point[0].X=0
	points[0].Dump();
}

struct Point
{
	private int x;
	public int X
	{
		get { return x; }
		set { x = value; }
	}
	public Point(int x)
	{
		this.x = x;
	}
}
