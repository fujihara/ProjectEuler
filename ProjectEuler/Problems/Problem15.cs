using System;

namespace ProjectEuler
{
	public class Problem15 : Problem
	{
		public Problem15 ()
		{
			this.problemId = 15;
			this.problemName = "Lattice paths";
			this.problemDescription = "Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.\n\n\nHow many such routes are there through a 20×20 grid?";
		}

		public override void Solve ()
		{
			double columns = 20;
			double lines = 20;

			double n = columns + lines;
			double k = lines;

			double paths = Utils.Factorial (n) / (Utils.Factorial (k) * Utils.Factorial (n - k));

			Console.WriteLine ("Routes: {0}", paths);
		}
	}
}

