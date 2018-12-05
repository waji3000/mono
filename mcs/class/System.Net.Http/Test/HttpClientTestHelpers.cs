using System;
using System.Reflection;
using System.Net.Http;

namespace MonoTests.System.Net.Http
{
	static class HttpClientTestHelpers
	{
#if LEGACY_HTTPCLIENT
		internal static bool IsSocketsHandler => false;
#else
		internal static bool IsSocketsHandler => true;
#endif
	}
}
