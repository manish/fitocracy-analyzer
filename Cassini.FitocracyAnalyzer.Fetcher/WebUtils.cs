using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;

namespace Cassini.FitocracyAnalyzer.Fetcher
{
	public static class WebUtils
	{
		public static async Task<string> GetCsrfTokenAsync () 
		{
			using (var client = new HttpClient ()) {
				var fito = await client.GetAsync (Constants.FitocracyHome);
				var cookieCsrftoken = fito.Headers.First (
					x => x.Key == "Set-Cookie").Value.First (
						x => x.Contains (Constants.CsrfTokenKey));
				var csrftokenPair = cookieCsrftoken.Split (
					new [] { ';' }).First (x => x.Contains (Constants.CsrfTokenKey));
				return csrftokenPair.Split (new [] { '=' }) [1].Trim ();
			}
		}
	}
}

