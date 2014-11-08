using System;
using System.Net.Http;
using System.Net;

namespace Cassini.FitocracyAnalyzer.Fetcher
{
	public class FitocracyHttpClient : HttpClient
	{
		public FitocracyHttpClient (CookieContainer cookieContainer) : base (
			new HttpClientHandler {
				CookieContainer = cookieContainer,
				UseCookies = true,
				UseDefaultCredentials = false
			} as HttpMessageHandler)
		{
		}

		public void AddDefaultHeaders ()
		{
			DefaultRequestHeaders.Add ("Accept", @"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
			DefaultRequestHeaders.Add ("Accept-Encoding", @"gzip,deflate,sdch");
			DefaultRequestHeaders.Add ("Accept-Language", @"en-US,en;q=0.8");
			DefaultRequestHeaders.Add ("Connection", "keep-alive");
			DefaultRequestHeaders.Add ("DNT", "1");
			DefaultRequestHeaders.Add ("Referer", Constants.FitocracyLoginUrl);
			DefaultRequestHeaders.Add ("Origin", Constants.FitocracyHome);
			DefaultRequestHeaders.Add ("User-Agent", Constants.UserAgentString);
		}
	}
}

