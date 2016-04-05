using System;

namespace ProjectEuler
{
	public class Problem03 : Problem
	{
		public Problem03 ()
		{
			this.problemId = 3;
			this.problemName = "Largest prime factor";
			this.problemDescription = "The prime factors of 13195 are 5, 7, 13 and 29.\n\nWhat is the largest prime factor of the number 600851475143 ?";
		}

		public override void Solve()
		{
			Console.WriteLine ("\n\nAnswer: {0}\n", this.primeFactor());
		}

		private long primeFactor()
		{
			long num = 600851475143;
			long prime = 2;

			while (true)
			{
				if (num == prime) 
				{
					break;
				}
				else if (num % prime == 0)
				{
					Console.Write ("{0}, ", prime);
					num = num / prime;
				}
				else {
					for (long x = prime + 1; x <= num; x++) 
					{
						if (Utils.IsPrime(x)) 
						{
							prime = x;
							break;
						}
					}
				}
			}
			return prime;
		}
	}
}

