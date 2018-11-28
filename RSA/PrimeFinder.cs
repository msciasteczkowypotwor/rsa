using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
	class PrimeFinder
	{
		public bool IsPrime(int number)
		{
			if (number == 2)
				return true;
			if (number == 3)
				return true;
			if (number % 2 == 0)
				return false;
			if (number % 3 == 0)
				return false;
			int i = 5;
			int w = 2;

			while (i * i <= number)
			{
				if (number % i == 0)
					return false;
				i += w;
				w = 6 - w;
			}
			return true;
		}
		public List<int> GenerateListOfPrimesInRange(int a, int b)
		{
			List<int> lista = new List<int>();
			for(int i = a; i <= b; i++)
			{
				if (IsPrime(i))
				{
					lista.Add(i);
				}
			}
			return lista;
		}
	}
}
