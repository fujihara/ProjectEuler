using System;

namespace ProjectEuler
{
	public class Problem10 : Problem
	{
		public Problem10 ()
		{
			this.problemId = 10;
			this.problemName = "Summation of primes";
			this.problemDescription = "The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.\n\nFind the sum of all the primes below two million.";
		}

		public override void Solve ()
		{
			long sum = 2;
			long prime = 3;
			int pos = 2;
			while (true) {
				if (Utils.IsPrime
					(prime)) {
					if (prime >= 2000000)
						break;
					sum += prime;
					pos++;
				}
				prime += 2;
			}

			Console.WriteLine ("Prime: {0}, Pos: {1}, Sum: {2}", prime, pos, sum);
		}
	}
}

