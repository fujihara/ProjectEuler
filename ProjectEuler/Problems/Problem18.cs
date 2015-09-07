using System;

namespace ProjectEuler
{
	public class Problem18 : Problem
	{
		private int[][] triangle = new int[15][] {
			new int[] { 75 }, 
			new int[] { 95, 64 }, 
			new int[] { 17, 47, 82 }, 
			new int[] { 18, 35, 87, 10 }, 
			new int[] { 20, 04, 82, 47, 65 }, 
			new int[] { 19, 01, 23, 75, 03, 34 }, 
			new int[] { 88, 02, 77, 73, 07, 63, 67 }, 
			new int[] { 99, 65, 04, 28, 06, 16, 70, 92 }, 
			new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 }, 
			new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 }, 
			new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 }, 
			new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 }, 
			new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 }, 
			new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 }, 
			new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 }
		};

		public Problem18 ()
		{
			this.problemId = 18;
			this.problemName = "Number letter counts";
			this.problemDescription = "If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.\n\nIf all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?\n\n\nNOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of \"and\" when writing out numbers is in compliance with British usage.";
		}

		public override void Solve ()
		{
			// triangle.Length - 2 to start from the second line from the botton
			for (int l = triangle.Length - 2; l >= 0; l--) {
				for (int pos = 0; pos < triangle [l].Length; pos++) {
					// Sum with the larger of 2 numbers of the line bellow
					triangle [l] [pos] += Math.Max (triangle [l + 1] [pos], triangle [l + 1] [pos + 1]);
				}
			}

			Console.WriteLine ("Sum: " + triangle[0][0]);
		}
	}
}

