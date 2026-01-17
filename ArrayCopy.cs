using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_pomoc
{
	internal static class ArrayCopy
	{
		public static void ArrayCopyMethod()
		{
			int[] sourceArray = { 1, 2, 3, 4, 5 };
			int[] destinationArray = new int[sourceArray.Length + 1];
			destinationArray[0] = 1;
			// Copy elements from sourceArray to destinationArray starting at index 2
			Array.Copy(sourceArray, 0, destinationArray, 1, sourceArray.Length);
			Console.WriteLine("Destination Array after Copy:");
			foreach (var item in destinationArray)
			{
				Console.Write($"{item} ");
			}
		}
	}
}
