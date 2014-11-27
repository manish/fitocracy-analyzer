using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Cassini.FitocracyAnalyzer.Core.Types
{
	public class Exercise
	{
		public Exercise ()
		{
			Sets = new List<ExerciseSet> ();
		}

		public Exercises ExerciseKind { get; set; }

		public List<ExerciseSet> Sets { get; set; }

		public string Notes { get; set; }

		public string RawData { get; set; }
	}

	public class ExerciseSet
	{
		public ExerciseSet () { }

		public int Points { get; set; }

		public TimeSpan TimeTaken { get; set; }

		public WeightSet WeightData { get; set; }

		public DistanceSet DistanceData { get; set; }
	}

	public class WeightSet
	{
		public WeightSet () { }

		public double? Weight { get; set; }

		public int? Reps { get; set; }

		public PlankKind? PlankKind { get; set; }
	}

	public class DistanceSet
	{
		public DistanceSet () { }

		public TimeSpan? Time { get; set; }

		public string Distance { get; set; }

		public IntensityKind? Intensity { get; set; }
	}

	public enum IntensityKind
	{
		[Description("intense")]
		Intense,

		[Description("easy")]
		Easy,

		[Description("moderate")]
		Moderate,

		[Description("broke a sweat")]
		BrokeASweat,

		[Description("the gods hate me!")]
		TheGodsHateMe
	}

	public enum PlankKind
	{
		[Description("kneeling plank")]
		KneelingPlank,

		[Description("kneeling side plank")]
		KneelingSidePlank,

		[Description("plank")]
		Plank,

		[Description("side plank")]
		SidePlank,

		[Description("decline plank")]
		DeclinePlank,

		[Description("leg lift plank")]
		LegLiftPlank,

		[Description("arm and leg lift plank")]
		ArmAndLegLiftPlank,

		[Description("arm and leg lift side plank")]
		ArmAndLegLiftSidePlank,

		[Description("wall plank")]
		WallPlank
	}
}

