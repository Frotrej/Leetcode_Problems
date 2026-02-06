using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_pomoc
{
	internal class TransformedArray
	{
		public int[] TransformedArrayMethod(int[] nums)
		{
			int[] result = new int[nums.Length];
			int i = 0;
			int resultIndex = 0;

			foreach (var item in nums)
			{
				i = resultIndex;

				if (nums[i] == 0) { }
				else i = ((i + nums[i]) % nums.Length + nums.Length) % nums.Length;

				result[resultIndex] = nums[i];
				resultIndex++;
			}
			return result;
		}
	}
}
