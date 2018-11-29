using System;

namespace RSA
{
	class RandomULong
	{
		private readonly Random rnd = new Random();
		public ulong Get64BitRandom(ulong minValue, ulong maxValue)
		{
			byte[] buffer = new byte[sizeof(ulong)];
			rnd.NextBytes(buffer);
			return (BitConverter.ToUInt64(buffer, 0) % (maxValue - minValue + 1)) + minValue;
		}
	}
}
