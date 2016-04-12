<Query Kind="Program" />

void Main()
{
	var c1 = new Complex(1, 3) + new Complex(2, 4); // 3 + 7i
	c1.Dump();
	
	var c2 = -new Complex(2, -2); //-2+2i
	c2.Dump();
}

public class Complex
{
	public double Real { get; }
	public double Imaginary { get; }

	public Complex(double real, double imaginary)
	{
		Real = real;
		Imaginary = imaginary;
	}

	public static Complex operator -(Complex c1)
	{
		return new Complex(-c1.Real, -c1.Imaginary);
	}
	
	public static Complex operator +(Complex c1, Complex c2)
	{
		return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
	}
}