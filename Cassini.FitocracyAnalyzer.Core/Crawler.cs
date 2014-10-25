﻿using System;
using OpenQA.Selenium.Firefox;
using System.Threading;

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

		public Crawler (string username, string password)
		{
			uname = username;
			passwd = password;

			firefoxBinary = new FirefoxBinary (osxFirefoxLocation);
			firefoxProfile.SetPreference("browser.download.folderList",2);
		}

		public void Crawl ()
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
				driver.Navigate().GoToUrl("http://www.fitocracy.com/profile/");

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
					indexer += 15;
					Console.WriteLine (indexer + ":" +workouts.Count);
				}
			}
		}
	}
}

