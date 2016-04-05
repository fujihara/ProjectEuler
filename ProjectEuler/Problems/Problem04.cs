using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler
{
	public class Problem04 : Problem
	{
		public Problem04 ()
		{
			this.problemId = 4;
			this.problemName = "Largest palindrome product";
			this.problemDescription = "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.\n\nFind the largest palindrome made from the product of two 3-digit numbers.";
		}

		public override void Solve ()
		{
			int number = GetPalindromic ();

			Console.WriteLine ("Answer: {0}\n\n", number);
		}

		private int GetPalindromic() 
		{
			int number = 0;
			List<int> pals = new List<int> ();

			for (int n1 = 999; n1 > 100; n1--) {
				for (int n2 = 999; n2 > 100; n2--) {
					number = n1 * n2;
					if (IsPalindromic (number)) {
						Console.WriteLine ("N1: {0}, N2 {1}", n1, n2);
						pals.Add (number);
					}
				}
			}

			number =  pals.OrderByDescending (n => n).First ();

			return number;
		}

		private bool IsPalindromic(int number)
		{
			string str1 = number.ToString ();

			char[] rev = str1.ToCharArray ();
			Array.Reverse (rev);
			string str2 = new string (rev);

			if (str1 == str2)
				return true;
			return false;
		}
	}
}

