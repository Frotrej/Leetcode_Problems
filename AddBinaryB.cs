using System.Numerics;
using System.Text;

namespace Leetcode_pomoc
{
	internal class AddBinaryB
	{
		public string AddBinaryMethod(string a, string b)
		{
			BigInteger numA = BigInteger.Zero;
			BigInteger numB = BigInteger.Zero;

			foreach (char item in a)
			{
				numA = (numA << 1);
				if (item == '1') numA += 1;
			}

			foreach (char item in b)
			{
				numB = (numB << 1);
				if (item == '1') numB += 1;
			}

			numB += numA;

			if (numB == 0) return "0";

			StringBuilder sb = new StringBuilder();

			while (numB > 0)
			{
				sb.Insert(0, (numB & 2) == 0 ? '0' : '1');
				numB = numB >> 1;
			}

			return sb.ToString();	
		}
	}
}
