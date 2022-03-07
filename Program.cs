using System;


public class Program
{
	public static void Main()
	{
		int x1, x2, y1, y2;
		int x3, y3, x4, y4;

		Console.WriteLine("Enter the Values of First Line:");
		Console.WriteLine("Enter X1 Value:");
		x1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Y1 Value:");
		y1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter X2 Value:");
		x2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Y2 Value:");
		y2 = Convert.ToInt32(Console.ReadLine());

		double Z1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
		Console.WriteLine("Length of First Line is : {0}", Z1);


		Console.WriteLine("Enter the Values of Second Line:");
		Console.WriteLine("Enter X3 Value:");
		x3 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Y3 Value:");
		y3 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter X4 Value:");
		x4 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Y4 Value:");
		y4 = Convert.ToInt32(Console.ReadLine());

		double Z2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
		Console.WriteLine("Length of Second Line is : {0}", Z2);
		{
			if (Z1 > Z2)
				Console.WriteLine("The First Line is Greater than Second Line");
			else
				Console.WriteLine("The Second Line is Greater than First Line");
		}
	}
}

