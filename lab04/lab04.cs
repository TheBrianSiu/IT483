using System;

public class Lab12
{

	   public static void Main(string[] args)
	   {


			  int a = 1, b = 3, c = 5;

			  double x = 2.2, y = 4.4, z = 6.6, ans;

			  ans = average(a, b);

			  Console.WriteLine("\naverage(a, b) = " + ans);

			  ans = average(a, b, c);

			  Console.WriteLine("\naverage(a, b, c) = " + ans);

			  ans = average(x, y);

			  Console.WriteLine("\naverage(x, y) = " + ans);

			  ans = average(x, y, z);

			  Console.WriteLine("\naverage(x, y, z) = " + ans);

			  ans = average(average(a,b), c);

			  Console.WriteLine("\naverage(a, b, c) = " + ans);

			  ans = average(1, 2.0, 3);

			  Console.WriteLine("\naverage(1, 2.0, 3) = " + ans);

	   }

	   public static double average(int n1, int n2)
	   {

			  return (n1 + n2) / 2.0;

	   }

	   public static double average(int a, int b, int c)
	   {

			  return ((a + b + c) / 3.0);

	   }

	   public static double average(double a, double b)
	   {

			  return ((a + b) / 2.0);

	   }

	   public static double average(double a, double b, double c)
	   {

			  return ((a + b + c) / 3.0);

	   }

}
