using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;

namespace Cassini.FitocracyAnalyzer.Fetcher
{
	public class FirocracyLogin
	{
		public FirocracyLogin (string username, string password)
		{
			var csrftokenTuple = WebUtils.GetCsrfTokenAsync ().Result;

			var handler = new HttpClientHandler
			{
				CookieContainer = csrftokenTuple.Item2,
				UseCookies = true,
				UseDefaultCredentials = false
			};
			using (var client = new HttpClient (handler as HttpMessageHandler)) {
				var content = new FormUrlEncodedContent(new [] 
					{
						new KeyValuePair<string, string>("username", username),
						new KeyValuePair<string, string>("password", password),
						new KeyValuePair<string, string>("csrfmiddlewaretoken", csrftokenTuple.Item1),
						new KeyValuePair<string, string>("login", "Log In"),
						new KeyValuePair<string, string>("next", "/home/"),
						new KeyValuePair<string, string>("is_username", "1"),
					});
				client.DefaultRequestHeaders.Add ("Accept", @"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
				client.DefaultRequestHeaders.Add ("Accept-Encoding", @"gzip,deflate,sdch");
				client.DefaultRequestHeaders.Add ("Accept-Language", @"en-US,en;q=0.8");
				client.DefaultRequestHeaders.Add ("Connection", "keep-alive");
				client.DefaultRequestHeaders.Add ("DNT", "1");
				client.DefaultRequestHeaders.Add ("Referer", Constants.FitocracyLoginUrl);
				client.DefaultRequestHeaders.Add ("Origin", Constants.FitocracyHome);
				client.DefaultRequestHeaders.Add ("User-Agent", Constants.UserAgentString);
				var result = client.PostAsync(Constants.FitocracyRequestUrl, content).Result;
			}
		}
	}
}

