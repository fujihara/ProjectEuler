using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ProjectEuler
{
	public class Problem22 : Problem
	{
		public Problem22 ()
		{
			this.problemId = 22;
			this.problemName = "Names scores";
			this.problemDescription = "Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.\n\nFor example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.\n\nWhat is the total of all the name scores in the file?";
		}

		public override void Solve ()
		{
			// Load p022_names.txt from Recources
			string names = Resources.p022_names;

			// Transform to array and order it
			var orderdNames = names.Replace ("\"", "").Split (',').OrderBy(x => x);

			// Calculate list total score
			int pos = 1;
			int score = 0; 
			foreach (var name in orderdNames) {
				int nameScore = pos * this.NameCharScore (name);
				score += nameScore;
				pos++;
			}

			Console.WriteLine ("List score: {0}", score);
		}

		// Calculate the char score of a name using ASCII codes
		private int NameCharScore(string name)
		{
			var bytes = Encoding.ASCII.GetBytes (name);
			int score = bytes.Sum(x => x) - (bytes.Count () * 64);
			return score;
		}
	}
}

