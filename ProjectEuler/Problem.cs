using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ProjectEuler
{
	public abstract class 
	Problem : IProblem
	{
		protected const string EULER_URL = "https://projecteuler.net/problem=";

		protected int problemId = 0;
		protected string problemName = null;
		protected string problemDescription = "";

		public abstract void Solve ();


		#region IProblem implementation

		public int ProblemId {
			get {
				return this.problemId;
			}
		}

		public string ProblemName {
			get {
				return this.problemName;
			}
		}

		public string ProblemUrl {
			get {
				return EULER_URL + this.problemId;	
			}
		}

		public string ProblemDescription {
			get {
				return this.problemDescription;
			}
		}

		#endregion

		public override string ToString() 
		{
			return this.ProblemName;
		}
	}
}

