using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	public class Problem16 : Problem
	{
		public Problem16 ()
		{
			this.problemId = 16;
			this.problemName = "Power digit sum";
			this.problemDescription = "215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.\n\nWhat is the sum of the digits of the number 21000?";
		}

		public override void Solve ()
		{
			List<string> number = new List<string> ();
			number.Add ("2");
			int exp = 1000;
			long interact = 0;

			for (int x = 1; x <= exp - 1; x++) {
				int count = number.Count;
				int sum = 0;
				for (int index = 0; index < count; index++) {
					int num = (Convert.ToInt32 (number [index]) * 2) + sum;
					string str = num.ToString ();
					int size = str.Length;
					interact++;

					if (size == 1) {
						number [index] = str;
						sum = 0;
					} else if (size == 2) {
						char n1 = str [0];
						char n2 = str [1];

						number [index] = n2.ToString ();

						if (index == count - 1) {
							number.Add (n1.ToString ());
							sum = 0;
						} else {
							sum = Convert.ToInt32 (n1.ToString ());
						}
					}
				}
				Console.Write ("2^{0} : ", x+1);
				PrintNumber (number);
			}

			//PrintNumber (number);
			int powerDigSum = 0;
			foreach(string num in number) {
				powerDigSum += Convert.ToInt32(num);
			}
			Console.WriteLine("Total: {0}", powerDigSum);
			Console.WriteLine ("Interactions: {0}", interact);
		}

		private void PrintNumber(List<string> number) {
			for (int x = number.Count - 1; x >= 0; x--) {
				Console.Write (number [x]);
			}
			Console.WriteLine ();
		}
	}
}

