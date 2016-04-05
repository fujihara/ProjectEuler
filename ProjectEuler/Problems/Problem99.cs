using System;

namespace ProjectEuler
{
	public class Problem99 : Problem
	{
		public Problem99 ()
		{
			this.problemId = 99;
			this.problemName = "Reverse Recursive";
		}

		public override void Solve ()
		{
			string str = "asdfghj";	

			Console.WriteLine("Result: {0}", Reverse(str));
		}


		private string Reverse(string str) 
		{
			if (str.Length > 0) {
				string newString = Reverse (str.Substring (0, str.Length - 1));
				return str.Substring (str.Length - 1, 1) + newString;
			}
			return str;
		}
	}
}

