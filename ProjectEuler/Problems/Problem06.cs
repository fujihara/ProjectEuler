using System;

namespace ProjectEuler
{
	public class Problem06 : Problem
	{
		public Problem06 ()
		{
			this.problemId = 6;
			this.problemName = "Sum square difference";
			this.problemDescription = "The sum of the squares of the first ten natural numbers is,\n\n12 + 22 + ... + 102 = 385\nThe square of the sum of the first ten natural numbers is,\n\n(1 + 2 + ... + 10)2 = 552 = 3025\nHence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.\n\nFind the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";
		}

		public override void Solve ()
		{
			double sumSqr = 0;
			double sqrSum = 0;

			for (int x = 1; x <= 100; x++) {
				sumSqr += Math.Pow (x, 2);
				sqrSum += x;
			}
			sqrSum = Math.Pow (sqrSum, 2);

			double value = sqrSum - sumSqr;
			Console.WriteLine ("square of the sum: {0}", sqrSum);
			Console.WriteLine ("sum of the squares: {0}", sumSqr);
			Console.WriteLine ("difference: {0}", value);
		}
	}
}

