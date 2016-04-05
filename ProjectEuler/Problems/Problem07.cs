using System;

namespace ProjectEuler
{
	public class Problem07 : Problem
	{
		public Problem07 ()
		{
			this.problemId = 7;
			this.problemName = "10001st prime";
			this.problemDescription = "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.\n\nWhat is the 10 001st prime number?";
		}

		public override void Solve ()
		{
			long prime = 3;
			int pos = 2;
			while (true) {
				if (Utils.IsPrime (prime)) {
					if (pos == 10001)
						break;
					pos++;
				}
				prime += 2;
			}

			Console.WriteLine ("Prime: {0}, Pos: {1}", prime, pos);
		}
	}
}

