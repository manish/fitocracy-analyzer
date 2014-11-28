using System;
using OpenQA.Selenium;
using Cassini.FitocracyAnalyzer.Core.Types;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Cassini.FitocracyAnalyzer.Core
{
	public static class WorkoutFactory
	{
		public static Exercise GetExercise (IWebElement exercise)
		{
			var exerciseName = exercise.FindElement (By.ClassName ("action_prompt")).Text;
			var sets = exercise.FindElements (By.XPath ("ul/li"));

			switch (exerciseName) {
			case "Hiking":
				return GetExerciseData (sets, Exercises.Hiking, HikingParser);
			case "Stretching":
				return GetExerciseData (sets, Exercises.Stretching, StretchingParser);
			case "Push-Up":
				return GetExerciseData (sets, Exercises.PushUp, PushUpParser);
			case "Barbell Bench Press":
				return GetExerciseData (sets, Exercises.BarbellBenchPress, WeightRepsParser);
			case "Dumbbell Bench Press":
				return GetExerciseData (sets, Exercises.DumbbellBenchPress, WeightRepsParser);
			case "Cable Crossover":
				return GetExerciseData (sets, Exercises.CableCrossover, WeightRepsParser);
			case "Triceps Pushdown":
				return GetExerciseData (sets, Exercises.TricepsPushdown, WeightRepsParser);
			case "Lying Barbell Triceps Extension":
				return GetExerciseData (sets, Exercises.LyingBarbellTricepsExtension, WeightRepsParser);
			case "Cable Rope Overhead Triceps Extension":
				return GetExerciseData (sets, Exercises.CableRopeOverheadTricepsExtension, WeightRepsParser);
			}

			return null;
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

		static ExerciseSet PushUpParser (IWebElement set)
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

		static ExerciseSet StretchingParser (IWebElement set)
		{
			var pointsAndData = GetPointsAndRepData (set);
			return new ExerciseSet {
				Points = pointsAndData.Points,
				TimeTaken = TimeSpan.ParseExact(pointsAndData.RepData, 
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
					Time = TimeSpan.ParseExact(hikeData [0], 
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
			return double.Parse (weightData.Replace ("lb", string.Empty));
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

