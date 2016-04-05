using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
	public class Problem21 : Problem
	{
		public Problem21 ()
		{
			this.problemId = 21;
			this.problemName = "Amicable numbers";
			this.problemDescription = "Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).\nIf d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.\n\nFor example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.\n\nEvaluate the sum of all the amicable numbers under 10000.";
		}

		public override void Solve ()
		{
			List<int> amicables = new List<int> ();
			for (int a = 1; a < 10000; a++) {
				var b = GetDivisorSum (a);
				var divSumB = GetDivisorSum (b);

				if (divSumB == a && a != b) {
					amicables.Add (a);
				}
			}
			Console.WriteLine ("Answer: {0}", amicables.Sum ());
		}

		private int GetDivisorSum(int num) 
		{
			var divisors = Utils.GetProperDivisors (num);
			int sum = divisors.Sum ();
			return sum;
		}
	}
}

