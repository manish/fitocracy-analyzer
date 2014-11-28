using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cassini.FitocracyAnalyzer.Core.Types
{
	public class Exercise
	{
		public Exercise ()
		{
			Sets = new List<ExerciseSet> ();
		}

		[JsonProperty("exercise_kind")]
		public Exercises ExerciseKind { get; set; }

		[JsonProperty("sets")]
		public List<ExerciseSet> Sets { get; set; }

		[JsonProperty("notes")]
		public string Notes { get; set; }

		public string RawData { get; set; }

		public override string ToString ()
		{
			return ExerciseKind.ToString ("G");
		}
	}

	public class ExerciseSet
	{
		[JsonProperty("points")]
		public int Points { get; set; }

		[JsonProperty("time_taken")]
		public TimeSpan? TimeTaken { get; set; }

		[JsonProperty("weight_data")]
		public WeightSet WeightData { get; set; }

		[JsonProperty("distance_data")]
		public DistanceSet DistanceData { get; set; }

		[JsonProperty("is_pr")]
		public bool IsPr { get; set; }

		public override string ToString ()
		{
			return string.Format ("[ExerciseSet: Points={0}, TimeTaken={1}, WeightData={2}, DistanceData={3}, IsPr={4}]",
				Points, TimeTaken, WeightData, DistanceData, IsPr);
		}
	}

	public class WeightSet
	{
		[JsonProperty("weight")]
		public double? Weight { get; set; }

		[JsonProperty("reps")]
		public int? Reps { get; set; }

		[JsonProperty("plank_kind")]
		[JsonConverter(typeof(StringEnumConverter))]
		public PlankKind? PlankKind { get; set; }

		public override string ToString ()
		{
			return string.Format ("[WeightSet: Weight={0}, Reps={1}, PlankKind={2}]", Weight, Reps, PlankKind);
		}
	}

	public class DistanceSet
	{
		[JsonProperty("time")]
		public TimeSpan? Time { get; set; }

		[JsonProperty("distance")]
		public string Distance { get; set; }

		[JsonProperty("intensity")]
		[JsonConverter(typeof(StringEnumConverter))]
		public IntensityKind? Intensity { get; set; }

		[JsonProperty("speed")]
		public string Speed { get; set; }

		[JsonProperty("heart_rate")]
		public int? HeartRate { get; set; }

		[JsonProperty("resistance")]
		public string Resistance { get; set; }

		public override string ToString ()
		{
			return string.Format ("[DistanceSet: Time={0}, Distance={1}, Intensity={2}, HeartRate={3}, Resistence={4}]",
				Time, Distance, Intensity, HeartRate, Resistance);
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

