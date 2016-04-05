using System;
using System.Collections.Generic;
using System.Linq;
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

		public static List<int> GetDivisors(int num)
		{
			List<int> divisors = new List<int> ();

			int max = (int)Math.Ceiling (Math.Sqrt(num));
			for (int n = 1; n <= max; n++) {
				if ((num % n) == 0) {
					divisors.Add (n);
					int div2 = num / n;
					if (div2 != n && div2 > max) {
						divisors.Add (div2);
					}
				}
			}
			return divisors;
		}

		public static List<int> GetProperDivisors(int num)
		{
			List<int> divisors = new List<int> ();

			int max = (int)Math.Ceiling (Math.Sqrt(num));
			for (int n = 1; n <= max; n++) {
				if ((num % n) == 0 && n != num) {
					divisors.Add (n);
					int div2 = num / n;
					if (div2 != n && div2 > max && div2 != num) {
						divisors.Add (div2);
					}
				}
			}
			return divisors;
		}
	}
}

