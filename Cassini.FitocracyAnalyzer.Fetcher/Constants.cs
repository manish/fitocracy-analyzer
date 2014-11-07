using System;

namespace Cassini.FitocracyAnalyzer.Fetcher
{
	public static class Constants
	{
		public static readonly string FitocracyHome = "http://fitocracy.com";

		public static readonly string FitocracyRequestUrl = "https://www.fitocracy.com/home/";

		public static readonly string FitocracyLoginUrl = "https://www.fitocracy.com/accounts/login/";

		public static readonly string UserAgentString = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/38.0.2125.111 Safari/537.36";

		public static readonly string CsrfTokenKey = "csrftoken";
	}
}

