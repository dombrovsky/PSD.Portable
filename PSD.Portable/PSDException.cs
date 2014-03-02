using System;

namespace Psd.Portable
{
	public class PSDException : Exception
	{
		public PSDException () :base() {}
		public PSDException(string message) : base(message) {}
		public PSDException(string message, Exception innerException) : base(message, innerException) {}
	}
}

