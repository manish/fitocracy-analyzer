using System;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.Linq;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cassini.FitocracyAnalyzer.Core
{
	public class ExerciseListCrawler
	{
		readonly Dictionary<string, string> numberToAlphabet = new Dictionary<string, string> {
			{ "1", "One"},
			{ "2", "Two"},
			{ "3", "Three"},
			{ "4", "Four"},
			{ "5", "Five"},
			{ "6", "Six"},
			{ "7", "Seven"},
			{ "8", "Eight"},
			{ "9", "None"},
			{ "0", "Zero"},
		};

		public List<string> Exercises { get; private set; }
		public Dictionary<string, string> ExercisesIdentifier { get; private set; }
		public string ExercisesJson { get; private set; }

		public ExerciseListCrawler (FirefoxDriver driver)
		{
			Thread.Sleep (2000);
			driver.Navigate ().GoToUrl("https://www.fitocracy.com/track/");
			Thread.Sleep (2000);
			var letsGo = driver.FindElementByXPath ("//div[@class='blue-button main-button']");
			letsGo.Click ();

			var popUp1 = driver.FindElementByXPath ("//div[@class='help-panel-button']/span");
			popUp1.Click ();
			var popUp2 = driver.FindElementByXPath ("//div[@class='track-menu']/div[@class='help-panel-button']/span");
			popUp2.Click ();
			var popUp3 = driver.FindElementByXPath ("//div[@class='track-menu']/div[@class='help-panel-button']/span");
			popUp3.Click ();

			var explorerSection = driver.FindElementByXPath ("//div[@class='all-exercises-switcher explorer-menu-switcher expand']");
			explorerSection.Click ();

			var allExercises = driver.FindElementByXPath ("//div[@class='all-exercises-container explorer-menu-content']");
			var exercisesList = allExercises.FindElements (By.XPath (".//span"));
			Exercises = exercisesList.Select (x => x.Text).ToList ();
			ExercisesIdentifier = GetEnumStrings (Exercises);

			var jsonifiedList = new List<string> ();
			foreach (var item in ExercisesIdentifier) {
				jsonifiedList.Add (string.Format (
					"{2}\n\t\"name\": \"{0}\",\n\t\"value\":\"{1}\"\n{3}", item.Key, item.Value, "{", "}"));
			}
			ExercisesJson = string.Format ("[{0}]", string.Join (", \n", jsonifiedList));
		}

		public Dictionary<string, string> GetEnumStrings(List<string> exercises)
		{
			var workoutEnums = new Dictionary<string, string> ();
			foreach (var exercise in exercises) {
				var enumExer = Regex.Replace(exercise, "[^0-9a-zA-Z]+", "");
				foreach (var item in numberToAlphabet) {
					enumExer = enumExer.Replace (item.Key, item.Value);
				}
				workoutEnums.Add (exercise, enumExer);
			}

			return workoutEnums;
		}
	}
}

