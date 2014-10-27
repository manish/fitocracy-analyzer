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
				return GetHikingExercise (sets);
			}

			return null;
		}

		static Exercise GetHikingExercise (ReadOnlyCollection<IWebElement> sets)
		{
			var exercise = new Exercise { ExerciseKind = Exercises.Hiking };
			foreach (var set in sets) {
				var notes = set.GetAttribute ("stream_note");
				if (notes != null) {
					exercise.Notes = notes;
					continue;
				}

				try {
					var pointsAndData = GetPointsAndRepData (set);
					var setObj = new ExerciseSet { Points = pointsAndData.Item1 };

					setObj.DistanceData = new DistanceSet ();
					var hikeData = pointsAndData.Item2.Split (new [] { '|' });
					setObj.DistanceData.Time = TimeSpan.ParseExact(hikeData [0], 
						"c", CultureInfo.CurrentCulture);
					setObj.DistanceData.Distance = hikeData [1];
					exercise.Sets.Add (setObj);
				} catch (NoSuchElementException) {
				};
			}

			return exercise;
		}


		static Tuple<int, string> GetPointsAndRepData (IWebElement set)
		{
			string setData = set.Text;
			string pointsStr = set.FindElement (By.ClassName ("action_prompt_points")).Text;
			string repText = set.Text.Replace (pointsStr, "");
			int points = Convert.ToInt32 (pointsStr);

			return new Tuple<int, string> (points, repText);
		}
	}
}

