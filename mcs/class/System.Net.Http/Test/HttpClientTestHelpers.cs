using System;
using System.Reflection;
using System.Net.Http;

namespace MonoTests.System.Net.Http
{
	static class HttpClientTestHelpers
	{
		internal static bool IsSocketsHandler {
			get;
		}

		static HttpClientTestHelpers ()
		{
			var asm = typeof (HttpClient).Assembly;
			var type = asm.GetType ("System.Net.Http.SocketsHttpHandler", false);
			IsSocketsHandler = type != null;
		}
	}
}
