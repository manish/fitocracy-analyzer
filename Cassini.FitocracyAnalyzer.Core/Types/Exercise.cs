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

		public override string ToString ()
		{
			return ExerciseKind.ToString ("G");
		}
	}

	public class ExerciseSet
	{
		public int Points { get; set; }

		public TimeSpan? TimeTaken { get; set; }

		public WeightSet WeightData { get; set; }

		public DistanceSet DistanceData { get; set; }

		public bool IsPr { get; set; }

		public override string ToString ()
		{
			return string.Format ("[ExerciseSet: Points={0}, TimeTaken={1}, WeightData={2}, DistanceData={3}, IsPr={4}]",
				Points, TimeTaken, WeightData, DistanceData, IsPr);
		}
	}

	public class WeightSet
	{
		public double? Weight { get; set; }

		public int? Reps { get; set; }

		public PlankKind? PlankKind { get; set; }

		public override string ToString ()
		{
			return string.Format ("[WeightSet: Weight={0}, Reps={1}, PlankKind={2}]", Weight, Reps, PlankKind);
		}
	}

	public class DistanceSet
	{
		public TimeSpan? Time { get; set; }

		public string Distance { get; set; }

		public IntensityKind? Intensity { get; set; }

		public override string ToString ()
		{
			return string.Format ("[DistanceSet: Time={0}, Distance={1}, Intensity={2}]", Time, Distance, Intensity);
		}
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

