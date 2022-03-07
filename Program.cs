using System;
public class Program
{
	public static void Main()
	{
		int x1, x2, y1, y2;

		Console.WriteLine("Enter X1 Value:");
		x1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter X2 Value:");
		y1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Y1 Value:");
		x2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Y2 Value:");
		y2 = Convert.ToInt32(Console.ReadLine());

		double Z = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
		Console.WriteLine("Length of Line is : {0}", Z);
	}
}

