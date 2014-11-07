using System;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace Cassini.FitocracyAnalyzer.Fetcher
{
	public class MyClass
	{
		public MyClass (string userName, string password)
		{
			var csrf = WebUtils.GetCsrfTokenAsync ().Result;
		}
	}
}

