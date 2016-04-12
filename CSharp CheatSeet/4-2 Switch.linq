<Query Kind="Program" />

 void Main()
{
	var dayOfWeek = DayOfWeek.Thursday;
	string text;
	switch (dayOfWeek)
	{
		case DayOfWeek.Monday:
			text = "月";
			break;
		case DayOfWeek.Tuesday:
			text = "火";
			break;
		case DayOfWeek.Wednesday:
			text = "水";
			break;
		case DayOfWeek.Thursday:
			text = "木";
			break;
		case DayOfWeek.Friday:
			text = "金";
			break;
		case DayOfWeek.Saturday:
			text = "土";
			break;
		case DayOfWeek.Sunday:
			text = "日";
			break;
		default:
			throw new ArgumentOutOfRangeException();
	}
	text.Dump();
	//なお、日付を表すDateTime型のインスタンスからカレントカルチャの曜日の省略名を得る場合はこのように書ける
	$"{DateTime.Now:ddd}".Dump();
}