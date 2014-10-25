using System;

namespace Cassini.FitocracyAnalyzer.Core
{
	public class Workout
	{
		public DateTime DateTime { get; private set; }

		public Workout (string date)
		{
		}
	}

	public class WorkoutEventArgs : EventArgs
	{
		public Workout Workout { get; private set; }

		public WorkoutEventArgs (Workout workout)
		{
			Workout = workout;
		}
	}
}

