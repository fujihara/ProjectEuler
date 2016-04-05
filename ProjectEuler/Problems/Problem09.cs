using System;

namespace ProjectEuler
{
	public class Problem09 : Problem
	{
		public Problem09 ()
		{
			this.problemId = 9;
			this.problemName = "Special Pythagorean triplet";
			this.problemDescription = "A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,\n\na2 + b2 = c2\nFor example, 32 + 42 = 9 + 16 = 25 = 52.\n\nThere exists exactly one Pythagorean triplet for which a + b + c = 1000.\nFind the product abc.";
		}

		public override void Solve ()
		{
			double a, b, c;

			for (int s1 = 1; s1 < 1000; s1++) {
				for (int s2 = 1; s2 < 1000; s2++) {
					a = s1 * s2 * 2;
					b = Math.Pow (s2, 2) - Math.Pow (s1, 2);
					c = Math.Pow (s1, 2) + Math.Pow (s2, 2);

					if (a + b + c == 1000) {
						Console.WriteLine ("a: {0}, b: {1}, c: {2}", a, b, c);
						Console.WriteLine ("Product: {0}", a * b * c);
					}
				}
			}
		}
	}
}

