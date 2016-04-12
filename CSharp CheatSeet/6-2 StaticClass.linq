<Query Kind="Program" />

void Main()
{
	double mile = MileConverter.MileToKm(1);
	mile.Dump();
}

public static class MileConverter
{
	public static readonly double MilePerKm = 0.62137;
	
	public static double KmToMile(double km)
	{
		return km * MilePerKm;
	}

	public static double MileToKm(double mile)
	{
		return mile / MilePerKm;
	}
}
