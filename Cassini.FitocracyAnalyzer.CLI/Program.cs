using System;
using System.Linq;
using System.IO;

using Mono.Options;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

using System.Threading;
using Cassini.FitocracyAnalyzer.Core;


namespace Cassini.FitocracyAnalyzer.CLI
{
	class MainClass
	{
		static string appName = "fito-analyzer";

		public static void Main (string[] args)
		{
			var show_help = false;
			string username = null, password = "";
			ConsoleKeyInfo key;

			var p = new OptionSet () {
				string.Format ("Usage: {0} [OPTIONS]", appName),
				"Parse your fitocracy HTML data",
				"",
				{ "u|username=", "Fitocracy username",   v => username = v },
				{ "h|help",  "show this message and exit", 
					v => show_help = v != null
				}
			};

			try {
				p.Parse (args);
			}
			catch (OptionException) {
				ShowError ();
				return;
			}

			if (show_help) {
				p.WriteOptionDescriptions (Console.Out);
				return;
			}

			if (username == null) {
				Console.Write ("Username: ");
				username = Console.ReadLine ();
			}

			Console.Write ("Password: ");
			do
			{
				key = Console.ReadKey(true);

				if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
				{
					password += key.KeyChar;
					Console.Write("*");
				}
				else
				{
					if (key.Key == ConsoleKey.Backspace && password.Length > 0)
					{
						password = password.Substring(0, (password.Length - 1));
						Console.Write("\b \b");
					}
				}
			} while (key.Key != ConsoleKey.Enter);

			Crawler crawler = new Crawler (username, password);
			crawler.LevelUps += (sender, e) => {
				var lu = e.LevelUp;
				Console.WriteLine ("Level: {0}, DateTime: {1}, Props: {2}",
					lu.Level, lu.Date, lu.Props.Count);
			};
			crawler.Workouts += (sender, e) => {
				var wo = e.Workout;
				Console.WriteLine ("DateTime: {0} | TotalPoints {1} | Name: {2} | Total exercises: {3}",
					wo.DateTime, wo.TotalPoints, wo.WorkoutName, wo.Exercises.Count);
			};
			crawler.Crawl ();
		}

		static void ShowError (string message = null)
		{
			Console.WriteLine ("Error: " + message);
			Console.WriteLine (string.Format ("    Try '{0} --help' for more information.", appName));
		}
	}
}
