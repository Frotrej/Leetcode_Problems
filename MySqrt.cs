using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_pomoc
{
	internal class MySqrt
	{
		public int MySqrtMethod(int x)
		{
			double rightRange = 1;
			double leftRange = 0;
			double diff = 0;

			while (rightRange < x)
			{
				rightRange *= 2;
			}

			leftRange = rightRange / 2;
			diff = rightRange - leftRange;

			while (rightRange-1 <= leftRange)
			{
				int guess = (int)((rightRange - diff) * (rightRange - diff));

				if( guess == x)
				{
					return (int)(rightRange - diff);
				}

				if (guess*guess > x)
				{
					rightRange -= diff;
				}
				else
				{
					leftRange += diff;
				}




			}



			return (int)rightRange;
		}
	}
}
