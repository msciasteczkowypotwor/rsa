using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
	class VariablesGenerator
	{
		public int p;
		public int q;
		public ulong n;
		public ulong phi;
		public ulong e;
		public ulong d;
		public List<int> listOfPrimes;

		public object BigInteger { get; private set; }

		public List<int> GenerateListOfPrimes(int a, int b)
		{
			PrimeFinder primeFinder = new PrimeFinder();
			List<int> list = primeFinder.GenerateListOfPrimesInRange(a, b);
			return list;
		}
		public void SelectRandomPandQ()
		{
			Random random = new Random();
			p = listOfPrimes[random.Next(0, listOfPrimes.Count)];
			q = listOfPrimes[random.Next(0, listOfPrimes.Count)];
		}
		public void CalculateN()
		{
			n = (ulong)p * (ulong)q;
		}
		public void CalculatePhi()
		{
			phi = (ulong)(p - 1) * (ulong)(q - 1);
		}
		public void CalculateE()
		{
			e = FindPhiCoprime(2, phi - 1);
		}
		private ulong FindPhiCoprime(ulong a, ulong b)
		{
			RandomULong randomULong = new RandomULong();
			ulong pom;
			do
			{
				pom = randomULong.Get64BitRandom(a, b);
			}
			while (IsCoprimeWithPhi(pom));
			return pom;

		}
		private bool IsCoprimeWithPhi(ulong number)
		{
			ulong a = phi;
			ulong b = number;
			while (a != b)
			{
				if (a < b)
				{
					b = b - a;
				}
				else if (b < a)
				{
					a = a - b;
				}
			}
			if (a == 1)
				return true;
			return false;
		}
		public void CalculateD()
		{
			

		}
	}
}
