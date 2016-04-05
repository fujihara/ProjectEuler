using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
	public class Problem23 : Problem
	{
		private List<int> abundatsList;

		public Problem23 ()
		{
			this.problemId = 23;
			this.problemName = "Non-abundant sums";
			this.problemDescription = "A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.\n\nA number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.\n\nAs 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.\n\nFind the sum of all the positive integers which cannot be written as the sum of two abundant numbers.";
		}

		public override void Solve() 
		{
			var time = DateTime.Now;
			int sum = 0;
			this.abundatsList = this.GetAbundants ();

			for (int num = 1; num <= 28124; num++) {
				if (!IsAbundatSum (num)) {
					Console.WriteLine (num);
					sum += num;
				}
			}

			TimeSpan totalTime = time - DateTime.Now;
			Console.WriteLine ("Time Elapsed: {0}", totalTime);

			Console.WriteLine ("Answer: {0}", sum);
		}

		private bool IsAbundatSum(int num)
		{
			Dictionary<int, int> pair = new Dictionary<int, int> ();

			for (int i = 0; i < this.abundatsList.Count; i++) {

				// Equal values like 24 is the sum of 12 + 12
				if (num - this.abundatsList [i] == this.abundatsList [i]) {
					return true;
				}

				if (pair.ContainsKey (this.abundatsList[i])) {
					return true;
				} else {
					if (num - this.abundatsList [i] > 0) {
						pair.Add (num - this.abundatsList [i], this.abundatsList [i]);
					}
				}

				if (num < this.abundatsList [i]) {
					return false;
				}
			}
			return false;
		}

		private List<int> GetAbundants() 
		{
			List<int> list = new List<int> ();

			for (int n = 1; n <= 28123; n++) {
				if (this.IsAbundant (n))
					list.Add (n);
			}
			return list;
		}

		private bool IsAbundant(int num)
		{
			int divisorsSum = Utils.GetProperDivisors (num).Sum ();
			if (divisorsSum > num) {
				return true;
			}
			return false;
		}

	}
}

