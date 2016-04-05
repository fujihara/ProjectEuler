using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ProjectEuler
{
	public class EulerProject
	{
		private SortedDictionary<int, IProblem> _problems = new SortedDictionary<int, IProblem>();

		public EulerProject ()
		{
			var list = this.LoadProblems ();
			foreach (var problem in list) {

				_problems.Add (problem.ProblemId, problem);
			}
		}

		public void ShowProblems()
		{
			Console.WriteLine ("Project Euler problems list: \n\n");
			Console.WriteLine ("ID \t Title");

			foreach (var item in _problems) {
				Console.WriteLine ("{0} \t {1}", item.Key, item.Value.ProblemName);
			}
		}

		public void RunProblem(int id)
		{
			if (!_problems.ContainsKey(id)) {
				Console.WriteLine ("Invalid problem number, enter a correct one.\n\n");
				return;
			}

			var problem = _problems [id];

			Console.WriteLine ("\n\n=================================================================\n");
			Console.WriteLine ("   " + problem.ProblemName);
			Console.WriteLine ("\n{0}\n", problem.ProblemDescription);
			Console.WriteLine ("=================================================================\n");
			
			problem.Solve ();
			Console.WriteLine ("\n=================================================================\n\n");
			Console.WriteLine ("Press return to continue.");
			Console.ReadLine ();
		}

		private List<IProblem> LoadProblems()
		{
			var list = (from t in Assembly.GetExecutingAssembly ().GetTypes ()
			            where t.GetInterfaces ().Contains (typeof(IProblem)) && t.GetConstructor (Type.EmptyTypes) != null
			            select (IProblem)Activator.CreateInstance (t)).ToList ();

			return list;
		}
	}
}

