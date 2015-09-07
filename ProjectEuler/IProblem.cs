using System;

namespace ProjectEuler
{
	public interface IProblem
	{
		void Solve();

		int ProblemId { get; }
		string ProblemName { get; }
		string ProblemUrl { get; }
		string ProblemDescription { get; }
	}
}

