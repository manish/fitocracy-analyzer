using System;
using System.Collections.Generic;

namespace Cassini.FitocracyAnalyzer.Core.Types
{
	public class Workout
	{
		public DateTime DateTime { get; set; }

		public List<Exercise> Exercises { get; set; }

		public string ExerciseName { get; set; }

		public int TotalPoints { get; set; }

		public Workout ()
		{
			Exercises = new List<Exercise> ();
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

