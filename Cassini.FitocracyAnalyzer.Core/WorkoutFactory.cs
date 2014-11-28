using System;
using System.Linq;
using OpenQA.Selenium;
using Cassini.FitocracyAnalyzer.Core.Types;
using System.Collections.ObjectModel;
using System.Globalization;
using System.ComponentModel;

namespace Cassini.FitocracyAnalyzer.Core
{
	public static class WorkoutFactory
	{
		public static Exercise GetExercise (IWebElement exercise)
		{
			var exerciseName = exercise.FindElement (By.ClassName ("action_prompt")).Text;
			var sets = exercise.FindElements (By.XPath ("ul/li"));

			switch (exerciseName) {

			#region CARDIO, WARMUP, COOLDOWN
			case "Hiking":
				return GetExerciseData (sets, Exercises.Hiking, HikingParser);
			case "Stretching":
				return GetExerciseData (sets, Exercises.Stretching, TimeTakenParser);
			case "Foam Rolling":
				return GetExerciseData (sets, Exercises.FoamRolling, TimeTakenParser);
			case "Rowing (machine)":
				return GetExerciseData (sets, Exercises.Rowingmachine, CardioParser);
			case "Elliptical Trainer":
				return GetExerciseData (sets, Exercises.EllipticalTrainer, EllipticalParser);
			case "Cycling (stationary)":
				return GetExerciseData (sets, Exercises.Cyclingstationary, CardioParser);
			#endregion

			#region CHEST WORKOUTS
			case "Push-Up":
				return GetExerciseData (sets, Exercises.PushUp, RepsParser);
			case "Barbell Bench Press":
				return GetExerciseData (sets, Exercises.BarbellBenchPress, WeightRepsParser);
			case "Barbell Incline Bench Press":
				return GetExerciseData (sets, Exercises.BarbellInclineBenchPress, WeightRepsParser);
			case "Dumbbell Bench Press":
				return GetExerciseData (sets, Exercises.DumbbellBenchPress, WeightRepsParser);
			case "Incline Dumbbell Bench Press":
				return GetExerciseData (sets, Exercises.InclineDumbbellBenchPress, WeightRepsParser);
			case "Cable Crossover":
				return GetExerciseData (sets, Exercises.CableCrossover, WeightRepsParser);
			case "Machine Chest Press":
				return GetExerciseData (sets, Exercises.MachineChestPress, WeightRepsParser);
			#endregion

			#region TRICEPS WORKOUTS
			case "Triceps Pushdown":
				return GetExerciseData (sets, Exercises.TricepsPushdown, WeightRepsParser);
			case "Lying Barbell Triceps Extension":
				return GetExerciseData (sets, Exercises.LyingBarbellTricepsExtension, WeightRepsParser);
			case "Cable Rope Overhead Triceps Extension":
				return GetExerciseData (sets, Exercises.CableRopeOverheadTricepsExtension, WeightRepsParser);
			#endregion

			#region ABS
			case "Weighted Russian Twist":
				return GetExerciseData (sets, Exercises.WeightedRussianTwist, WeightRepsParser);
			case "Plank":
				return GetExerciseData (sets, Exercises.Plank, TimeTakenParser);
			case "Hanging Knee Raise":
				return GetExerciseData (sets, Exercises.HangingKneeRaise, RepsParser);
			case "Weighted Decline Sit-Up":
				return GetExerciseData (sets, Exercises.WeightedDeclineSitUp, WeightRepsParser);
			case "Flat Straight Leg Raise":
				return GetExerciseData (sets, Exercises.FlatStraightLegRaise, RepsParser);
			#endregion

			#region LEGS
			case "Barbell Squat":
				return GetExerciseData (sets, Exercises.BarbellSquat, WeightRepsParser);
			case "Barbell Deadlift":
				return GetExerciseData (sets, Exercises.BarbellDeadlift, WeightRepsParser);
			case "Leg Press":
				return GetExerciseData (sets, Exercises.LegPress, WeightRepsParser);
			case "Leg Extensions":
				return GetExerciseData (sets, Exercises.LegExtensions, WeightRepsParser);
			case "Lying Leg Curls":
				return GetExerciseData (sets, Exercises.LyingLegCurls, WeightRepsParser);
			case "Barbell Hip Thrust":
				return GetExerciseData (sets, Exercises.BarbellHipThrust, WeightRepsParser);
			case "Two-Arm Kettlebell Swing":
				return GetExerciseData (sets, Exercises.TwoArmKettlebellSwing, WeightRepsParser);
			case "Standing Barbell Calf Raise":
				return GetExerciseData (sets, Exercises.StandingBarbellCalfRaise, WeightRepsParser);
			case "Seated Calf Raise":
				return GetExerciseData (sets, Exercises.SeatedCalfRaise, WeightRepsParser);
			case "Calf Press On The Leg Press Machine":
				return GetExerciseData (sets, Exercises.CalfPressOnTheLegPressMachine, WeightRepsParser);
			case "Standing Calf Raise":
				return GetExerciseData (sets, Exercises.StandingCalfRaise, WeightedAssistedParser);
			#endregion

			#region SHOULDER
			case "Standing Barbell Shoulder Press (OHP)":
				return GetExerciseData (sets, Exercises.StandingBarbellShoulderPressOHP, WeightRepsParser);
			case "Standing Dumbbell Shoulder Press":
				return GetExerciseData (sets, Exercises.StandingDumbbellShoulderPress, WeightRepsParser);
			case "Seated Dumbbell Shoulder Press":
				return GetExerciseData (sets, Exercises.SeatedDumbbellShoulderPress, WeightRepsParser);
			case "Dumbbell Side Lateral Raise":
				return GetExerciseData (sets, Exercises.DumbbellSideLateralRaise, WeightRepsParser);
			case "Front Dumbbell Raise":
				return GetExerciseData (sets, Exercises.FrontDumbbellRaise, WeightRepsParser);
			#endregion

			#region BACK AND LATS
			case "Seated Cable Row":
				return GetExerciseData (sets, Exercises.SeatedCableRow, WeightRepsParser);
			case "T-Bar Row":
				return GetExerciseData (sets, Exercises.TBarRow, WeightRepsParser);
			case "Pendlay Row":
				return GetExerciseData (sets, Exercises.PendlayRow, WeightRepsParser);
			case "One-Arm Dumbbell Row":
				return GetExerciseData (sets, Exercises.OneArmDumbbellRow, WeightRepsParser);
			case "Bent Over Barbell Row":
				return GetExerciseData (sets, Exercises.BentOverBarbellRow, WeightRepsParser);
			case "Wide-Grip Lat Pulldown":
				return GetExerciseData (sets, Exercises.WideGripLatPulldown, WeightRepsParser);
			case "Lat Pulldown":
				return GetExerciseData (sets, Exercises.LatPulldown, WeightRepsParser);
			case "Pull-Up":
				return GetExerciseData (sets, Exercises.PullUp, WeightedAssistedParser);
			#endregion

			#region BICEPS
			case "Dumbbell Bicep Curl":
				return GetExerciseData (sets, Exercises.DumbbellBicepCurl, WeightRepsParser);
			case "Hammer Dumbbell Curl":
				return GetExerciseData (sets, Exercises.HammerDumbbellCurl, WeightRepsParser);
			case "Barbell Curl":
				return GetExerciseData (sets, Exercises.BarbellCurl, WeightRepsParser);
			case "EZ-Bar Curl":
				return GetExerciseData (sets, Exercises.EZBarCurl, WeightRepsParser);
			#endregion
			}

			return null;
		}

		static ExerciseSet WeightedAssistedParser (IWebElement set)
		{
			var pointsAndData = GetPointsAndRepData (set);
			var weightInfo = pointsAndData.RepData.Split (new [] {" | "}, StringSplitOptions.RemoveEmptyEntries);

			int weightKind = weightInfo.Length > 1 && string.Equals (weightInfo [1], "assisted") ? -1 : 1;
			double? weight = null;
			if (weightInfo.Length > 2)
				weight = ParseWeight (weightInfo [2]) * weightKind;
			int? reps = null;
			if (weightInfo.Length > 0)
				reps = ParseReps (weightInfo [0]);

			return new ExerciseSet {
				Points = pointsAndData.Points,
				WeightData = new WeightSet {
					Reps = reps,
					Weight = weight,
				},
				IsPr = pointsAndData.IsPr
			};
		}

		static ExerciseSet EllipticalParser (IWebElement set)
		{
			var pointsAndData = GetPointsAndRepData (set);
			var distanceInfo = pointsAndData.RepData.Split (new [] {" | "}, StringSplitOptions.RemoveEmptyEntries);

			var exerciseSet = new ExerciseSet {
				Points = pointsAndData.Points,
				DistanceData = new DistanceSet {
					Time = TimeSpan.ParseExact (distanceInfo[0], "c", CultureInfo.CurrentCulture),
				},
				IsPr = pointsAndData.IsPr
			};

			var members = typeof(IntensityKind).GetMembers ();
			foreach (var member in members) {
				var descAttributes = member.GetCustomAttributes (typeof(DescriptionAttribute), false);
				foreach (var descObj in descAttributes) {
					var descAttr = (DescriptionAttribute)descObj;
					if (string.Equals (descAttr.Description , distanceInfo[1].Trim ()))
						exerciseSet.DistanceData.Intensity = (IntensityKind)Enum.Parse (typeof(IntensityKind), member.Name);
				}
			}

			return exerciseSet;
		}

		static ExerciseSet CardioParser (IWebElement set)
		{
			var pointsAndData = GetPointsAndRepData (set);
			var distanceInfo = pointsAndData.RepData.Split (new [] {" | "}, StringSplitOptions.RemoveEmptyEntries);

			int? bpm = null;
			if (distanceInfo.Length > 3)
				bpm = int.Parse (distanceInfo [3].Replace ("BPM", string.Empty));
			return new ExerciseSet {
				Points = pointsAndData.Points,
				DistanceData = new DistanceSet {
					Time = TimeSpan.ParseExact (distanceInfo[0], "c", CultureInfo.CurrentCulture),
					Distance = distanceInfo[1],
					Speed = distanceInfo.Length > 2 ? distanceInfo[2] : null,
					HeartRate = bpm,
					Resistance = distanceInfo.Length > 4 ? distanceInfo[4] : null,
				},
				IsPr = pointsAndData.IsPr
			};
		}

		static ExerciseSet WeightRepsParser (IWebElement set)
		{
			var pointsAndData = GetPointsAndRepData (set);
			var weightInfo = pointsAndData.RepData.Split (new [] {" x "}, StringSplitOptions.RemoveEmptyEntries);

			return new ExerciseSet {
				Points = pointsAndData.Points,
				WeightData = new WeightSet {
					Weight = ParseWeight (weightInfo [0]),
					Reps = ParseReps (weightInfo [1])
				},
				IsPr = pointsAndData.IsPr
			};
		}

		static ExerciseSet RepsParser (IWebElement set)
		{
			var pointsAndData = GetPointsAndRepData (set);
			return new ExerciseSet {
				Points = pointsAndData.Points,
				WeightData = new WeightSet {
					Reps = ParseReps (pointsAndData.RepData)
				},
				IsPr = pointsAndData.IsPr
			};
		}

		static ExerciseSet TimeTakenParser (IWebElement set)
		{
			var pointsAndData = GetPointsAndRepData (set);
			return new ExerciseSet {
				Points = pointsAndData.Points,
				TimeTaken = TimeSpan.ParseExact (pointsAndData.RepData,
					"c", CultureInfo.CurrentCulture),
				IsPr = pointsAndData.IsPr
			};
		}

		static ExerciseSet HikingParser (IWebElement set)
		{
			var pointsAndData = GetPointsAndRepData (set);
			var hikeData = pointsAndData.RepData.Split (new [] { '|' });

			return new ExerciseSet {
				Points = pointsAndData.Points,
				DistanceData = new DistanceSet {
					Time = TimeSpan.ParseExact (hikeData [0],
						"c", CultureInfo.CurrentCulture),
					Distance = hikeData [1]
				},
				IsPr = pointsAndData.IsPr
			};
		}

		static Exercise GetExerciseData (ReadOnlyCollection<IWebElement> sets, Exercises kind, Func<IWebElement, ExerciseSet> func)
		{
			var exercise = new Exercise { ExerciseKind = kind };
			foreach (var set in sets) {

				var notes = set.GetAttribute ("stream_note");
				if (notes != null) {
					exercise.Notes = notes;
					continue;
				}

				try {
					exercise.Sets.Add (func (set));
				} catch (NoSuchElementException) {
				}
			}
			return exercise;
		}

		static int ParseReps (string repData)
		{
			return int.Parse (repData.Replace ("reps", string.Empty));
		}

		static double ParseWeight (string weightData)
		{
			var conversionFactor = weightData.Contains ("kg") ? 2.20462 : 1;
			var weight = weightData.Replace ("lb", string.Empty).Replace ("kg", string.Empty);
			return double.Parse (weight) * conversionFactor;
		}

		static RawRep GetPointsAndRepData (IWebElement set)
		{
			string pointsStr = set.FindElement (By.ClassName ("action_prompt_points")).Text;
			int points = Convert.ToInt32 (pointsStr);

			int lastIndex = set.Text.LastIndexOf (pointsStr, StringComparison.OrdinalIgnoreCase);
			string repText = set.Text.Remove (lastIndex);

			bool isPr = repText.Contains ("PR");
			repText = repText.Replace ("(PR)", string.Empty);

			return new RawRep {
				Points = points,
				RepData = repText,
				IsPr = isPr
			};
		}
	}
}

