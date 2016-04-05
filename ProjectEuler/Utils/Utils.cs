using System;
using System.Numerics;

namespace ProjectEuler
{
	public class Utils
	{
		public static bool IsPrime(long number)
		{
			if (number == 0) return false;
			if (number == 1) return false;
			if (number == 2) return true;

			var square = Math.Ceiling(Math.Sqrt (number));

			for (long i = 3; i <= square; i++)  {
				if (number % i == 0)  return false;
			}
			return true;
		}

		public static double Factorial(double num) 
		{
			if (num == 1) return 1;
			double result = Factorial(num -1) * num;
			return result;
		}

		public static BigInteger Factorial(BigInteger num) 
		{
			if (num == 1) return 1;
			BigInteger result = Factorial(num -1) * num;
			return result;
		}
	}
}

