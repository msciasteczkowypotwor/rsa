using System;
using System.Collections.Generic;
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
		public List<int> list;

		public List<int> GetListOfPrimes(int a, int b)
		{
			PrimeFinder primeFinder = new PrimeFinder();
			List<int> list = primeFinder.GenerateListOfPrimesInRange(a,b);
			return list;
		}
		public void SelectRandomPandQ()
		{
			Random random = new Random();
			p = list[random.Next(0, list.Count)];
			q= list[random.Next(0, list.Count)];
		}
		public void CalculateN()
		{
			n = (ulong)p * (ulong)q;
		}
		public void CalculatePhi()
		{
			phi = (ulong)(p - 1) * (ulong)(q - 1);
		}
		public void GenerateE()
		{

		}
	}
}
