using System.ComponentModel.DataAnnotations;

namespace Leetcode_pomoc
{
    internal class Program
    {
        static void Main()
        {
            int[] a = { 1,2,3,0,0,0 };
            int[] b = { 2,5,6 };

            MergeSortedArray merge = new MergeSortedArray();
            merge.MergeSortedArrayMethod(a, 3, b, b.Length);

		}
	}
}
