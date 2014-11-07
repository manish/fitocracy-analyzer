using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using System.Net;
using System;
using System.Net.Http.Headers;

namespace Cassini.FitocracyAnalyzer.Fetcher
{
	public static class WebUtils
	{
		public static async Task<Tuple<string,CookieContainer>> GetCsrfTokenAsync ()
		{
			var cookieJar = new CookieContainer();
			var handler = new HttpClientHandler
			{
				CookieContainer = cookieJar,
				UseCookies = true,
				UseDefaultCredentials = false
			};
			using (var client = new HttpClient (handler as HttpMessageHandler)) {
				var fito = await client.GetAsync (Constants.FitocracyHome);
				var cookieCsrftoken = fito.Headers.First (
					x => x.Key == "Set-Cookie").Value.First (
						x => x.Contains (Constants.CsrfTokenKey));
				var csrftokenPair = cookieCsrftoken.Split (
					new [] { ';' }).First (x => x.Contains (Constants.CsrfTokenKey));
				return new Tuple<string,CookieContainer> (csrftokenPair.Split (new [] { '=' }) [1].Trim (), cookieJar);
			}
		}
	}
}

