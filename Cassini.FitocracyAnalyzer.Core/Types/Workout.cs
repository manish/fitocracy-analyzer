using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cassini.FitocracyAnalyzer.Core.Types
{
	public class Workout
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("datetime")]
		public DateTime DateTime { get; set; }

		[JsonProperty("exercises")]
		public List<Exercise> Exercises { get; set; }

		[JsonProperty("name")]
		public string WorkoutName { get; set; }

		[JsonProperty("total_points")]
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

