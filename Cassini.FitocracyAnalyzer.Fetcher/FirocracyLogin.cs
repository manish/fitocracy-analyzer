using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Cassini.FitocracyAnalyzer.Fetcher
{
	public class FirocracyLogin
	{
		public CookieContainer CookieContainer {
			get;
			private set;
		}

		public string CsrfToken {
			get;
			private set;
		}

		public FirocracyLogin (string username, string password)
		{
			/*var csrftokenCookieTuple = WebUtils.GetCsrfTokenAsync ().Result;
			CsrfToken = csrftokenCookieTuple.Item1;
			CookieContainer = csrftokenCookieTuple.Item2;*/

			/*using (var client = new FitocracyHttpClient (CookieContainer)) {
				client.AddDefaultHeaders ();
				var content = new FormUrlEncodedContent(new [] 
					{
						new KeyValuePair<string, string>("username", username),
						new KeyValuePair<string, string>("password", password),
						new KeyValuePair<string, string>("csrfmiddlewaretoken", CsrfToken),
						new KeyValuePair<string, string>("login", "Log In"),
						new KeyValuePair<string, string>("next", "/home/"),
						new KeyValuePair<string, string>("is_username", "1"),
					});
				var result = client.PostAsync(Constants.FitocracyRequestUrl, content).Result;
				var cookieCollection = CookieContainer.GetCookies (new Uri (Constants.FitocracyRequestUrl));
				if (result.StatusCode != HttpStatusCode.OK)
					throw new WebException (string.Format (
						"Login failed for user '{0}' with status {1}", username, result.StatusCode));

				var home = client.GetAsync ("https://www.fitocracy.com/profile/m4n1sh/?feed").Result;
				var header = result.Content.Headers.GetValues("X-Fitocracy-User").FirstOrDefault();
			}*/

			using (var client = new HttpClient ()) {
				var response = client.GetAsync ("https://www.reddit.com/").Result;
				var data = response.Content.ReadAsStringAsync ().Result;
			}
		}
	}

}


