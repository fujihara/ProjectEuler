using System;

namespace ProjectEuler
{
	public class Problem14 : Problem
	{
		public Problem14 ()
		{
			this.problemId = 14;
			this.problemName = "Longest Collatz sequence";
			this.problemDescription = "The following iterative sequence is defined for the set of positive integers:\n\nn → n/2 (n is even)\nn → 3n + 1 (n is odd)\n\nUsing the rule above and starting with 13, we generate the following sequence:\n\n13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1\nIt can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.\n\nWhich starting number, under one million, produces the longest chain?\n\nNOTE: Once the chain starts the terms are allowed to go above one million.";
		}

		public override void Solve ()
		{
			DateTime start = DateTime.Now;

			long number = 1000000;
			int largeSeq = 0;

			for (long x = number; x > 1; x--) {
				int count = SequenceCount (x);

				if (count > largeSeq) {
					largeSeq = count;
					Console.WriteLine ("Start: {0} - Count: {1}", x, count);
				}
			}

			Console.WriteLine ("Longer chain: {0}", largeSeq);

			TimeSpan time = DateTime.Now - start;
			Console.WriteLine ();
			Console.WriteLine ("Elapsed time: {0}", time.TotalMilliseconds);
		}

		private int SequenceCount(long number) 
		{
			int count = 1;

			while (number != 1) {

				if (number % 2 == 0) {
					number = number / 2;
				} else {
					number = 3 * number + 1;
				}
				count++;
			}
			return count;
		}
	}
}

