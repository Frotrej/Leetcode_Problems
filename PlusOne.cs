using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_pomoc
{
	internal static class PlusOne
	{
		public static int[] PlusOneMethod(int[] digits)
		{

			for (int i = digits.Length - 1; i >= 0; i--)
			{

				if (digits[i] < 9)
				{
					digits[i] = digits[i]+1;
					return digits;
				}
				else
				{
					digits[i] = 0;
				}
			}

			digits = new int[digits.Length + 1];
			digits[0] = 1;
			return digits;
		}
	}
}