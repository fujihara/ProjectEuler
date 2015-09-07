using System;
using System.Numerics;

namespace ProjectEuler
{
	public class Problem20 : Problem
	{
		public Problem20 ()
		{
			this.problemId = 20;
			this.problemName = "Factorial digit sum";
			this.problemDescription = "n! means n × (n − 1) × ... × 3 × 2 × 1\n\nFor example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,\nand the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.\n\nFind the sum of the digits in the number 100!";
		}

		public override void Solve ()
		{
			var factor = Utils.Factorial ((BigInteger)100);

			var numeral = string.Format ("{0}", factor).ToCharArray ();


			Console.WriteLine ("Factor: {0}", factor);

			double sum = 0;
			foreach (var digit in numeral) {
				sum += Convert.ToInt32 (digit.ToString());
			}

			Console.WriteLine ("Answer: {0}", sum);
		}
	}
}

