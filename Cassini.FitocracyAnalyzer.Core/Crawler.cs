using System;
using System.Linq;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.Globalization;
using Cassini.FitocracyAnalyzer.Core.Types;
using System.Text.RegularExpressions;

namespace Cassini.FitocracyAnalyzer.Core
{
	public class Crawler
	{
		static readonly string fitocracyHomePage = "http://www.fitocracy.com/";
		static readonly string fitocracyProfilePage = "http://www.fitocracy.com/profile/";

		static readonly string osxFirefoxLocation = "/Applications/Firefox.app/Contents/MacOS/firefox-bin";
		readonly FirefoxBinary firefoxBinary;
		readonly FirefoxProfile firefoxProfile = new FirefoxProfile ();

		readonly string uname;
		readonly string passwd;

		string userId;

		public event EventHandler<LevelUpEventArgs> LevelUps;

		public event EventHandler<WorkoutEventArgs> Workouts;

		public Crawler (string username, string password)
		{
			uname = username;
			passwd = password;

			firefoxBinary = new FirefoxBinary (osxFirefoxLocation);
			firefoxProfile.SetPreference("browser.download.folderList",2);
		}

		public void Crawl (DateTime before)
		{
			using (var driver = new FirefoxDriver (firefoxBinary, firefoxProfile)) {
				driver.Manage ().Timeouts ().SetPageLoadTimeout (new TimeSpan (0, 0, 30));

				driver.Navigate().GoToUrl(fitocracyHomePage);
				var loginButton = driver.FindElementByXPath("//a[@href='/accounts/login/?next=/']");
				loginButton.Click ();

				var withUsernameButton = driver.FindElementByXPath("//div[@class='fito-icon medium gray actionable labeled-icon widget-full-width-block login-username-link']");
				withUsernameButton.Click ();

				var userField = driver.FindElementById ("username-login-username");
				userField.SendKeys (uname);
				var passField = driver.FindElementById ("username-login-password");
				passField.SendKeys (passwd);
				var submitButton = driver.FindElementById ("username-login-submit");
				submitButton.Click ();

				Thread.Sleep (1000);
				driver.Navigate().GoToUrl(fitocracyProfilePage);

				var imgElement = driver.FindElementByXPath ("//input[@name='profile_user']");
				userId = imgElement.GetAttribute ("value");

				var indexer = 0;
				while(true) {

					Thread.Sleep (2000);
					var firstUrl = string.Format ("https://www.fitocracy.com/activity_stream/{0}/?user_id={1}",
						indexer, userId);
					driver.Navigate ().GoToUrl (firstUrl);

					var allStreamItems = driver.FindElementsByXPath ("//div[@class='stream_item clearfix stream-item-safe']");
					if (allStreamItems.Count == 0)
						return;

					var workouts = driver.FindElementsByXPath ("//div[@data-ag-type='workout']");
					foreach (var workout in workouts)
						HandleWorkout (workout, before);

					var levelUps = driver.FindElementsByXPath ("//div[@data-ag-type='levelup']");
					foreach (var levelUp in levelUps)
						HandleLevelUp (levelUp);

					indexer += 15;
				}
			}
		}

		protected void HandleWorkout (IWebElement workout, DateTime before)
		{
			var work = new Workout ();

			var workoutDateTime = workout.FindElement (By.XPath (".//div[@class='stream-item-headline']/a[@class='action_time gray_link']"));
			work.DateTime = DateTime.ParseExact (workoutDateTime.Text, "s", CultureInfo.InvariantCulture);
			if (work.DateTime > before)
				return;

			var workoutHeader = workout.FindElement (By.XPath (".//div[@class='stream-item-headline']/span[@class='stream-type']"));
			var forIndex = workoutHeader.Text.IndexOf ("for", StringComparison.InvariantCultureIgnoreCase);
			work.WorkoutName = workoutHeader.Text.Remove (forIndex).Replace ("tracked", string.Empty).Trim ();

			var workoutPoints = workoutHeader.FindElement (By.XPath (".//span[@class='stream_total_points']")).Text;
			work.TotalPoints = Convert.ToInt32 (workoutPoints.Replace ("pts", string.Empty).Replace(",",""));

			var workoutIdNode = workout.FindElement (By.XPath (".//div[@class='stream-item-headline']/a[@class='collapse-stream-item chevron-icon tiny-vertical dark up']"));
			var workoutId = workoutIdNode.GetAttribute ("data-item-id");
			work.Id = Convert.ToInt64 (workoutId);

			var actionDetail = workout.FindElement (By.XPath (".//ul[@class='action_detail']"));
			var lis = actionDetail.FindElements (By.XPath ("li"));
			foreach (var li in lis) {
				var liName = li.FindElement (By.ClassName ("action_prompt")).Text;
				if (liName.StartsWith ("Group", StringComparison.OrdinalIgnoreCase)) {
					var subLis = li.FindElements (By.XPath ("div/div/ul/li"));
					foreach (var subLi in subLis)
						work.Exercises.Add (WorkoutFactory.GetExercise (subLi));
				} else {
					work.Exercises.Add (WorkoutFactory.GetExercise (li));
				}
			}

			if (Workouts != null)
				Workouts (this, new WorkoutEventArgs (work));
		}

		protected void HandleLevelUp (IWebElement levelUp)
		{
			var levelRaw = levelUp.FindElement (

				By.XPath (".//div[@class='dramatic-description']")).Text;
			var dateRaw = levelUp.FindElement (
				By.XPath (".//a[@class='action_time gray_link']")).Text;

			var propsRaw = levelUp.FindElement (By.XPath (".//span[@class='prop-list']"));
			var propsListRaw = propsRaw.FindElements(
				By.XPath (".//span")).Select (x => x.Text.Replace(",","")).ToList ();

			string levelStr = levelRaw.Split (new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries) [1];
			int level = Convert.ToInt32 (levelStr);


			DateTime dateTime = DateTime.ParseExact (dateRaw, "s", CultureInfo.InvariantCulture);

			var levelUpInst = new LevelUp (level, dateTime, propsListRaw);

			if (LevelUps != null)
				LevelUps (this, new LevelUpEventArgs (levelUpInst));
		}
	}
}


