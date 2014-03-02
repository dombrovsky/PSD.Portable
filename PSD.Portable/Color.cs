namespace Psd.Portable
{
	public struct Color
	{
	    private readonly byte _r;
        private readonly byte _g;
        private readonly byte _b;

		public Color (byte r, byte g, byte b)
		{
			_r = r;
			_g = g;
			_b = b;
		}

        public byte R { get { return _r; } }
        public byte G { get { return _g; } }
        public byte B { get { return _b; } }
	}
}

