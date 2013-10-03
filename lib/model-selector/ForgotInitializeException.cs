using System;

namespace CMake
{
	namespace Exception
	{
		public class ForgotInitializeException : System.Exception
		{
			public ForgotInitializeException(string message) : base(message) { }
		}
	}
}