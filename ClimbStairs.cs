using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_pomoc
{
	internal class ClimbStairs
	{
		public int ClimbStairsMethod(int n)
		{
			int shortSteps = n;
			int longSteps = 0;
			double result = 0;
			
			while (shortSteps >= 0)
			{

				result += Factorial(shortSteps+longSteps) / (Factorial(shortSteps) * Factorial(longSteps));

				shortSteps -= 2;
				longSteps += 1;
			}
			
			return (int)result;
		}

		private double Factorial(int n)
		{
			double result = 1;

			for (int i = 2; i <= n; i++)
			{
				result *= (double)i;
			}

			return result;

		}
	}
}
