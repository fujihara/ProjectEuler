using System;

namespace ProjectEuler
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Starting...");

			var euler = new EulerProject ();

			while(true) {
				euler.ShowProblems ();

				Console.Write ("\nEnter the problem number or x to exit: ");

				var input = Console.ReadLine ();
				if (input == "x" || input == "X") {
					Console.WriteLine ("\nBye!\n");
					break;
				}

				int number = 0;
				try {
					number = Convert.ToInt32 (input);
				} catch {
					Console.WriteLine ("\nInvalid input, enter a valid number.\n\n");
					continue;
				}

				try {
					euler.RunProblem (number);
				} catch (Exception e) {
					Console.WriteLine ("Error running the problem.\n");
					Console.WriteLine ("Message: " + e.Message);
					Console.WriteLine ("\n\n");

					Console.ReadLine ();
				}
			}
		}
	}
}
